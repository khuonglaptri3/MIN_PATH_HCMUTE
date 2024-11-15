using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIN_PATH_HCMUTE
{
    public partial class Form2 : Form
    {
        private Graph graph = new Graph(); // Khởi tạo đồ thị 
        public Form2()
        {
            graph.AddEdge("C", "D", 5);
            graph.AddEdge("C", "B", 4);
            graph.AddEdge("B", "Thư Viện", 7.5);
            graph.AddEdge("B", "CTSX", 6);
            graph.AddEdge("B", "Y TẾ", 1);
            graph.AddEdge("B", "D", 7);
            graph.AddEdge("Y TẾ", "Gỗ", 7);
            graph.AddEdge("Gỗ", "Điện lạnh", 2);
            graph.AddEdge("Gỗ", "CTSX", 13);
            graph.AddEdge("Điện lạnh", "Động cơ", 2);
            graph.AddEdge("Động cơ", "Động lực", 7);
            graph.AddEdge("Động lực", "MKSP", 2);
            graph.AddEdge("CTSX", "Thư Viện", 1);
            graph.AddEdge("Thư Viện", "D", 4);
            graph.AddEdge("Thư Viện", "A", 0.5);
            graph.AddEdge("A", "HTL", 5);
            graph.AddEdge("A", "KPH", 2);
            graph.AddEdge("A", "D", 4);
            graph.AddEdge("A", "CNM", 3);
            graph.AddEdge("CTSX", "KPH", 11);
            graph.AddEdge("KPH", "F1", 6);
            graph.AddEdge("F1", "Động lực", 9);
            graph.AddEdge("KPH", "G", 6);
            graph.AddEdge("G", "Thể chất", 3);
            graph.AddEdge("HTL", "KPH", 4);
            graph.AddEdge("D", "CNM", 1);
            graph.AddEdge("CNM", "E2", 12);
            graph.AddEdge("CNM", "HTL", 1);
            graph.AddEdge("CNM", "KHUA", 16);
            graph.AddEdge("KHUA", "E2", 10);
            graph.AddEdge("KHUA", "HTL", 11);
            graph.AddEdge("KHUA", "MAIVOM", 4.5);
            graph.AddEdge("MAIVOM", "KPH", 2);
            graph.AddEdge("MAIVOM", "G", 2.5);
            graph.AddEdge("G", "F1", 3);
            graph.AddEdge("F1", "MKSP", 3);
            graph.AddEdge("G", "MKSP", 3);
            graph.AddEdge("MAIVOM", "c", 2.5);
            graph.AddEdge("E2", "E3", 10);
            graph.AddEdge("E3", "E4", 2);
            graph.AddEdge("E1", "E3", 15);
            graph.AddEdge("E1", "E2", 2);
            graph.AddEdge("E1", "TH", 2);
            graph.AddEdge("TH", "E0", 10);
            graph.AddEdge("E0", "TH1", 2);
            graph.AddEdge("Điện lạnh", "OTODIEN", 2);
            graph.AddEdge("Động lực", "Điện lạnh", 4);
            graph.AddEdge("Động lực", "OTODIEN", 0.5);

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = textBox1.Text;    
            string end = textBox2.Text;
            string Result = " "; 
            var result = graph.Dijkstra(start, end);
            for(int i = 0; i < result.Count; i++)
            {
                Result += result[i] + " -> ";
            }   
            if (result != null)
            {
                label3.Text = "Đường đi ngắn nhất từ " + start + " đến " + end + " là: "  + Result + " với chi phí là: " ;
            }
            else
            {
                label3.Text = "Không có đường đi từ " + start + " đến " + end;
            }
        }
    }
}
