using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Practica_Dijkstra : Form
    {
        public Practica_Dijkstra()
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

        private void Practica_Dijkstra_Load(object sender, EventArgs e)
        {
            
            string cerinta = @"Se dă un graf orientat ponderat cu n noduri – în care fiecare arc are asociat un cost, număr natural strict pozitiv, și un nod p. Să se determine, folosind algoritmul lui Dijkstra, costul minim al drumului de la p la fiecare nod al grafului.";
            textBox1.Text = cerinta;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 14); // Adjust font size here
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
            string userInput = "5 4\n1 3 1\n2 1 2\n4 2 1\n4 3 8\n5 3 5\n5 4 2";

            // Paths for temporary files
            string tempDirectory = Path.GetTempPath();
            string cppFilePath = Path.Combine(tempDirectory, Guid.NewGuid().ToString() + ".cpp");
            string exeFilePath = Path.Combine(tempDirectory, Guid.NewGuid().ToString() + ".exe");

            // Write the user's code to the temporary .cpp file
            File.WriteAllText(cppFilePath, userCode);

            // Set up the compilation process
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "g++"; // Ensure g++ is in the PATH
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
                    // Compilation succeeded, run the program
                    Process runProcess = new Process();
                    runProcess.StartInfo.FileName = exeFilePath;
                    runProcess.StartInfo.RedirectStandardOutput = true;
                    runProcess.StartInfo.RedirectStandardInput = true; // Redirect stdin
                    runProcess.StartInfo.UseShellExecute = false;
                    runProcess.StartInfo.CreateNoWindow = true;

                    runProcess.Start();
                    using (StreamWriter writer = runProcess.StandardInput)
                    {
                        writer.WriteLine(userInput); // Send input to the program
                    }
                    string runOutput = runProcess.StandardOutput.ReadToEnd();
                    runProcess.WaitForExit();

                    // Compare with expected output
                    string expectedOutput = "3 1 4 0 -1";

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

                    // Ensure the process is closed before deleting the file
                    runProcess.Close();
                }
                else
                {
                    // Display compilation errors
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
                // Delete temporary files
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
            // Optional: Add any logic you want to execute when the labelTitle is clicked
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This method is no longer needed, you can remove its contents.
        }
    }
}
