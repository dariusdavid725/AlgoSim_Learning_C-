using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Teorie_QuickSort : Form
    {
        private List<int> numbers;
        private Task sortingTask;
        private CancellationTokenSource cancellationTokenSource;
        private bool isPaused;
        private int currentLeftIndex;
        private int currentRightIndex;
        private readonly Random random = new Random();
        private readonly Brush defaultBrush = new SolidBrush(Color.FromArgb(197, 62, 58)); // ARGB 255, 0, 128, 128
        private readonly Brush highlightBrush = Brushes.DarkRed;

        public Teorie_QuickSort()
        {
            InitializeComponent();
            SetBackgroundImage();
            DisplayQuickSortCode();
            InitializeNumbers();
        }

        private void SetBackgroundImage()
        {
            this.BackgroundImage = Properties.Resources.background_gradient;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
        }

        private void InitializeNumbers()
        {
            // Generate a list of 20 random heights between 10 and 60
            numbers = Enumerable.Range(1, 20).Select(_ => random.Next(10, 43)).ToList();
            simulationPanel.Invalidate();
            ResetProgressBar();
        }

        private void ResetProgressBar()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = numbers.Count;
            progressBar.Value = 0;
        }

        private void UpdateProgressBar()
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum)));
            }
            else
            {
                progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
            }
        }

        private void Teorie_QuickSort_Load(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
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

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            InitializeNumbers();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                isPaused = false;
                return;
            }

            if (sortingTask != null && !sortingTask.IsCompleted)
            {
                return;
            }

            cancellationTokenSource = new CancellationTokenSource();
            isPaused = false;
            sortingTask = Task.Run(() => QuickSort(numbers, 0, numbers.Count - 1, cancellationTokenSource.Token));
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            isPaused = true;
        }

        private async Task QuickSort(List<int> array, int left, int right, CancellationToken token)
        {
            if (left < right)
            {
                int pivot = await Partition(array, left, right, token);
                var leftTask = QuickSort(array, left, pivot - 1, token);
                var rightTask = QuickSort(array, pivot + 1, right, token);
                await Task.WhenAll(leftTask, rightTask);
            }
        }

        private async Task<int> Partition(List<int> array, int left, int right, CancellationToken token)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (token.IsCancellationRequested) return -1;

                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                    currentLeftIndex = i;
                    currentRightIndex = j;
                    await Task.Delay(150);  // Pause for visualization
                    simulationPanel.Invalidate();
                    UpdateProgressBar();
                }

                while (isPaused)
                {
                    await Task.Delay(150);
                }
            }
            Swap(array, i + 1, right);
            currentLeftIndex = i + 1;
            currentRightIndex = right;
            await Task.Delay(150);  // Pause for visualization
            simulationPanel.Invalidate();
            UpdateProgressBar();
            return i + 1;
        }

        private void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void simulationPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int tileWidth = simulationPanel.Width / numbers.Count;
            for (int i = 0; i < numbers.Count; i++)
            {
                Brush brush = defaultBrush;
                if (sortingTask != null && !sortingTask.IsCompleted)
                {
                    if (i == currentLeftIndex || i == currentRightIndex)
                    {
                        brush = highlightBrush;
                    }
                }
                g.FillRectangle(brush, i * tileWidth, simulationPanel.Height - numbers[i] * 10, tileWidth, numbers[i] * 10);
            }
        }

        private void DisplayQuickSortCode()
        {
            string codeSnippet = @"#include <iostream>
using namespace std;
void QuickSort(int v[], int st, int dr)
{
    if(st < dr)
    {

        int m = (st + dr) / 2;
        int aux = v[st];
        v[st] = v[m];
        v[m] = aux;
        int i = st , j = dr, d = 0;
        while(i < j)
        {
            if(v[i] > v[j])
            {
                aux = v[i];
                v[i] = v[j];
                v[j] = aux;
                d = 1 - d;
            }
            i += d;
            j -= 1 - d;
        }
        QuickSort(v, st , i - 1);
        QuickSort(v, i + 1 , dr);
    }
}
int main() {
     int n, a[100001], dr;
     cin>>n;
     for(int i = 0;i<n;i++)
     {
         cin>>a[i];
          dr = i;
     }
    QuickSort(a, 0, dr);
     for(int i = 0;i<n;i++)
         cout<<a[i]<<"" "";
    return 0;
}";
            richTextBox1.Text = codeSnippet;

            string explanation = @"Quick Sort este un algoritm de sortare foarte eficient care utilizează o abordare divide-et-impera. Are o complexitate de timp în caz mediu de O(n log n) și nu este stabil.";
            richTextBox2.Text = explanation;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
