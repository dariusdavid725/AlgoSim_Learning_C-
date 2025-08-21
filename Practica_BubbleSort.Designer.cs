namespace AlgoSimLearning
{
    partial class Practica_BubbleSort
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
            this.backButton = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxRequirement = new System.Windows.Forms.TextBox();
            this.labelInputInstructions = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(9, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Înapoi";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.back_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCode.BackColor = System.Drawing.Color.Pink;
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBoxCode.Location = new System.Drawing.Point(124, 178);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(886, 276);
            this.textBoxCode.TabIndex = 1;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.buttonSubmit.FlatAppearance.BorderSize = 2;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(124, 551);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 28);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOutput.BackColor = System.Drawing.Color.Pink;
            this.textBoxOutput.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.textBoxOutput.ForeColor = System.Drawing.Color.Black;
            this.textBoxOutput.Location = new System.Drawing.Point(124, 583);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(751, 66);
            this.textBoxOutput.TabIndex = 3;
            // 
            // labelSolution
            // 
            this.labelSolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSolution.AutoSize = true;
            this.labelSolution.BackColor = System.Drawing.Color.Transparent;
            this.labelSolution.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelSolution.ForeColor = System.Drawing.Color.White;
            this.labelSolution.Location = new System.Drawing.Point(121, 157);
            this.labelSolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(81, 22);
            this.labelSolution.TabIndex = 5;
            this.labelSolution.Text = "Soluție:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(121, 48);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 29);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Cerința";
            // 
            // textBoxRequirement
            // 
            this.textBoxRequirement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRequirement.BackColor = System.Drawing.Color.Pink;
            this.textBoxRequirement.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.textBoxRequirement.ForeColor = System.Drawing.Color.Black;
            this.textBoxRequirement.Location = new System.Drawing.Point(124, 74);
            this.textBoxRequirement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRequirement.Multiline = true;
            this.textBoxRequirement.Name = "textBoxRequirement";
            this.textBoxRequirement.ReadOnly = true;
            this.textBoxRequirement.Size = new System.Drawing.Size(886, 82);
            this.textBoxRequirement.TabIndex = 10;
            // 
            // labelInputInstructions
            // 
            this.labelInputInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInputInstructions.AutoSize = true;
            this.labelInputInstructions.BackColor = System.Drawing.Color.Transparent;
            this.labelInputInstructions.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelInputInstructions.ForeColor = System.Drawing.Color.White;
            this.labelInputInstructions.Location = new System.Drawing.Point(121, 469);
            this.labelInputInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInputInstructions.Name = "labelInputInstructions";
            this.labelInputInstructions.Size = new System.Drawing.Size(272, 22);
            this.labelInputInstructions.TabIndex = 5;
            this.labelInputInstructions.Text = "Introduceți datele de intrare:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxInput.BackColor = System.Drawing.Color.Pink;
            this.textBoxInput.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.textBoxInput.Location = new System.Drawing.Point(124, 493);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Size = new System.Drawing.Size(751, 50);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.Text = "7 7 6 5 4 3 2 1";
            // 
            // Practica_BubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlgoSimLearning.Properties.Resources.background_gradient;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.textBoxRequirement);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.labelInputInstructions);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Practica_BubbleSort";
            this.Text = "Practica Bubble Sort";
            this.Load += new System.EventHandler(this.Practica_BubbleSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRequirement;
        private System.Windows.Forms.Label labelInputInstructions;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}
