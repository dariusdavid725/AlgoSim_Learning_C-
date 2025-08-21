using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Teorie_MergeSort : Form
    {
        private List<int> numbers;
        private Task sortingTask;
        private CancellationTokenSource cancellationTokenSource;
        private bool isPaused;
        private int currentMergeIndex = -1; // Index of the currently moving tile
        private readonly Random random = new Random();
        private readonly Brush defaultBrush = new SolidBrush(Color.FromArgb(197, 62, 58)); // ARGB 255, 0, 128, 128
        private readonly Brush highlightBrush = Brushes.DarkRed;
        private int stepsCompleted; // Steps completed for progress bar

        public Teorie_MergeSort()
        {
            InitializeComponent();
            SetBackgroundImage();
            DisplayMergeSortCode();
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
            // Generate a list of 20 random heights between 10 and 35
            numbers = Enumerable.Range(1, 20).Select(_ => random.Next(10, 43)).ToList();
            simulationPanel.Invalidate();
            ResetProgressBar();
        }

        private void ResetProgressBar()
        {
            int n = numbers.Count;
            int maxSteps = CalculateMergeSortSteps(n);
            progressBar.Minimum = 0;
            progressBar.Maximum = maxSteps;
            progressBar.Value = 0;
            stepsCompleted = 0;
        }

        private int CalculateMergeSortSteps(int n)
        {
            return (int)Math.Ceiling(n * Math.Log(n, 2)); // Approximation of merge sort steps
        }

        private void Teorie_MergeSort_Load(object sender, EventArgs e)
        {
            // No additional setup needed
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studyForm = Application.OpenForms.OfType<Study>().FirstOrDefault();
            if (studyForm != null)
            {
                studyForm.Show();
            }
            else
            {
                studyForm = new Study();
                studyForm.Show();
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
            sortingTask = Task.Run(() => MergeSort(numbers, 0, numbers.Count - 1, cancellationTokenSource.Token));
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            isPaused = true;
        }

        private async Task MergeSort(List<int> array, int left, int right, CancellationToken token)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                var leftTask = MergeSort(array, left, middle, token);
                var rightTask = MergeSort(array, middle + 1, right, token);

                await Task.WhenAll(leftTask, rightTask);

                await Merge(array, left, middle, right, token);
            }
        }

        private async Task Merge(List<int> array, int left, int middle, int right, CancellationToken token)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(array.ToArray(), left, leftArray, 0, leftSize);
            Array.Copy(array.ToArray(), middle + 1, rightArray, 0, rightSize);

            int i = 0, j = 0, k = left;

            while (i < leftSize && j < rightSize)
            {
                if (token.IsCancellationRequested) return;

                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    currentMergeIndex = k;
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    currentMergeIndex = k;
                    j++;
                }
                k++;

                await Task.Delay(150);  // Increase the delay for a slower simulation
                simulationPanel.Invalidate();

                UpdateProgressBar();

                while (isPaused)
                {
                    await Task.Delay(150);
                }
            }

            while (i < leftSize)
            {
                array[k] = leftArray[i];
                currentMergeIndex = k;
                i++;
                k++;

                await Task.Delay(300);  // Increase the delay for a slower simulation
                simulationPanel.Invalidate();

                UpdateProgressBar();

                while (isPaused)
                {
                    await Task.Delay(100);
                }
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                currentMergeIndex = k;
                j++;
                k++;

                await Task.Delay(300);  // Increase the delay for a slower simulation
                simulationPanel.Invalidate();

                UpdateProgressBar();

                while (isPaused)
                {
                    await Task.Delay(100);
                }
            }

            currentMergeIndex = -1;
        }

        private void UpdateProgressBar()
        {
            stepsCompleted++;
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => progressBar.Value = Math.Min(stepsCompleted, progressBar.Maximum)));
            }
            else
            {
                progressBar.Value = Math.Min(stepsCompleted, progressBar.Maximum);
            }
        }

        private void simulationPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int tileWidth = simulationPanel.Width / numbers.Count;
            for (int i = 0; i < numbers.Count; i++)
            {
                Brush brush = (i == currentMergeIndex) ? highlightBrush : defaultBrush;
                g.FillRectangle(brush, i * tileWidth, simulationPanel.Height - numbers[i] * 10, tileWidth, numbers[i] * 10);
            }
        }

        private void DisplayMergeSortCode()
        {
            string codeSnippet = @"#include <iostream>
using namespace std;

int n , v[100005], tmp[100005];

void MergeSort(int st, int dr)
{
    if(st < dr)
    {
        int m = (st + dr) / 2;
        MergeSort(st , m);
        MergeSort(m + 1 , dr);
       
        int i = st, j = m + 1, k = 0;
        while( i <= m && j <= dr )
            if( v[i] < v[j])
                tmp[++k] = v[i++];
            else
                tmp[++k] = v[j++];
        while(i <= m)
            tmp[++k] = v[i++];
        while(j <= dr)
            tmp[++k] = v[j++];
        for(i = st , j = 1 ; i <= dr ; i ++ , j ++)
            v[i] = tmp[j];
    }
}

int main(){
    cin >> n;
    for(int i = 0 ; i < n ; i ++)
        cin >> v[i];
    MergeSort(0 , n - 1);
    for(int i = 0 ; i < n ; i ++)
        cout << v[i] << "" "";
    return 0;
}";
            richTextBox1.Text = codeSnippet;

            string explanation = @"Merge Sort este un algoritm divide-et-impera care împarte array-ul în jumătăți, sortează recursiv fiecare jumătate și apoi îmbină jumătățile sortate. Are o complexitate de timp de O(n log n) și este stabil.";
            richTextBox2.Text = explanation;
        }
    }
}
