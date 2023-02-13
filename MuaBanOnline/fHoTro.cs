using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    
    public partial class fHoTro : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
        int n;//số đỉnh của đồ thị.

        int s;//đỉnh đầu.

        int t;//đỉnh cuối

        char chon;

        List<int> truoc = new List<int>();//mảng đánh dấu đường đi.

        List<int> d = new List<int>();//mảng đánh dấu khoảng cách.

        int[,] Matrix = new int[10, 10];//ma trận trọng số

        List<bool> chuaxet = new List<bool>();//mảng đánh dấu đỉnh đã được gán nhãn.
        public List<Dulieu> Hotro = new List<Dulieu>();
        public fHoTro()
        {
            InitializeComponent();
            conn.Open();
        }
        void Dijkstra()
        {

            int u=0, minp;

            //khởi tạo nhãn tạm thời cho các đỉnh.

            for (int v = 1; v <= n; v++)
            {

                d.Add(Matrix[s,v]);

                truoc.Add(s);

                chuaxet.Insert(v, false);

            }

            truoc[s] = 0;

            d[s] = 0;

            chuaxet[s] = true;

            //bươc lặp

            while (!chuaxet[t])
            {

                minp = 100000000;

                //tìm đỉnh u sao cho d[u] là nhỏ nhất

                for (int v = 1; v <= n; v++)
                {

                    if ((!chuaxet[v]) && (minp > d[v]))
                    {

                        u = v;

                        minp = d[v];

                    }

                }

                chuaxet[u] = true;// u la dinh co nhan tam thoi nho nhat

                if (!chuaxet[t])
                {

                    //gán nhãn lại cho các đỉnh.

                    for (int v = 1; v <= n; v++)
                    {

                        if ((!chuaxet[v]) && (d[u] + Matrix[u,v] < d[v]))
                        {

                            d[v] = d[u] + Matrix[u,v];

                            truoc[v] = u;

                        }

                    }

                }

            }

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fHoTro_Load(object sender, EventArgs e)
        {
        }
        public void loadData()
        {
            int i=0;
                comboBox1.Items.Add(Hotro);
        }
        private void fHoTro_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Hotro.Clear();
        }
    }
    public class Dulieu
    {
        public string MABD { get; set; }
        public string MAKT { get; set; }
        public string TENBD { get; set; }
        public string TENKT { get; set; }
        public int SOKM { get; set; }
        public Dulieu(string MABD,string MAKT,string TENBD,string TENKT,int SOKM)
        {
            this.MABD = MABD;
            this.MAKT = MAKT;
            this.TENBD = TENBD;
            this.TENKT = TENKT;
            this.SOKM = SOKM;
        }
    }
}
