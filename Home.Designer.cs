namespace AlgoSimLearning
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">bool</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.Study = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.Study);
            this.panel1.Location = new System.Drawing.Point(315, 385);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 131);
            this.panel1.TabIndex = 1;
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.About.BackColor = System.Drawing.Color.DarkOrange;
            this.About.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.About.FlatAppearance.BorderSize = 2;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(407, 38);
            this.About.Margin = new System.Windows.Forms.Padding(2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(194, 53);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Study
            // 
            this.Study.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Study.BackColor = System.Drawing.Color.DarkOrange;
            this.Study.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Study.FlatAppearance.BorderSize = 2;
            this.Study.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Study.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Study.ForeColor = System.Drawing.Color.White;
            this.Study.Location = new System.Drawing.Point(42, 38);
            this.Study.Margin = new System.Windows.Forms.Padding(2);
            this.Study.Name = "Study";
            this.Study.Size = new System.Drawing.Size(194, 53);
            this.Study.TabIndex = 0;
            this.Study.Text = "Study";
            this.Study.UseVisualStyleBackColor = false;
            this.Study.Click += new System.EventHandler(this.Study_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlgoSimLearning.Properties.Resources.background_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Study;
    }
}
