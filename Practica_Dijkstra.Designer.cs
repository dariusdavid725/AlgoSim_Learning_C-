using System.Drawing;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    partial class Practica_Dijkstra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelExampleInput = new System.Windows.Forms.Label();
            this.labelExampleOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.back.FlatAppearance.BorderSize = 2;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(78, 27);
            this.back.TabIndex = 0;
            this.back.Text = "Înapoi";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxCode.Location = new System.Drawing.Point(12, 335);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(1257, 266);
            this.textBoxCode.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.buttonSubmit.FlatAppearance.BorderSize = 2;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 607);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(90, 30);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOutput.BackColor = System.Drawing.Color.White;
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxOutput.ForeColor = System.Drawing.Color.Black;
            this.textBoxOutput.Location = new System.Drawing.Point(108, 607);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(1161, 56);
            this.textBoxOutput.TabIndex = 3;
            // 
            // labelInput
            // 
            this.labelInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.Transparent;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelInput.ForeColor = System.Drawing.Color.White;
            this.labelInput.Location = new System.Drawing.Point(12, 240);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(143, 20);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "Încărcare soluție";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(76, 24);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Cerința";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1257, 58);
            this.textBox1.TabIndex = 10;
            // 
            // labelExampleInput
            // 
            this.labelExampleInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelExampleInput.AutoSize = true;
            this.labelExampleInput.BackColor = System.Drawing.Color.Transparent;
            this.labelExampleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelExampleInput.ForeColor = System.Drawing.Color.White;
            this.labelExampleInput.Location = new System.Drawing.Point(12, 160);
            this.labelExampleInput.Name = "labelExampleInput";
            this.labelExampleInput.Size = new System.Drawing.Size(135, 160);
            this.labelExampleInput.TabIndex = 11;
            this.labelExampleInput.Text = "Date de intrare:\n5 4\n1 3 1\n2 1 2\n4 2 1\n4 3 8\n5 3 5\n5 4 2";
            // 
            // labelExampleOutput
            // 
            this.labelExampleOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelExampleOutput.AutoSize = true;
            this.labelExampleOutput.BackColor = System.Drawing.Color.Transparent;
            this.labelExampleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelExampleOutput.ForeColor = System.Drawing.Color.White;
            this.labelExampleOutput.Location = new System.Drawing.Point(12, 300);
            this.labelExampleOutput.Name = "labelExampleOutput";
            this.labelExampleOutput.Size = new System.Drawing.Size(207, 20);
            this.labelExampleOutput.TabIndex = 12;
            this.labelExampleOutput.Text = "Date de iesire: 3 1 4 0 -1";
            // 
            // Practica_Dijkstra
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 705);
            this.Controls.Add(this.labelExampleOutput);
            this.Controls.Add(this.labelExampleInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.back);
            this.Name = "Practica_Dijkstra";
            this.Text = "Practica_Dijkstra";
            this.Load += new System.EventHandler(this.Practica_Dijkstra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelExampleInput;
        private System.Windows.Forms.Label labelExampleOutput;
    }
}
