using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Home : Form
    {
        private Stack<Form> forms = new Stack<Form>();

        public Home()
        {
            InitializeComponent();
            SetBackgroundImage();
        }

        private void SetBackgroundImage()
        {
            this.BackgroundImage = Properties.Resources.background_gradient; // Set to the gradient background
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void Navigate(Form newForm)
        {
            this.Hide();
            forms.Push(this);
            newForm.ShowDialog();
        }

        private void Study_Click(object sender, EventArgs e)
        {
            Navigate(new Study());
        }

        private void About_Click(object sender, EventArgs e)
        {
            Navigate(new About());
            Navigate
        }
    }
}
