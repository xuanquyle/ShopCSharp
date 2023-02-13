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
    public partial class fTrangChu : Form
    {
        public static List<GAME> game = new List<GAME>();
        static string sql = "select * from GAME";
        //  static SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");

        public fTrangChu()
        {
            InitializeComponent();

        }
        public static string theLoai(string theloai)
        {
            sql = "seclect * from GAME where THELOAI='" + theloai + "'";
            return sql;
        }
        public static string hinhThuc(string hinhthuc)
        {
            sql = "select *from GAME where HINHTHUC='" + hinhthuc + "'";
            return sql;
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFlashSale_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btXemThem_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btXemThem_Click_1(object sender, EventArgs e)
        {

        }

        private void NIKEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        //private void pictureBox1_MouseHover(object sender, EventArgs e)
        //{
        //    label2.Text = "500.000đ";
        //    label2.BackColor = Transparent;
        //}

        //private void pictureBox1_MouseLeave(object sender, EventArgs e)
        //{
        //    label2.Text = " ";
        //}




        public Color Transparent { get; set; }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "500.000đ";
            label2.BackColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.White;
            pictureBox1.Width = 251;
            pictureBox1.Height = 151;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
            pictureBox1.Width = 241;
            pictureBox1.Height = 146;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label7.Text = "600.000đ";
            label7.BackColor = System.Drawing.Color.Black;
            label7.ForeColor = System.Drawing.Color.White;
            pictureBox2.Width = 251;
            pictureBox2.Height = 151;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "";
            pictureBox2.Width = 241;
            pictureBox2.Height = 146;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "1.200.000đ";
            label3.BackColor = System.Drawing.Color.Black;
            label3.ForeColor = System.Drawing.Color.White;
            pictureBox3.Width = 251;
            pictureBox3.Height = 151;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
            pictureBox3.Width = 241;
            pictureBox3.Height = 146;
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "1.200.000đ";
            label4.BackColor = System.Drawing.Color.Black;
            label4.ForeColor = System.Drawing.Color.White;
            pictureBox4.Width = 251;
            pictureBox4.Height = 151;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
            pictureBox4.Width = 241;
            pictureBox4.Height = 146;
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label5.Text = "900.000đ";
            label5.BackColor = System.Drawing.Color.Black;
            label5.ForeColor = System.Drawing.Color.White;
            pictureBox5.Width = 251;
            pictureBox5.Height = 151;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "";
            pictureBox5.Width = 241;
            pictureBox5.Height = 146;
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label6.Text = "800.000đ";
            label6.BackColor = System.Drawing.Color.Black;
            label6.ForeColor = System.Drawing.Color.White;
            pictureBox6.Width = 251;
            pictureBox6.Height = 151;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = "";
            pictureBox6.Width = 241;
            pictureBox6.Height = 146;
        }
        private void pnFamous_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lbFlashSale_Click_1(object sender, EventArgs e)
        {

        }

        private void đUAXEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hÀNHĐỘNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cỐTTRUYỆNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nHẬPVAIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kINHDỊToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mOBAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThanhToan.clearThanhToan();
            fThanhToan news = new fThanhToan();
            this.Hide();
            news.ShowDialog();
            this.Show();
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin news = new fLogin();
            this.Hide();
            clearGioHang();
            fThanhToan.clearThanhToan();
            news.ShowDialog();
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {

        }

        private void pnSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        public static int soSanh(string a, string b)
        {
            a = " " + a;
            b = " " + b;

            int[,] F = new int[a.Length, b.Length];
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    F[i, j] = 0;
            for (int i = 1; i < a.Length; i++)
                for (int j = 1; j < b.Length; j++)
                    if (a[i] == b[j]) F[i, j] = F[i - 1, j - 1] + 1;
                    else F[i, j] = Math.Max(F[i - 1, j], F[i, j - 1]);
            //int dem = F[0, 0];
            //int max = 0;
            //for (int i = 1; i < a.Length; i++)
            //{
            //    if (i<b.Length)
            //    {
            //        if (F[i, i ] > F[i - 1, i-1] )
            //        {
            //            dem = dem + 1;
            //        }
            //        else
            //        {
            //            if(max<dem)
            //                max = dem;
            //            dem = 0;
            //        }

            //    }
            //    else
            //        break;
            //}
            return F[a.Length - 1, b.Length - 1];
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            game.Clear();
            sql = "select * from GAME";
            game = loadData();
            string text = txbSearch.Text;
            List<GAME> g = new List<GAME>();
            List<int> len = new List<int>();
            if (text.Length > 10)
            {
                MessageBox.Show("Khong tìm thấy kết quả");
            }
            else
            {
                for (int i = 0; i < fTrangChu.game.Count; i++)
                {

                    int a = soSanh(text.ToLower(), fTrangChu.game[i].TENGAME.ToLower());
                    if (text.Length >= 3)
                    {
                        if (a >= 3)
                        {
                            g.Add(fTrangChu.game[i]);
                            len.Add(a);
                        }
                    }
                    else
                        if (a >= 1)
                        {
                            g.Add(fTrangChu.game[i]);
                            len.Add(a);
                        }

                }

                if (g.Count > 0)
                {
                    for (int i = 0; i < len.Count; i++)
                    {
                        for (int j = i + 1; j < len.Count; j++)
                        {
                            if (len[j] > len[i])
                            {
                                GAME a = g[j];
                                g[j] = g[i];
                                g[i] = a;
                            }
                        }
                    }
                    fTrangChu.game = g;
                    fViewGame.title = "Tìm kiếm từ khóa: " + text;
                    fViewGame news1 = new fViewGame();
                    this.Hide();
                    news1.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Không tìm thấy kết quả phù hợp");
            }

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        public static List<GAME> loadData()
        {
            game.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            using (conn)
            {

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string GAMEID = (string)reader["GAMEID"];
                    string TENGAME = (string)reader["TENGAME"];
                    string THELOAI = (string)reader["THELOAI"];
                    DateTime NGAYPH = (DateTime)reader["NGAYPH"];
                    int GIA = (int)reader["GIA"];
                    int PHOBIEN = (int)reader["PHOBIEN"];
                    string MOTA = (string)reader["MOTA"];
                    string HINHTHUC = (string)reader["HINHTHUC"];
                    string ANH = (string)reader["ANH"];

                    GAME a = new GAME(GAMEID, TENGAME, THELOAI, NGAYPH, GIA, PHOBIEN, MOTA, HINHTHUC, ANH);
                    game.Add(a);

                }
                reader.Close();

            }
            return game;
        }

        public static List<GAME> sortByGia()
        {
            for (int j = 0; j < game.Count; j++)
            {
                for (int t = j + 1; t < game.Count; t++)
                    if (game[t].GIA < game[j].GIA)
                    {
                        GAME a = game[j];
                        game[j] = game[t];
                        game[t] = a;
                    }
            }
            return game;
        }
        public static List<GAME> sortByGiaGiam()
        {


            for (int j = 0; j < game.Count; j++)
            {
                for (int t = j + 1; t < game.Count; t++)
                    if (fTrangChu.game[t].GIA > fTrangChu.game[j].GIA)
                    {
                        GAME a = fTrangChu.game[j];
                        fTrangChu.game[j] = fTrangChu.game[t];
                        fTrangChu.game[t] = a;
                    }
            }
            return fTrangChu.game;
        }
        public static List<GAME> sortByPhobien()
        {
            for (int j = 0; j < game.Count; j++)
            {
                for (int t = j + 1; t < game.Count; t++)
                    if (game[t].PHOBIEN > game[j].PHOBIEN)
                    {
                        GAME a = game[j];
                        game[j] = game[t];
                        game[t] = a;
                    }
            }
            return game;
        }
        private void SteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Clear();
            hinhThuc("steam");
            loadData();
            fViewGame news = new fViewGame();
            fViewGame.title = "STEAM";
            this.Hide();
            news.ShowDialog();
            this.Show();
        }

        private void OnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Clear();
            hinhThuc("online");
            loadData();
            fViewGame news = new fViewGame();
            fViewGame.title = "ONLINE";
            this.Hide();
            news.ShowDialog();
            this.Show();
        }

        private void OfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Clear();
            hinhThuc("offline");
            loadData();
            fViewGame news = new fViewGame();
            fViewGame.title = "OFFLINE";
            this.Hide();
            news.ShowDialog();
            this.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            clearGioHang();
            fLogin news = new fLogin();
            this.Hide();
            news.ShowDialog();


        }

        //private void label8_MouseHover(object sender, EventArgs e)
        //{
        //    label8.BackColor = System.Drawing.Color.White;
        //    label8.ForeColor = System.Drawing.Color.Black;
        //}

        //private void label8_MouseLeave(object sender, EventArgs e)
        //{
        //    label8.BackColor = System.Drawing.Color.Crimson;
        //    label8.ForeColor = System.Drawing.Color.White;
        //}
        public static void clearGioHang()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");

            string sqlStatement = "DELETE FROM GIOHANG";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            finally
            {
                connection.Close();
            }
        }
        
        private void label10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
                clearGioHang();
            }
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Crimson;
            button1.ForeColor = System.Drawing.Color.White;
        }

        private void dịchVụHỗTrợTạiNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoTro news = new fHoTro();
            this.Hide();
            news.ShowDialog();
            this.Show();
        }
    }
}