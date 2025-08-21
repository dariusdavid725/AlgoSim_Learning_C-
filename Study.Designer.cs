namespace AlgoSimLearning
{
    partial class Study
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.Sorting = new System.Windows.Forms.Panel();
            this.Practica_MergeSort = new System.Windows.Forms.Button();
            this.Teorie_MergeSort = new System.Windows.Forms.Button();
            this.Practica_QuickSort = new System.Windows.Forms.Button();
            this.Teorie_QuickSort = new System.Windows.Forms.Button();
            this.Practica_BubbleSort = new System.Windows.Forms.Button();
            this.Teorie_BubbleSort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.Panel();
            this.Practica_Dijkstra = new System.Windows.Forms.Button();
            this.Teorie_Dijkstra = new System.Windows.Forms.Button();
            this.Teorie_Kruskal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Sorting.SuspendLayout();
            this.Graph.SuspendLayout();
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
            this.Back.Location = new System.Drawing.Point(15, 8);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 35);
            this.Back.TabIndex = 0;
            this.Back.Text = "Inapoi";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sorting
            // 
            this.Sorting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sorting.BackColor = System.Drawing.Color.Transparent;
            this.Sorting.Controls.Add(this.Practica_MergeSort);
            this.Sorting.Controls.Add(this.Teorie_MergeSort);
            this.Sorting.Controls.Add(this.Practica_QuickSort);
            this.Sorting.Controls.Add(this.Teorie_QuickSort);
            this.Sorting.Controls.Add(this.Practica_BubbleSort);
            this.Sorting.Controls.Add(this.Teorie_BubbleSort);
            this.Sorting.Controls.Add(this.label5);
            this.Sorting.Controls.Add(this.label4);
            this.Sorting.Controls.Add(this.label3);
            this.Sorting.Controls.Add(this.label1);
            this.Sorting.Location = new System.Drawing.Point(43, 100);
            this.Sorting.Margin = new System.Windows.Forms.Padding(2);
            this.Sorting.Name = "Sorting";
            this.Sorting.Size = new System.Drawing.Size(500, 487);
            this.Sorting.TabIndex = 1;
            // 
            // Practica_MergeSort
            // 
            this.Practica_MergeSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Practica_MergeSort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Practica_MergeSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Practica_MergeSort.FlatAppearance.BorderSize = 2;
            this.Practica_MergeSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Practica_MergeSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Practica_MergeSort.ForeColor = System.Drawing.Color.White;
            this.Practica_MergeSort.Location = new System.Drawing.Point(201, 404);
            this.Practica_MergeSort.Margin = new System.Windows.Forms.Padding(2);
            this.Practica_MergeSort.Name = "Practica_MergeSort";
            this.Practica_MergeSort.Size = new System.Drawing.Size(106, 35);
            this.Practica_MergeSort.TabIndex = 9;
            this.Practica_MergeSort.Text = "Practica";
            this.Practica_MergeSort.UseVisualStyleBackColor = false;
            this.Practica_MergeSort.Click += new System.EventHandler(this.Practica_MergeSort_Click);
            // 
            // Teorie_MergeSort
            // 
            this.Teorie_MergeSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teorie_MergeSort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Teorie_MergeSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Teorie_MergeSort.FlatAppearance.BorderSize = 2;
            this.Teorie_MergeSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teorie_MergeSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Teorie_MergeSort.ForeColor = System.Drawing.Color.White;
            this.Teorie_MergeSort.Location = new System.Drawing.Point(55, 404);
            this.Teorie_MergeSort.Margin = new System.Windows.Forms.Padding(2);
            this.Teorie_MergeSort.Name = "Teorie_MergeSort";
            this.Teorie_MergeSort.Size = new System.Drawing.Size(106, 35);
            this.Teorie_MergeSort.TabIndex = 8;
            this.Teorie_MergeSort.Text = "Teorie";
            this.Teorie_MergeSort.UseVisualStyleBackColor = false;
            this.Teorie_MergeSort.Click += new System.EventHandler(this.Teorie_MergeSort_Click);
            // 
            // Practica_QuickSort
            // 
            this.Practica_QuickSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Practica_QuickSort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Practica_QuickSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Practica_QuickSort.FlatAppearance.BorderSize = 2;
            this.Practica_QuickSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Practica_QuickSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Practica_QuickSort.ForeColor = System.Drawing.Color.White;
            this.Practica_QuickSort.Location = new System.Drawing.Point(201, 297);
            this.Practica_QuickSort.Margin = new System.Windows.Forms.Padding(2);
            this.Practica_QuickSort.Name = "Practica_QuickSort";
            this.Practica_QuickSort.Size = new System.Drawing.Size(106, 35);
            this.Practica_QuickSort.TabIndex = 7;
            this.Practica_QuickSort.Text = "Practica";
            this.Practica_QuickSort.UseVisualStyleBackColor = false;
            this.Practica_QuickSort.Click += new System.EventHandler(this.Practica_QuickSort_Click);
            // 
            // Teorie_QuickSort
            // 
            this.Teorie_QuickSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teorie_QuickSort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Teorie_QuickSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Teorie_QuickSort.FlatAppearance.BorderSize = 2;
            this.Teorie_QuickSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teorie_QuickSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Teorie_QuickSort.ForeColor = System.Drawing.Color.White;
            this.Teorie_QuickSort.Location = new System.Drawing.Point(55, 297);
            this.Teorie_QuickSort.Margin = new System.Windows.Forms.Padding(2);
            this.Teorie_QuickSort.Name = "Teorie_QuickSort";
            this.Teorie_QuickSort.Size = new System.Drawing.Size(106, 35);
            this.Teorie_QuickSort.TabIndex = 6;
            this.Teorie_QuickSort.Text = "Teorie";
            this.Teorie_QuickSort.UseVisualStyleBackColor = false;
            this.Teorie_QuickSort.Click += new System.EventHandler(this.Teorie_QuickSort_Click);
            // 
            // Practica_BubbleSort
            // 
            this.Practica_BubbleSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Practica_BubbleSort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Practica_BubbleSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Practica_BubbleSort.FlatAppearance.BorderSize = 2;
            this.Practica_BubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Practica_BubbleSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Practica_BubbleSort.ForeColor = System.Drawing.Color.White;
            this.Practica_BubbleSort.Location = new System.Drawing.Point(201, 176);
            this.Practica_BubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.Practica_BubbleSort.Name = "Practica_BubbleSort";
            this.Practica_BubbleSort.Size = new System.Drawing.Size(106, 35);
            this.Practica_BubbleSort.TabIndex = 5;
            this.Practica_BubbleSort.Text = "Practica";
            this.Practica_BubbleSort.UseVisualStyleBackColor = false;
            this.Practica_BubbleSort.Click += new System.EventHandler(this.Practica_BubbleSort_Click);
            // 
            // Teorie_BubbleSort
            // 
            this.Teorie_BubbleSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teorie_BubbleSort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Teorie_BubbleSort.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Teorie_BubbleSort.FlatAppearance.BorderSize = 2;
            this.Teorie_BubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teorie_BubbleSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Teorie_BubbleSort.ForeColor = System.Drawing.Color.White;
            this.Teorie_BubbleSort.Location = new System.Drawing.Point(55, 176);
            this.Teorie_BubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.Teorie_BubbleSort.Name = "Teorie_BubbleSort";
            this.Teorie_BubbleSort.Size = new System.Drawing.Size(106, 35);
            this.Teorie_BubbleSort.TabIndex = 4;
            this.Teorie_BubbleSort.Text = "Teorie";
            this.Teorie_BubbleSort.UseVisualStyleBackColor = false;
            this.Teorie_BubbleSort.Click += new System.EventHandler(this.Teorie_BubbleSort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Algoritmul MergeSort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Algoritmul QuickSort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Algoritmul BubbleSort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritmi de Sortare";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Graph
            // 
            this.Graph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Graph.BackColor = System.Drawing.Color.Transparent;
            this.Graph.Controls.Add(this.button1);
            this.Graph.Controls.Add(this.Practica_Dijkstra);
            this.Graph.Controls.Add(this.Teorie_Dijkstra);
            this.Graph.Controls.Add(this.Teorie_Kruskal);
            this.Graph.Controls.Add(this.label6);
            this.Graph.Controls.Add(this.label7);
            this.Graph.Controls.Add(this.label2);
            this.Graph.Location = new System.Drawing.Point(722, 100);
            this.Graph.Margin = new System.Windows.Forms.Padding(2);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(500, 487);
            this.Graph.TabIndex = 2;
            // 
            // Practica_Dijkstra
            // 
            this.Practica_Dijkstra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Practica_Dijkstra.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Practica_Dijkstra.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Practica_Dijkstra.FlatAppearance.BorderSize = 2;
            this.Practica_Dijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Practica_Dijkstra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Practica_Dijkstra.ForeColor = System.Drawing.Color.White;
            this.Practica_Dijkstra.Location = new System.Drawing.Point(201, 176);
            this.Practica_Dijkstra.Margin = new System.Windows.Forms.Padding(2);
            this.Practica_Dijkstra.Name = "Practica_Dijkstra";
            this.Practica_Dijkstra.Size = new System.Drawing.Size(106, 35);
            this.Practica_Dijkstra.TabIndex = 11;
            this.Practica_Dijkstra.Text = "Practica";
            this.Practica_Dijkstra.UseVisualStyleBackColor = false;
            this.Practica_Dijkstra.Click += new System.EventHandler(this.Practica_Dijkstra_Click);
            // 
            // Teorie_Dijkstra
            // 
            this.Teorie_Dijkstra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teorie_Dijkstra.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Teorie_Dijkstra.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Teorie_Dijkstra.FlatAppearance.BorderSize = 2;
            this.Teorie_Dijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teorie_Dijkstra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Teorie_Dijkstra.ForeColor = System.Drawing.Color.White;
            this.Teorie_Dijkstra.Location = new System.Drawing.Point(55, 176);
            this.Teorie_Dijkstra.Margin = new System.Windows.Forms.Padding(2);
            this.Teorie_Dijkstra.Name = "Teorie_Dijkstra";
            this.Teorie_Dijkstra.Size = new System.Drawing.Size(106, 35);
            this.Teorie_Dijkstra.TabIndex = 10;
            this.Teorie_Dijkstra.Text = "Teorie";
            this.Teorie_Dijkstra.UseVisualStyleBackColor = false;
            this.Teorie_Dijkstra.Click += new System.EventHandler(this.Teorie_Dijkstra_Click);
            // 
            // Teorie_Kruskal
            // 
            this.Teorie_Kruskal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teorie_Kruskal.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Teorie_Kruskal.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Teorie_Kruskal.FlatAppearance.BorderSize = 2;
            this.Teorie_Kruskal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teorie_Kruskal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Teorie_Kruskal.ForeColor = System.Drawing.Color.White;
            this.Teorie_Kruskal.Location = new System.Drawing.Point(55, 297);
            this.Teorie_Kruskal.Margin = new System.Windows.Forms.Padding(2);
            this.Teorie_Kruskal.Name = "Teorie_Kruskal";
            this.Teorie_Kruskal.Size = new System.Drawing.Size(106, 35);
            this.Teorie_Kruskal.TabIndex = 12;
            this.Teorie_Kruskal.Text = "Teorie";
            this.Teorie_Kruskal.UseVisualStyleBackColor = false;
            this.Teorie_Kruskal.Click += new System.EventHandler(this.Teorie_Kruskal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Algoritmul Kruskal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Algoritmul Dijkstra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Algoritmi pe Graf";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(201, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Practica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlgoSimLearning.Properties.Resources.background_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Sorting);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Study";
            this.Text = "Study";
            this.Load += new System.EventHandler(this.Study_Load);
            this.Sorting.ResumeLayout(false);
            this.Sorting.PerformLayout();
            this.Graph.ResumeLayout(false);
            this.Graph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel Sorting;
        private System.Windows.Forms.Panel Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Practica_MergeSort;
        private System.Windows.Forms.Button Teorie_MergeSort;
        private System.Windows.Forms.Button Practica_QuickSort;
        private System.Windows.Forms.Button Teorie_QuickSort;
        private System.Windows.Forms.Button Practica_BubbleSort;
        private System.Windows.Forms.Button Teorie_BubbleSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Practica_Dijkstra;
        private System.Windows.Forms.Button Teorie_Dijkstra;
        private System.Windows.Forms.Button Teorie_Kruskal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}
