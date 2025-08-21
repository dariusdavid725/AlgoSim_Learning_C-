namespace AlgoSimLearning
{
	partial class Teorie_Dijkstra
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
			this.Back = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Reset = new System.Windows.Forms.Button();
			this.Run = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.richTextBoxTheory = new System.Windows.Forms.RichTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.Back.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
			this.Back.FlatAppearance.BorderSize = 2;
			this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Back.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.Back.ForeColor = System.Drawing.Color.White;
			this.Back.Location = new System.Drawing.Point(22, 23);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(98, 37);
			this.Back.TabIndex = 1;
			this.Back.Text = "Inapoi";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Location = new System.Drawing.Point(54, 39);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(585, 600);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Reset
			// 
			this.Reset.BackColor = System.Drawing.Color.DarkOrange;
			this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
			this.Reset.FlatAppearance.BorderSize = 2;
			this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Reset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.Reset.ForeColor = System.Drawing.Color.White;
			this.Reset.Location = new System.Drawing.Point(410, 667);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(190, 42);
			this.Reset.TabIndex = 3;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = false;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Run
			// 
			this.Run.BackColor = System.Drawing.Color.DarkOrange;
			this.Run.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
			this.Run.FlatAppearance.BorderSize = 2;
			this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Run.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.Run.ForeColor = System.Drawing.Color.White;
			this.Run.Location = new System.Drawing.Point(88, 667);
			this.Run.Name = "Run";
			this.Run.Size = new System.Drawing.Size(190, 42);
			this.Run.TabIndex = 4;
			this.Run.Text = "Start";
			this.Run.UseVisualStyleBackColor = false;
			this.Run.Click += new System.EventHandler(this.Run_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.Run);
			this.panel1.Controls.Add(this.Reset);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(1200, 160);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 780);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.richTextBoxTheory);
			this.panel2.Location = new System.Drawing.Point(635, 160);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(522, 780);
			this.panel2.TabIndex = 6;
			// 
			// richTextBoxTheory
			// 
			this.richTextBoxTheory.BackColor = System.Drawing.Color.Pink;
			this.richTextBoxTheory.Font = new System.Drawing.Font("Maiandra GD", 14F);
			this.richTextBoxTheory.Location = new System.Drawing.Point(4, 0);
			this.richTextBoxTheory.Name = "richTextBoxTheory";
			this.richTextBoxTheory.ReadOnly = true;
			this.richTextBoxTheory.Size = new System.Drawing.Size(517, 776);
			this.richTextBoxTheory.TabIndex = 0;
			this.richTextBoxTheory.Text = "";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.richTextBox1);
			this.panel3.Location = new System.Drawing.Point(22, 160);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(562, 780);
			this.panel3.TabIndex = 7;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Pink;
			this.richTextBox1.Font = new System.Drawing.Font("Maiandra GD", 14F);
			this.richTextBox1.Location = new System.Drawing.Point(4, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(555, 774);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// Teorie_Dijkstra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1898, 1024);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Back);
			this.Name = "Teorie_Dijkstra";
			this.Text = "Teorie_Dijkstra";
			this.Load += new System.EventHandler(this.Teorie_Dijkstra_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button Run;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBoxTheory;
	}
}