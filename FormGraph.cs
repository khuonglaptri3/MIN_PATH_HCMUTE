using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MIN_PATH_HCMUTE
{
    public partial class FormGraph : Form
    {
        private Dictionary<string, Point> vertexPositions;
        private Graph graph;
        private List<string> shortestPath;
        private Bitmap graphBitmap;

        public FormGraph(Graph g)
        {
            InitializeComponent();
            this.graph = g;
            this.shortestPath = new List<string>();
            InitializeVertexPositions();
            graphBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = graphBitmap;
            DrawGraph();
        }

        private void InitializeVertexPositions()
        {
            vertexPositions = new Dictionary<string, Point>
            {
                // Khu vực A
                {"A", new Point(800, 10)},
                {"A1", new Point(630, 60)},
                {"A2", new Point(700, 60)},
                {"A3", new Point(770, 60)},
                {"A4", new Point(815, 160)},
                {"A5", new Point(890, 170)},
                {"A6", new Point(770, 170)},
                {"A7", new Point(650, 150)},
                {"A8", new Point(650, 210)},
                {"A9", new Point(610, 230)},
                {"A10", new Point(610, 130)},
                {"A11", new Point(480, 130)},
                
                // Khu vực B
                {"B", new Point(830, 90)},
                {"B1", new Point(570, 270)},
                {"B2", new Point(660, 310)},
                {"B3", new Point(620, 310)},
                {"B4", new Point(620, 350)},
                {"B5", new Point(700, 345)},
                {"B6", new Point(770, 345)},
                {"B7", new Point(770, 395)},
                {"B8", new Point(820, 345)},
                {"B9", new Point(910, 260)},
                
                // Khu vực C
                {"C", new Point(830, 130)},
                {"C1", new Point(910, 210)},
                {"C2", new Point(770, 240)},
                {"C3", new Point(820, 240)},
                {"C4", new Point(565, 350)},
                {"C5", new Point(625, 470)},
                {"C7", new Point(860, 460)},
                {"C8", new Point(910, 330)},
                {"C9", new Point(510, 565)},
                {"C10", new Point(510, 525)},
                {"C11", new Point(910, 390)},
                
                // Khu vực D
                {"D", new Point(890,130)},
                {"D1", new Point(510, 640)},
                {"D2", new Point(452, 650)},
                {"D3", new Point(400, 560)},
                {"D4", new Point(380, 650)},
                {"D5", new Point(310, 598)},
                {"D6", new Point(310, 650)},
                {"D7", new Point(310, 710)},
                {"D8", new Point(345, 715)},
                {"D9", new Point(830,50)},
                
                // Các địa điểm đặc biệt
                {"E", new Point(930, 175)},
                {"E1", new Point(770, 450)},
                {"E2", new Point(770, 210)},
                {"E12", new Point(452, 560)},
                {"F", new Point(860, 210)},
                {"G", new Point(820, 210)},
                {"H", new Point(950, 260)},
                {"I", new Point(820, 275)},
                {"J", new Point(700, 310)},
                {"K", new Point(820, 310)},
                {"L", new Point(945, 330)},
                {"M", new Point(820, 380)},
                {"N", new Point(700, 385)},
                {"O", new Point(820, 550)},
                {"BGX", new Point(875, 550)},
                {"P", new Point(610, 170)},
                {"Q", new Point(695, 210)},
                {"R", new Point(560, 60)},
                {"S", new Point(700, 10)},
                {"T", new Point(480, 80)},
                {"V", new Point(625, 550)},
                {"V2", new Point(770, 550)},
                {"V1", new Point(770, 640)},
                {"X", new Point(520, 310)},
                {"Z", new Point(625, 395)},
                {"XT", new Point(520, 265)},
                {"PQ", new Point(620, 275)},
                {"QW", new Point(400, 505)},
                {"MN", new Point(452, 515)},
                {"ER", new Point(452, 602)},

                // Các điểm số
                {"1", new Point(310, 555)},
                {"2", new Point(170, 618)},
                {"3", new Point(350, 685)},
                {"4", new Point(215, 710)},
                {"5", new Point(170, 710)},
                {"6", new Point(360, 770)},
                {"7", new Point(250, 765)},
                {"8", new Point(170, 775)},
                {"9", new Point(525, 740)}
            };
        }

        public void UpdateShortestPath(List<string> path)
        {
            shortestPath = path;
            DrawGraph();
        }

        private void DrawGraph()
        {
            using (Graphics g = Graphics.FromImage(graphBitmap))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Vẽ các cạnh
                foreach (var vertex in graph._adjacencyList)
                {
                    foreach (var edge in vertex.Value)
                    {
                        Point start = vertexPositions[vertex.Key];
                        Point end = vertexPositions[edge.Item1];

                        bool isInShortestPath = IsEdgeInShortestPath(vertex.Key, edge.Item1);

                        Point midPoint = new Point(
                            (start.X + end.X) / 2,
                            (start.Y + end.Y) / 2
                        );
                        using (Font font = new Font("Arial", 9))
                        {
                            string weight = edge.Item2.ToString("F1");
                            g.DrawString(weight, font, Brushes.Blue, midPoint);
                        }

                        if (isInShortestPath)
                        {
                            using (Pen pen = new Pen(Color.Red, 3))
                            {
                                g.DrawLine(pen, start, end);
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(Color.Black, 1))
                            {
                                g.DrawLine(pen, start, end);
                            }
                        }
                    }
                }

                // Vẽ các đỉnh
                foreach (var vertex in vertexPositions)
                {
                    int radius = 25;
                    Rectangle rect = new Rectangle(
                        vertex.Value.X - radius / 2,
                        vertex.Value.Y - radius / 2,
                        radius,
                        radius
                    );

                    if (shortestPath.Contains(vertex.Key))
                    {
                        g.FillEllipse(Brushes.Red, rect);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.LightYellow, rect);
                    }

                    g.DrawEllipse(Pens.Black, rect);

                    using (Font font = new Font("Arial", 10, FontStyle.Bold))
                    {
                        SizeF textSize = g.MeasureString(vertex.Key, font);
                        g.DrawString(
                            vertex.Key,
                            font,
                            Brushes.Black,
                            vertex.Value.X - textSize.Width / 2,
                            vertex.Value.Y - textSize.Height / 2
                        );
                    }
                }
            }

            pictureBox1.Refresh();
        }

        private bool IsEdgeInShortestPath(string v1, string v2)
        {
            for (int i = 0; i < shortestPath.Count - 1; i++)
            {
                if ((shortestPath[i] == v1 && shortestPath[i + 1] == v2) ||
                    (shortestPath[i] == v2 && shortestPath[i + 1] == v1))
                {
                    return true;
                }
            }
            return false;
        }
    }
}