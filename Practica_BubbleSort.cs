using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Practica_BubbleSort : Form
    {
        public Practica_BubbleSort()
        {
            InitializeComponent();
            SetBackgroundImage();
        }

        private void SetBackgroundImage()
        {
            string backgroundImagePath = @"C:\Users\dariu\OneDrive\Desktop\SimAlgo Learning\AlgoSimLearning-20240520T061145Z-001\AlgoSimLearning\Resources\background.gradient.jpg";
            if (File.Exists(backgroundImagePath))
            {
                this.BackgroundImage = Image.FromFile(backgroundImagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.DoubleBuffered = true;
            }
            else
            {
                MessageBox.Show("Background image not found!");
            }
        }

        private void Practica_BubbleSort_Load(object sender, EventArgs e)
        {
            // Set the requirement text on form load
            string cerinta = @"Se dă o secvență de n numere întregi. Să se sorteze crescător folosind algoritmul învățat.";
            textBoxRequirement.Text = cerinta;
            textBoxRequirement.Font = new Font(textBoxRequirement.Font.FontFamily, 14); // Adjust font size here
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
            string userInput = textBoxInput.Text;

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
                    string expectedOutput = "1 2 3 4 5 6 7"; // Example expected output

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
                    textBoxOutput.Text = $"Eroare de compilare:\n{error}";
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
                    }
                }
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            // Optional: Add any logic you want to execute when the labelTitle is clicked
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
