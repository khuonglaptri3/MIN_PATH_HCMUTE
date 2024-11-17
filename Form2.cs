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
    public partial class Group_6_Final_project : Form
    {
        private Graph graph = new Graph(); // Khởi tạo đồ thị 
        public Group_6_Final_project()
        {
            graph.AddEdge("B3", "B4", 0.75);
            graph.AddEdge("B4", "B5", 1.8);
            graph.AddEdge("C4", "B4", 0.8);
            graph.AddEdge("C4", "X", 2.2);
            graph.AddEdge("C4", "Z", 0.6);
            graph.AddEdge("XT", "X", 1.7);
            graph.AddEdge("X", "C9", 5.1);
            graph.AddEdge("Z", "C5", 2);
            graph.AddEdge("B5", "N", 0.7);
            graph.AddEdge("C5", "V", 1.1);
            graph.AddEdge("V", "C9", 3);
            graph.AddEdge("1", "D5", 0.8);
            graph.AddEdge("2", "D5", 2.5);
            graph.AddEdge("D5", "D6", 1);
            graph.AddEdge("D6", "5", 5.2);
            graph.AddEdge("4", "5", 0.25);
            graph.AddEdge("C9", "E12", 1.85);
            graph.AddEdge("C9", "D1", 2);
            graph.AddEdge("E12", "MN", 0.5);
            graph.AddEdge("E12", "ER", 0.9);
            graph.AddEdge("E12", "D3", 2.5);
            graph.AddEdge("D3", "QW", 0.5);
            graph.AddEdge("D3", "1", 2.25);
            graph.AddEdge("D3", "D4", 2.5);
            graph.AddEdge("ER", "D2", 1.1);
            graph.AddEdge("D2", "D1", 1.6);
            graph.AddEdge("D4", "D2", 2.65);
            graph.AddEdge("D4", "3", 0.6);
            graph.AddEdge("D6", "D4", 2);
            graph.AddEdge("D6", "D7", 2.3);
            graph.AddEdge("D7", "4", 1.5);
            graph.AddEdge("A", "D9", 0.6);
            graph.AddEdge("D9", "B", 0.5);
            graph.AddEdge("A3", "D9", 0.8);
            graph.AddEdge("A3", "A2", 1.2);
            graph.AddEdge("A2", "S", 1.5);
            graph.AddEdge("A1", "A2", 0.6);
            graph.AddEdge("A1", "R", 0.95);
            graph.AddEdge("R", "T", 2);
            graph.AddEdge("T", "A11", 2.3);
            graph.AddEdge("A11", "A10", 2);
            graph.AddEdge("A7", "A6", 2.1);
            graph.AddEdge("A10", "P", 0.25);
            graph.AddEdge("A8", "Q", 0.18);
            graph.AddEdge("P", "A9", 0.55);
            graph.AddEdge("A9", "PQ", 1.8);
            graph.AddEdge("B1", "XT", 0.85);
            graph.AddEdge("PQ", "B3", 1.25);
            graph.AddEdge("B2", "J", 0.75);
            graph.AddEdge("D7", "D8", 1.1);
            graph.AddEdge("D8", "3", 0.75);
            graph.AddEdge("D8", "6", 3);
            graph.AddEdge("R", "A10", 2.2);
            graph.AddEdge("A1", "A7", 2);
            graph.AddEdge("A3", "A6", 2.5);
            graph.AddEdge("B", "C", 0.35);
            graph.AddEdge("C", "A4", 0.6);
            graph.AddEdge("C", "D", 0.95);
            graph.AddEdge("A4", "A5", 2.9);
            graph.AddEdge("D", "A5", 0.8);
            graph.AddEdge("D", "E", 1.1);
            graph.AddEdge("A10", "A7", 1.5);
            graph.AddEdge("A11", "XT", 1.95);
            graph.AddEdge("A7", "A8", 1.2);
            graph.AddEdge("A8", "A9", 0.75);
            graph.AddEdge("P", "B1", 2.2);
            graph.AddEdge("B1", "PQ", 0.72);
            graph.AddEdge("A8", "B2", 3.75);
            graph.AddEdge("B3", "B2", 1);
            graph.AddEdge("B5", "J", 0.25);
            graph.AddEdge("6", "7", 1.5);
            graph.AddEdge("7", "8", 1.65);
            graph.AddEdge("A6", "A4", 1.3);
            graph.AddEdge("A6", "E2", 0.9);
            graph.AddEdge("E2", "G", 0.6);
            graph.AddEdge("G", "F", 0.8);
            graph.AddEdge("F", "C1", 0.45);
            graph.AddEdge("C1", "A5", 0.78);
            graph.AddEdge("C1", "E", 0.55);
            graph.AddEdge("E2", "C2", 1.3);
            graph.AddEdge("C2", "C3", 1.25);
            graph.AddEdge("C3", "B9", 1.92);
            graph.AddEdge("B9", "C1", 1.8);
            graph.AddEdge("B9", "H", 1.2);
            graph.AddEdge("E", "H", 1);
            graph.AddEdge("C3", "I", 0.3);
            graph.AddEdge("I", "K", 0.4);
            graph.AddEdge("C2", "B6", 2.75);
            graph.AddEdge("B5", "B6", 1);
            graph.AddEdge("B6", "B8", 1.5);
            graph.AddEdge("B8", "C8", 1.75);
            graph.AddEdge("C8", "B9", 2.5);
            graph.AddEdge("K", "B8", 0.25);
            graph.AddEdge("B8", "M", 0.7);
            graph.AddEdge("C8", "L", 0.85);
            graph.AddEdge("B6", "B7", 1.25);
            graph.AddEdge("B7", "N", 0.55);
            graph.AddEdge("B7", "M", 1.2);
            graph.AddEdge("C8", "C7", 4.5);
            graph.AddEdge("B7", "C6", 1.5);
            graph.AddEdge("C6", "E1", 0.5);
            graph.AddEdge("E1", "C7", 1.5);
            graph.AddEdge("C7", "O", 0.8);
            graph.AddEdge("D1", "9", 5);
            graph.AddEdge("E1", "9", 10);
            graph.AddEdge("V", "9", 6);





            InitializeComponent();
        }
        public Dictionary<string, string> vitri()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("A", "A: Phong thi nghiem khoa xay dung. ");
            keyValuePairs.Add("S", "S: Phong y te. ");
            keyValuePairs.Add("A1", "A1: Nut giao A1");
            keyValuePairs.Add("A2", "A2: Nut giao  A2 ");
            keyValuePairs.Add("A3", "A3: Nut giao  A3 ");
            keyValuePairs.Add("A4", "A4: Nut giao  A4 ");
            keyValuePairs.Add("A5", "A5: Nut giao  A5 ");
            keyValuePairs.Add("A6", "A6: Nut giao  A6 ");
            keyValuePairs.Add("A7", "A7: Nut giao  A7 ");
            keyValuePairs.Add("A8", "A8: Nut giao  A8 ");
            keyValuePairs.Add("A9", "A9: Nut giao  A9 ");
            keyValuePairs.Add("A10", "A10: Nut giao  A10 ");
            keyValuePairs.Add("A11", "A11: Nut giao  A11");
            keyValuePairs.Add("B", "B: Van phong thu vien ");
            keyValuePairs.Add("B1", "B1: Nut giao  B1 ");
            keyValuePairs.Add("B2", "B2: Nut giao  B2 ");
            keyValuePairs.Add("B3", "B3: Nut giao  B3 ");
            keyValuePairs.Add("B4", "B4: Nut giao  B4 ");
            keyValuePairs.Add("B5", "B5: Nut giao  B5 ");
            keyValuePairs.Add("B6", "B6: Nut giao  B6 ");
            keyValuePairs.Add("B7", "B7: Nut giao  B7 ");
            keyValuePairs.Add("B8", "B8: Nut giao  B8 ");
            keyValuePairs.Add("B9", "B9: Nut giao  B9 ");
            keyValuePairs.Add("C", "C: Xuong thuc tap go ");
            keyValuePairs.Add("C1", "C1: Nut giao  C1 ");
            keyValuePairs.Add("C2", "C2: Nut giao  C2 ");
            keyValuePairs.Add("C3", "C3: Nut giao  C3 ");
            keyValuePairs.Add("C4", "C4: Nut giao  C4 ");
            keyValuePairs.Add("C5", "C5: Nut giao  C5 ");
            keyValuePairs.Add("C6", "C6: Nut giao  C6 ");
            keyValuePairs.Add("C7", "C7: Nut giao  C7 ");
            keyValuePairs.Add("C8", "C8: Nut giao  C8 ");
            keyValuePairs.Add("C9", "C9: Nut giao  C9 ");
            keyValuePairs.Add("D", "Xuong o to dien");
            keyValuePairs.Add("D1", "D1: Nut giao  D1 ");
            keyValuePairs.Add("D2", "D2: Nut giao  D2 ");
            keyValuePairs.Add("D3", "D3: Nut giao  D3 ");
            keyValuePairs.Add("D4", "D4: Nut giao  D4 ");
            keyValuePairs.Add("D5", "D5: Nut giao  D5 ");
            keyValuePairs.Add("D6", "D6: Nut giao  D6 ");
            keyValuePairs.Add("D7", "D7: Nut giao  D7 ");
            keyValuePairs.Add("D8", "D8: Nut giao  D8 ");
            keyValuePairs.Add("D9", "D9: Nut giao  D9 ");
            keyValuePairs.Add("E", "E: Xuong thuc tap Dong Son (Khoa Co khi dong luc)");
            keyValuePairs.Add("E1", "E1: Nut giao  E1 ");
            keyValuePairs.Add("1", "1: Xuong in va Nha thi dau khu E ");
            keyValuePairs.Add("2", "2: Xuong thuc tap han ");
            keyValuePairs.Add("3", "3: E3 : Khoi xuong thuc hanh khoa co khi ");
            keyValuePairs.Add("4", "4: E0 : Khoi van phong khoa co khi may ");
            keyValuePairs.Add("5", "5: Phong thi nghiem vat lieu ");
            keyValuePairs.Add("6", "E4: Khoi hoc bat giac ");
            keyValuePairs.Add("7", "7 : Khoa CNTT ");
            keyValuePairs.Add("8", "8 : Khoi nha L ");
            keyValuePairs.Add("9", "9 : Cong chinh Truong spkt ");
            keyValuePairs.Add("QW", "E1 : Khoi xuong thuc hanh co khi may - Khoa chat luong cao. ");
            keyValuePairs.Add("MN", "E2,1 : Cang tin 1 (Canh Thanh Dat)   ");
            keyValuePairs.Add("XT", "Khoi D ");
            keyValuePairs.Add("V", "Khu A1: Khoi cac van phong ban");
            keyValuePairs.Add("ER", "E2,2 : Cua hang tien ich thanh dat");
            keyValuePairs.Add("O", "San bong da ngoai troi");
            keyValuePairs.Add("Z", "Hoi Truong Lon");
            keyValuePairs.Add("N", "San mai vom");
            keyValuePairs.Add("J", "Khoi phong hoc");
            keyValuePairs.Add("K", "Khu F1: Khoa Dao tao Quoc te");
            keyValuePairs.Add("L", "Khu market space");
            keyValuePairs.Add("M", "Khu G (Toa nha Viet Duc)");
            keyValuePairs.Add("I", "Xuong Dong Co");
            keyValuePairs.Add("H", "Khoa Co Khi Dong Luc");
            keyValuePairs.Add("F", "Xuong Khung gam");
            keyValuePairs.Add("E12", "Nut giao E12");
            keyValuePairs.Add("E2", "Khu E2: Khoa Co Khi May");
            keyValuePairs.Add("G", "Xuong nhiet dien lanh");
            keyValuePairs.Add("P", "Thu Vien");
            keyValuePairs.Add("PQ", "Khoi A trung tam");
            keyValuePairs.Add("Q", "Phong cong tac sinh vien");
            keyValuePairs.Add("X", "Khoa Cong nghe may");
            keyValuePairs.Add("R", "Khoi B");
            keyValuePairs.Add("T", "Khoi C");
            return keyValuePairs;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs = vitri();
            string start = Combostart.SelectedItem.ToString();   
            //string start = textBox1.Text;
            string end = Comboend.SelectedItem.ToString();  
            string Result = " ";
            var result = graph.Dijkstra(start, end);
            for (int i = 0; i < result.Count; i++)
            {
                Result += keyValuePairs[result[i]] +" -> " + "\n ";
            }
            if (result != null)
            {
                label3.Text = "Đường đi ngắn nhất từ \n " + start + " đến " + end + " là: \n " + Result;
            }
            else
            {
                label3.Text = "Không có đường đi từ " + start + " đến " + end;
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.Size = Properties.Resources.MAPHOANCHINH.Size;
        }
    }
}
