using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlgoSimLearning
{
	public partial class Teorie_Dijkstra : Form
	{
		private const int CellSize = 25;
		private const int Row = 14;
		private const int Column = 14;
		private const int Row1 = Row + 1;
		private const int Column1 = Column + 1;

		private bool[,] obstacle = new bool[Row1, Column1];
		private Point lastMousePosition;
		private Point start = Point.Empty;
		private Point end = Point.Empty;
		private List<Point> path = new List<Point>();
		private List<Point> visitedNodes = new List<Point>();
		private List<Point> finalPath = new List<Point>();
		private Timer timer;
		private int pathIndex = 0;

		public Teorie_Dijkstra()
		{
			InitializeComponent();
			SetBackgroundImage();
			InitializeObstacle();
			pictureBox1.Paint += PictureBox1_Paint;
			pictureBox1.MouseDown += PictureBox1_MouseDown;
			pictureBox1.MouseMove += PictureBox1_MouseMove;
			InitializeTimer();
			DisplayCodeAndTheory();
			SetTheoryTextProperties();
		}

		private void SetBackgroundImage()
		{
			string backgroundImagePath = @"C:\Users\dariu\OneDrive\Desktop\SimAlgo Learning\AlgoSimLearning-20240520T061145Z-001\AlgoSimLearning\Resources\background.gradient.jpg";
			if (System.IO.File.Exists(backgroundImagePath))
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

		private void InitializeObstacle()
		{
			obstacle[0, 0] = true;
			for (int i = 1; i < Row; ++i)
			{
				obstacle[i, 0] = true;
				obstacle[i, Column - 1] = true;
				for (int j = 1; j < Column; ++j)
				{
					obstacle[0, j] = true;
					obstacle[Row - 1, j] = true;
					obstacle[i, j] = false;
				}
			}
		}

		private void InitializeTimer()
		{
			timer = new Timer();
			timer.Interval = 50;
			timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (pathIndex < visitedNodes.Count)
			{
				pictureBox1.Invalidate();
				pathIndex++;
			}
			else
			{
				timer.Stop();
				pathIndex = 0;
			}
		}

		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			int row = e.Y / CellSize;
			int col = e.X / CellSize;

			if (e.Button == MouseButtons.Left && start == Point.Empty)
			{
				start = new Point(col, row);
			}
			else if (e.Button == MouseButtons.Left && end == Point.Empty)
			{
				end = new Point(col, row);
			}
			else if (e.Button == MouseButtons.Left)
			{
				if (!obstacle[row, col] && start != new Point(col, row) && end != new Point(col, row))
					obstacle[row, col] = true;
			}

			lastMousePosition = new Point(col, row);
			pictureBox1.Invalidate();
		}

		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && start != Point.Empty && end != Point.Empty)
			{
				int row = e.Y / CellSize;
				int col = e.X / CellSize;
				if (row >= 0 && row < Row && col >= 0 && col < Column && lastMousePosition != new Point(col, row) && start != new Point(col, row) && end != new Point(col, row))
				{
					obstacle[row, col] = true;
					lastMousePosition = new Point(col, row);
					pictureBox1.Invalidate();
				}
			}
		}

		private void PictureBox1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			for (int i = 0; i < Row; ++i)
			{
				for (int j = 0; j < Column; ++j)
				{
					if (obstacle[i, j])
					{
						g.FillRectangle(Brushes.Black, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					else if (start != Point.Empty && start.X == j && start.Y == i)
					{
						g.FillRectangle(Brushes.Green, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					else if (end != Point.Empty && end.X == j && end.Y == i)
					{
						g.FillRectangle(Brushes.Red, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					else if (pathIndex > 0 && path.Contains(new Point(j, i)))
					{
						g.FillRectangle(Brushes.Purple, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					else if (finalPath.Contains(new Point(j, i)))
					{
						g.FillRectangle(Brushes.Yellow, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					else if (visitedNodes.Contains(new Point(j, i)))
					{
						g.FillRectangle(Brushes.MediumPurple, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					else
					{
						g.FillRectangle(Brushes.White, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
					}
					g.DrawRectangle(Pens.Black, new Rectangle(j * CellSize, i * CellSize, CellSize, CellSize));
				}
			}
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			start = Point.Empty;
			end = Point.Empty;
			path = new List<Point>();
			visitedNodes = new List<Point>();
			finalPath = new List<Point>();
			InitializeObstacle();
			pictureBox1.Invalidate();
		}

		private void Run_Click(object sender, EventArgs e)
		{
			if (start == Point.Empty || end == Point.Empty)
			{
				MessageBox.Show("Please set start and end points.");
				return;
			}
			visitedNodes = new List<Point>();
			var paths = FindShortestPath(obstacle, start, end);
			path = paths.Item1;
			finalPath = paths.Item2;
			timer.Start();
		}

		private const int Infinity = int.MaxValue;

		private static readonly int[,] DIRECTIONS = { { 0, -1 }, { -1, 0 }, { 0, 1 }, { 1, 0 } };

		public Tuple<List<Point>, List<Point>> FindShortestPath(bool[,] obstacle, Point start, Point end)
		{
			int[,] distance = new int[Row, Column];
			Point[,] previous = new Point[Row, Column];
			HashSet<Point> visited = new HashSet<Point>();
			List<Point> visitedNodesTemp = new List<Point>();
			List<Point> finalPathTemp = new List<Point>();

			for (int i = 0; i < Row; ++i)
			{
				for (int j = 0; j < Column; ++j)
				{
					distance[i, j] = Infinity;
				}
			}

			distance[start.Y, start.X] = 0;

			while (true)
			{
				Point current = GetClosestPoint(distance, visited);

				if (current == Point.Empty)
				{
					break;
				}

				visited.Add(current);
				visitedNodesTemp.Add(current);

				if (current == end)
				{
					finalPathTemp = ReconstructFinalPath(start, end, previous);
					break;
				}

				for (int d = 0; d < DIRECTIONS.GetLength(0); d++)
				{
					int nextRow = current.Y + DIRECTIONS[d, 0];
					int nextCol = current.X + DIRECTIONS[d, 1];

					if (IsValidPosition(nextRow, nextCol) && !visited.Contains(new Point(nextCol, nextRow)) && !obstacle[nextRow, nextCol])
					{
						int newDistance = distance[current.Y, current.X] + 1;
						if (newDistance < distance[nextRow, nextCol])
						{
							distance[nextRow, nextCol] = newDistance;
							previous[nextRow, nextCol] = current;
						}
					}
				}
			}

			visitedNodes = visitedNodesTemp;
			return Tuple.Create(path, finalPathTemp);
		}

		private static Point GetClosestPoint(int[,] distance, HashSet<Point> visited)
		{
			int minDistance = Infinity;
			Point closestPoint = Point.Empty;

			for (int i = 0; i < Row; ++i)
			{
				for (int j = 0; j < Column; ++j)
				{
					Point point = new Point(j, i);
					if (!visited.Contains(point) && distance[i, j] < minDistance)
					{
						minDistance = distance[i, j];
						closestPoint = point;
					}
				}
			}

			return closestPoint;
		}

		private static bool IsValidPosition(int row, int col)
		{
			return row >= 0 && row < Row && col >= 0 && col < Column;
		}

		private static List<Point> ReconstructFinalPath(Point start, Point end, Point[,] previous)
		{
			List<Point> path = new List<Point>();
			Point current = end;

			while (current != start)
			{
				path.Add(current);
				current = previous[current.Y, current.X];
			}

			path.Add(start);
			path.Reverse();
			return path;
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

		private void RunFinalPath_Click(object sender, EventArgs e)
		{
			pictureBox1.Invalidate();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void DisplayCodeAndTheory()
		{
			string theory = "Algoritmul Dijkstra este un algoritm de căutare a drumurilor cele mai scurte într-un graf ponderat, orientat sau neorientat, cu muchii non-negative. Algoritmul selectează repetat nodul cu cea mai mică distanță (cost) care nu a fost încă inclus în arborele de drumuri cele mai scurte și actualizează distanțele vecinilor săi în funcție de noua distanță a nodului selectat." +

				"Algoritmul funcționează după cum urmează:" +

				"Se initializează un vector de distanțe cu infinit pentru fiecare nod, cu excepția nodului de start, pentru care distanța este 0." +
				"Se selectează nodul cu cea mai mică distanță nevizitată și se actualizează distanțele vecinilor săi în funcție de distanța nodului selectat și costul muchiilor." +
				"Se marchează nodul selectat ca vizitat și se repetă pasul 2 până când toate nodurile sunt vizitate sau distanțele minime sunt stabilite pentru toate nodurile." +
				"Complexitatea:" +
				"Algoritmul Dijkstra are o complexitate de timp de O(V ^ 2) pentru implementarea sa clasică, unde V este numărul de noduri din graf.Cu o coadă de priorități,această complexitate poate fi redusă la O((V + E) log V), unde E este numărul de muchii. Acest algoritm este eficient pentru grafuri cu muchii neponderate sau grafuri rare." +
				"Utilizări:" +

			"Algoritmul Dijkstra este utilizat pentru a găsi cele mai scurte drumuri în rețele de comunicații, precum și în sistemele de navigare și planificare a rutelor." +
			"Este folosit în protocoale de rutare, cum ar fi OSPF (Open Shortest Path First) și IS-IS (Intermediate System to Intermediate System) pentru a determina cea mai scurtă rută între dispozitivele dintr-o rețea." +
			"Avantaje:" +

			"Algoritmul este simplu de înțeles și de implementat." +
			"Funcționează eficient pentru grafuri rare sau grafuri cu muchii neponderate." +
			"Dezavantaje:" +
			"Algoritmul Dijkstra nu funcționează corect pentru grafuri cu muchii negative, deoarece presupune că distanțele mai mici decât cele deja calculate sunt cele mai scurte distanțe.";

			string code = @"#include <bits/stdc++.h>
const int N=10001;
vector<vector<pair<int,int>>>G(N);
int n,m;
vector<int>dist(N,0);
void dijkstra(int start,int end)
{
priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>>>coada;
for(int i=1;i<=n;++i)
    dist[i]=INF;
coada.push({0,start});
dist[start]=0;
while(!coada.empty())
{
    int nod=coada.top().second;
    int distanta=coada.top().first;
    coada.pop();
    if(first==end)
    {
        cout<<distanta;
        return;
    }
    for(auto x:G[nod])
    {
        int fiu=x.first;
        int cost=x.second;
        if(distanta+cost<dist[fiu])
        {
            dist[fiu]=distanta+cost;
            coada.push({dist[fiu],fiu});
        }
    }
}
}
signed main() {
fin>>n>>m;
for(int i=1;i<=m;++i)
{
int x,y,c;
fin>>x>>y>>c;
G[x].pb({y,c});
G[y].pb({x,c});
}
int start,end;
fin>>start>>end;
dijkstra(start,end);
return 0;
}";
			richTextBoxTheory.Text = theory;
			richTextBox1.Text = code;
		}

		private void SetTheoryTextProperties()
		{
			richTextBoxTheory.ReadOnly = true;
			richTextBoxTheory.BackColor = Color.Pink;
			richTextBoxTheory.BorderStyle = BorderStyle.None;
			richTextBoxTheory.TabStop = false;
		}

		private void Teorie_Dijkstra_Load(object sender, EventArgs e)
		{

		}
	}
}