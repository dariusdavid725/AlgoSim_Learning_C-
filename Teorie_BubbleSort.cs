using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Teorie_BubbleSort : Form
    {
        private int[] array;
        private CancellationTokenSource cts;

        public Teorie_BubbleSort()
        {
            InitializeComponent();
            SetBackgroundImage();
            DisplayBubbleSortCode();
            InitializeArray();
        }

        private void SetBackgroundImage()
        {
            this.BackgroundImage = Properties.Resources.background_gradient; // Set to the gradient background
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
        }

        private void InitializeArray()
        {
            array = new int[20]; // More elements
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            DrawArray(pictureBox1.CreateGraphics(), array, pictureBox1.Width / array.Length, array.Max());
            ResetProgressBar(); // Reset the progress bar whenever the array is initialized
        }

        private void ResetProgressBar()
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = array.Length * (array.Length - 1) / 2; // Total number of comparisons in bubble sort
        }

        private void Teorie_BubbleSort_Load(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            DrawArray(pictureBox1.CreateGraphics(), array, pictureBox1.Width / array.Length, array.Max());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Application.OpenForms.Count > 0)
            {
                Study studyForm = Application.OpenForms.OfType<Study>().FirstOrDefault();
                if (studyForm != null)
                {
                    studyForm.Show();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // No action needed
        }

        private void DisplayBubbleSortCode()
        {
            string codeSnippet = @"#include <iostream>

using namespace std;

int main()
{
    int v[101],n,i,ok=0;
    cin>>n;
    for(i=1;i<=n;++i)cin>>v[i];
    while(ok==0)
    {
        ok=1;
        for(i=1;i<=n-1;++i)
            if(v[i]>v[i+1])
        {
             v[0]=v[i];
             v[i]=v[i+1];
             v[i+1]=v[0];
             ok=0;
        }
    }
    for(i=1;i<=n;++i)cout<<v[i]<<"" "";
    return 0;
}";
            richTextBox1.Text = codeSnippet;
        }

        private async Task VisualizeBubbleSort(int[] arr, CancellationToken token)
        {
            int n = arr.Length;
            Graphics g = pictureBox1.CreateGraphics();
            int width = pictureBox1.Width / n;
            int maxValue = arr.Max();
            int totalSteps = 0; // Total number of comparisons to complete the sort

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    if (arr[j] > arr[j + 1])
                    {
                        // Swap elements
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        // Redraw the array with only the moving tile highlighted
                        DrawArray(g, arr, width, maxValue, j + 1);

                        // Delay for visualization
                        await Task.Delay(200); // Slower delay

                        // Update the progress bar
                        progressBar1.Value = ++totalSteps;
                    }
                    else
                    {
                        // Update the progress bar even if no swap occurs
                        progressBar1.Value = ++totalSteps;
                    }
                }
            }
        }

        private void DrawArray(Graphics g, int[] arr, int width, int maxValue, int movingIndex = -1)
        {
            g.Clear(pictureBox1.BackColor);

            for (int i = 0; i < arr.Length; i++)
            {
                int height = (int)((arr[i] / (float)maxValue) * pictureBox1.Height);
                Brush brush;
                if (i == movingIndex)
                {
                    brush = Brushes.DarkRed;
                }
                else
                {
                    brush = new SolidBrush(Color.FromArgb(197, 62, 58)); // Darker color
                }

                g.FillRectangle(brush, i * width, pictureBox1.Height - height, width, height);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            array = array.OrderBy(x => rand.Next()).ToArray();
            DrawArray(pictureBox1.CreateGraphics(), array, pictureBox1.Width / array.Length, array.Max());
            ResetProgressBar(); // Reset the progress bar whenever the array is shuffled
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            try
            {
                await VisualizeBubbleSort(array, cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Handle the cancellation if necessary
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}