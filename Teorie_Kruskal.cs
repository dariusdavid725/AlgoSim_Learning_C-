using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
    public partial class Teorie_Kruskal : Form
    {
        private List<Point> nodes = new List<Point>();
        private List<Tuple<int, int>> edges = new List<Tuple<int, int>>();
        private List<int> costs = new List<int>();
        private List<Tuple<int, int>> mstEdges = new List<Tuple<int, int>>();
        private Point? firstSelectedNode = null;
        private Point? secondSelectedNode = null;

        public Teorie_Kruskal()
        {
            InitializeComponent();
            this.pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new MouseEventHandler(this.pictureBox1_MouseClick);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var edge in edges)
            {
                Point p1 = nodes[edge.Item1];
                Point p2 = nodes[edge.Item2];
                g.DrawLine(Pens.Black, p1, p2);
                int costIndex = edges.IndexOf(edge);
                int costX = (p1.X + p2.X) / 2;
                int costY = (p1.Y + p2.Y) / 2;
                g.DrawString(costs[costIndex].ToString(), this.Font, Brushes.Black, costX, costY);
            }

            foreach (var edge in mstEdges)
            {
                Point p1 = nodes[edge.Item1];
                Point p2 = nodes[edge.Item2];
                g.DrawLine(new Pen(Color.Red, 2), p1, p2);
            }

            foreach (var node in nodes)
            {
                g.FillEllipse(Brushes.White, node.X - 15, node.Y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, node.X - 15, node.Y - 15, 30, 30);
                g.DrawString((nodes.IndexOf(node) + 1).ToString(), this.Font, Brushes.Black, node.X - 5, node.Y - 5);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nodes.Add(e.Location);
                pictureBox1.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (firstSelectedNode == null)
                {
                    firstSelectedNode = e.Location;
                }
                else
                {
                    secondSelectedNode = e.Location;
                    int node1Index = FindNodeIndex(firstSelectedNode.Value);
                    int node2Index = FindNodeIndex(secondSelectedNode.Value);

                    if (node1Index != -1 && node2Index != -1 && node1Index != node2Index)
                    {
                        using (InputDialog inputDialog = new InputDialog())
                        {
                            if (inputDialog.ShowDialog() == DialogResult.OK)
                            {
                                edges.Add(new Tuple<int, int>(node1Index, node2Index));
                                costs.Add(inputDialog.Cost);
                            }
                        }
                    }

                    firstSelectedNode = null;
                    secondSelectedNode = null;
                    pictureBox1.Invalidate();
                }
            }
        }

        private int FindNodeIndex(Point location)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                double distance = Math.Sqrt(Math.Pow(nodes[i].X - location.X, 2) + Math.Pow(nodes[i].Y - location.Y, 2));
                if (distance <= 15)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Kruskal();
            pictureBox1.Invalidate();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            nodes.Clear();
            edges.Clear();
            costs.Clear();
            mstEdges.Clear();
            firstSelectedNode = null;
            secondSelectedNode = null;
            pictureBox1.Invalidate();
        }

        private void Kruskal()
        {
            mstEdges.Clear();
            List<Tuple<int, int, int>> sortedEdges = edges.Select((edge, index) => new Tuple<int, int, int>(costs[index], edge.Item1, edge.Item2))
                                                          .OrderBy(edge => edge.Item1)
                                                          .ToList();

            int[] parent = new int[nodes.Count];
            for (int i = 0; i < nodes.Count; i++)
                parent[i] = i;

            int Find(int i)
            {
                if (parent[i] == i)
                    return i;
                return parent[i] = Find(parent[i]);
            }

            void Union(int i, int j)
            {
                int rootI = Find(i);
                int rootJ = Find(j);
                parent[rootI] = rootJ;
            }

            foreach (var edge in sortedEdges)
            {
                int cost = edge.Item1;
                int u = edge.Item2;
                int v = edge.Item3;

                if (Find(u) != Find(v))
                {
                    mstEdges.Add(new Tuple<int, int>(u, v));
                    Union(u, v);
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
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

        private void Teorie_Kruskal_Load(object sender, EventArgs e)
        {

        }
    }
}
