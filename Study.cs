using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Study : Form
    {
        private Stack<Form> forms = new Stack<Form>();

        public Study()
        {
            InitializeComponent();
            SetBackgroundImage();
        }

        private void StudyForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void SetBackgroundImage()
        {
            this.BackgroundImage = Properties.Resources.background_gradient;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
        }

        private void Navigate(Form newForm)
        {
            this.Hide();
            forms.Push(this);
            newForm.ShowDialog();
        }

        private void Study_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Application.OpenForms.Count > 0)
            {
                Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
                if (homeForm != null)
                {
                    homeForm.Show();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Teorie_BubbleSort_Click(object sender, EventArgs e)
        {
            Navigate(new Teorie_BubbleSort());
        }

        private void Practica_BubbleSort_Click(object sender, EventArgs e)
        {
            Navigate(new Practica_BubbleSort());
        }

        private void Teorie_QuickSort_Click(object sender, EventArgs e)
        {
            Navigate(new Teorie_QuickSort());
        }

        private void Teorie_MergeSort_Click(object sender, EventArgs e)
        {
            Navigate(new Teorie_MergeSort());
        }


        private void Teorie_Dijkstra_Click(object sender, EventArgs e)
        {
            Navigate(new Teorie_Dijkstra());
        }

        private void Practica_Dijkstra_Click(object sender, EventArgs e)
        {
            Navigate(new Practica_Dijkstra());
        }

        private void Teorie_Kruskal_Click(object sender, EventArgs e)
        {
            Navigate(new Teorie_Kruskal());
        }

        private void Practica_QuickSort_Click(object sender, EventArgs e)
        {
            Navigate(new Practica_BubbleSort());
        }

        private void Practica_MergeSort_Click(object sender, EventArgs e)
        {
            Navigate(new Practica_BubbleSort());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Navigate(new Practica_Kruskal());
        }
    }
}