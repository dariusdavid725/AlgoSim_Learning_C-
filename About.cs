using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            SetBackgroundImage();
        }

        private void SetBackgroundImage()
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\dariu\OneDrive\Desktop\SimAlgo Learning\AlgoSimLearning-20240520T061145Z-001\AlgoSimLearning\Resources\background.gradient.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
        }

        private void About_Load(object sender, EventArgs e)
        {
            labelAbout.Text = "Despre noi:\r\n\r\n" +
                              "Suntem doi studenți pasionați de informatică și programare. " +
                              "Am dezvoltat această aplicație pentru a ajuta alți studenți să învețe " +
                              "și să înțeleagă mai bine algoritmii de sortare și pe grafuri. " +
                              "Sperăm să vă fie de folos!";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.Show();
            }
        }
    }
}
