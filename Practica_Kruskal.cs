using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Practica_Kruskal : Form
    {
        public Practica_Kruskal()
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

        private void Practica_Kruskal_Load(object sender, EventArgs e)
        {

            string cerinta = @"Se dă un graf neorientat ponderat conex cu n vârfuri și m muchii – în care fiecare muchie are asociat un cost, număr natural strict pozitiv. Folosind algoritmul lui Kruskal, determinați un arbore parțial de cost minim.
se va afisa  pe prima linie costul arborelui de cost minim determinat, iar pe următoarele n-1 linii câte o pereche de numere i j, cu semnificația că muchia (i j) aparține arborelui parțial de cost minim determinat.";
            textBox1.Text = cerinta;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 14);
        }

        private void back_Click(object sender, EventArgs e)
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string userCode = textBoxCode.Text;
            string userInput = "7 11\r\n1 2 2\r\n1 7 4\r\n2 3 3\r\n2 5 2\r\n2 6 3\r\n2 7 3\r\n3 4 1\r\n3 5 2\r\n4 5 1\r\n5 6 3\r\n6 7 5";

           
            string tempDirectory = Path.GetTempPath();
            string cppFilePath = Path.Combine(tempDirectory, Guid.NewGuid().ToString() + ".cpp");
            string exeFilePath = Path.Combine(tempDirectory, Guid.NewGuid().ToString() + ".exe");

           
            File.WriteAllText(cppFilePath, userCode);

            
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "g++"; 
            compileProcess.StartInfo.Arguments = $"-o \"{exeFilePath}\" \"{cppFilePath}\"";
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.CreateNoWindow = true;

            try
            {
                compileProcess.Start();
                string output = compileProcess.StandardOutput.ReadToEnd();
                string error = compileProcess.StandardError.ReadToEnd();
                compileProcess.WaitForExit();

                if (compileProcess.ExitCode == 0)
                {
                  
                    Process runProcess = new Process();
                    runProcess.StartInfo.FileName = exeFilePath;
                    runProcess.StartInfo.RedirectStandardOutput = true;
                    runProcess.StartInfo.RedirectStandardInput = true; 
                    runProcess.StartInfo.UseShellExecute = false;
                    runProcess.StartInfo.CreateNoWindow = true;

                    runProcess.Start();
                    using (StreamWriter writer = runProcess.StandardInput)
                    {
                        writer.WriteLine(userInput);
                    }
                    string runOutput = runProcess.StandardOutput.ReadToEnd();
                    runProcess.WaitForExit();

                    
                    string expectedOutput = "12\r\n3 4\r\n4 5\r\n1 2\r\n2 5\r\n2 6\r\n2 7";

                    if (runOutput.Trim() == expectedOutput.Trim())
                    {
                        textBoxOutput.Text = "Răspuns corect";
                        textBoxOutput.BackColor = Color.Green;
                        textBoxOutput.ForeColor = Color.White;
                        textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, 16);
                        textBoxOutput.TextAlign = HorizontalAlignment.Center;
                    }
                    else
                    {
                        textBoxOutput.Text = "Răspuns greșit";
                        textBoxOutput.BackColor = Color.Red;
                        textBoxOutput.ForeColor = Color.White;
                        textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, 16);
                        textBoxOutput.TextAlign = HorizontalAlignment.Center;
                    }

                   
                    runProcess.Close();
                }
                else
                {
                    
                    textBoxOutput.Text = "Eroare de compilare";
                    textBoxOutput.BackColor = Color.Red;
                    textBoxOutput.ForeColor = Color.White;
                    textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, 16);
                    textBoxOutput.TextAlign = HorizontalAlignment.Center;
                }
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = $"Exception: {ex.Message}";
                textBoxOutput.BackColor = Color.Red;
                textBoxOutput.ForeColor = Color.White;
                textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, 16);
                textBoxOutput.TextAlign = HorizontalAlignment.Center;
            }
            finally
            {
                
                if (File.Exists(cppFilePath))
                {
                    File.Delete(cppFilePath);
                }

                if (File.Exists(exeFilePath))
                {
                    try
                    {
                        File.Delete(exeFilePath);
                    }
                    catch (Exception ex)
                    {
                        textBoxOutput.Text += $"\nError deleting executable: {ex.Message}";
                        textBoxOutput.BackColor = Color.Red;
                        textBoxOutput.ForeColor = Color.White;
                        textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, 16);
                        textBoxOutput.TextAlign = HorizontalAlignment.Center;
                    }
                }
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
