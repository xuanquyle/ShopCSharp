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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class fKindOfGame : Form
    {
        public DataTable GIOHANG = new DataTable();
        public SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
        public fKindOfGame()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private List<GAME> sortByGia(List<GAME> game)
        {

            int i = 0;
            while (fTrangChu.game[i] != null)
            {
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                for (int t = j + 1; t < i; t++)
                    if (fTrangChu.game[t].GIA < fTrangChu.game[j].GIA)
                    {
                        GAME a = fTrangChu.game[j];
                        fTrangChu.game[j] = fTrangChu.game[t];
                        fTrangChu.game[t] = a;
                    }
            }
            return fTrangChu.game;
        }

        private List<GAME> sortByPhobien(List<GAME> game)
        {

            int i = 0;
            while (fTrangChu.game[i] != null)
            {
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                for (int t = j + 1; t < i; t++)
                    if (fTrangChu.game[t].PHOBIEN < fTrangChu.game[j].PHOBIEN)
                    {
                        GAME a = fTrangChu.game[j];
                        fTrangChu.game[j] = fTrangChu.game[t];
                        fTrangChu.game[t] = a;
                    }
            }
            return fTrangChu.game;
        }
        private void fKindOfGame_Load(object sender, EventArgs e)
        {
            setLb1();
            if (fTrangChu.game.Count > 0)
            {
                lb1.Text = fTrangChu.game[0].TENGAME;
                lb7.Text = fTrangChu.game[0].MOTA;
                lb13.Text = fTrangChu.game[0].THELOAI;
                lb19.Text = fTrangChu.game[0].PHOBIEN.ToString() + " lượt tải";
                lb25.Text = fTrangChu.game[0].GIA.ToString() + "đ";
                pictureBox1.Image = Image.FromFile(fTrangChu.game[0].ANH);
            }
            else
            {
                lb1.Text = "";
                lb7.Text = "";
                lb13.Text = "";
                lb19.Text = "";
                lb25.Text = "";
            }
            if (fTrangChu.game.Count > 1)
            {
                lb2.Text = fTrangChu.game[1].TENGAME;
                lb8.Text = fTrangChu.game[1].MOTA;
                lb14.Text = fTrangChu.game[1].THELOAI;
                lb20.Text = fTrangChu.game[1].PHOBIEN.ToString() + " lượt tải";
                lb26.Text = fTrangChu.game[1].GIA.ToString() + "đ";
                pictureBox4.Image = Image.FromFile(fTrangChu.game[1].ANH);
            }
            else
            {
                lb2.Text = "";
                lb8.Text = "";
                lb14.Text = "";
                lb20.Text = "";
                lb26.Text = "";
            }
            if (fTrangChu.game.Count > 2)
            {
                lb3.Text = fTrangChu.game[2].TENGAME;
                lb9.Text = fTrangChu.game[2].MOTA;
                lb15.Text = fTrangChu.game[2].THELOAI;
                lb21.Text = fTrangChu.game[2].PHOBIEN.ToString() + " lượt tải";
                lb27.Text = fTrangChu.game[2].GIA.ToString() + "đ";
                pictureBox6.Image = Image.FromFile(fTrangChu.game[2].ANH);
            }
            else
            {
                lb3.Text = "";
                lb9.Text = "";
                lb15.Text = "";
                lb21.Text = "";
                lb27.Text = "";
            }
            if (fTrangChu.game.Count > 3)
            {
                lb4.Text = fTrangChu.game[3].TENGAME;
                lb10.Text = fTrangChu.game[3].MOTA;
                lb16.Text = fTrangChu.game[3].THELOAI;
                lb22.Text = fTrangChu.game[3].PHOBIEN.ToString() + " lượt tải";
                lb28.Text = fTrangChu.game[3].GIA.ToString() + "đ";
                pictureBox8.Image = Image.FromFile(fTrangChu.game[3].ANH);
            }
            else
            {
                lb4.Text = "";
                lb10.Text = "";
                lb16.Text = "";
                lb22.Text = "";
                lb28.Text = "";
            }
            if (fTrangChu.game.Count > 4)
            {
                lb5.Text = fTrangChu.game[4].TENGAME;
                lb11.Text = fTrangChu.game[4].MOTA;
                lb17.Text = fTrangChu.game[4].THELOAI;
                lb23.Text = fTrangChu.game[4].PHOBIEN.ToString() + " lượt tải";
                lb29.Text = fTrangChu.game[4].GIA.ToString() + "đ";
                pictureBox10.Image = Image.FromFile(fTrangChu.game[4].ANH);
            }
            else
            {
                lb5.Text = "";
                lb11.Text = "";
                lb17.Text = "";
                lb23.Text = "";
                lb29.Text = "";
            }
            if (fTrangChu.game.Count > 5)
            {
                lb6.Text = fTrangChu.game[5].TENGAME;
                lb12.Text = fTrangChu.game[5].MOTA;
                lb18.Text = fTrangChu.game[5].THELOAI;
                lb24.Text = fTrangChu.game[5].PHOBIEN.ToString() + " lượt tải";
                lb30.Text = fTrangChu.game[5].GIA.ToString() + "đ";
                pictureBox12.Image = Image.FromFile(fTrangChu.game[5].ANH);
            }
            else
            {
                lb6.Text = "";
                lb12.Text = "";
                lb18.Text = "";
                lb24.Text = "";
                lb30.Text = "";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setLb1()
        {
            label1.Text = title;


        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void lb27_Click(object sender, EventArgs e)
        {

        }

        private void lb19_Click(object sender, EventArgs e)
        {

        }

        private void lb20_Click(object sender, EventArgs e)
        {

        }

        private void lb21_Click(object sender, EventArgs e)
        {

        }

        private void lb22_Click(object sender, EventArgs e)
        {

        }

        private void lb23_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByGia();
            fKindOfGame news1 = new fKindOfGame();
            this.Hide();
            news1.ShowDialog();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTrangChu news = new fTrangChu();
            news.ShowDialog();
        }


        //private void btSearch_Click(object sender, EventArgs e)
        //{
        //    string text = txbSearch.Text;
        //    List<GAME> g = new List<GAME>();
        //    List<int> len = new List<int>();
        //    for(int i=0;i<fTrangChu.game.Count;i++)
        //    {
        //        if(soSanh(text,fTrangChu.game[i].TENGAME)>=4)
        //        {
        //            g.Add(fTrangChu.game[i]);
        //            len.Add(soSanh(text, fTrangChu.game[i].TENGAME));
        //        }
        //    }
        //    fTrangChu.game = g;
        //    fKindOfGame news1 = new fKindOfGame();
        //    this.Hide();
        //    news1.ShowDialog();    

        //}

        private void lb6_Click(object sender, EventArgs e)
        {

        }

        private void lb10_Click(object sender, EventArgs e)
        {

        }

        private void lb11_Click(object sender, EventArgs e)
        {

        }

        private void lb12_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Crimson;
            label2.ForeColor = System.Drawing.Color.White;
        }

        private void giáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByGia();
            fKindOfGame news1 = new fKindOfGame();
            this.Hide();
            news1.ShowDialog();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByGiaGiam();
            fKindOfGame news1 = new fKindOfGame();
            this.Hide();
            news1.ShowDialog();
        }

        private void phổBiếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByPhobien();
            fKindOfGame news1 = new fKindOfGame();
            this.Hide();
            news1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (fTrangChu.game.Count > 0)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
                if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (conn)
                    {
                        conn.Open();

                        string gameid = fTrangChu.game[0].GAMEID;
                        string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == false)
                        {
                            conn.Close();
                            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = conn;
                                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[0].GAMEID;
                                conn.Open();
                                querySaveStaff.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Đã thêm vào giỏ hàng ");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã được thêm vào trước đó!!");
                        }
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (fTrangChu.game.Count > 1)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
                if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (conn)
                    {
                        conn.Open();

                        string gameid = fTrangChu.game[1].GAMEID;
                        string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == false)
                        {
                            conn.Close();
                            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = conn;
                                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[1].GAMEID;
                                conn.Open();
                                querySaveStaff.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Đã thêm vào giỏ hàng ");
                        }

                        else
                        {
                            MessageBox.Show("Sản phẩm đã được thêm vào trước đó!!");
                        }
                    }

                    //
                }

                //
                conn.Close();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (fTrangChu.game.Count > 2)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
                if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (conn)
                    {
                        conn.Open();

                        string gameid = fTrangChu.game[2].GAMEID;
                        string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == false)
                        {
                            conn.Close();
                            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = conn;
                                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[2].GAMEID;
                                conn.Open();
                                querySaveStaff.ExecuteNonQuery();

                            }
                            conn.Close();
                            MessageBox.Show("Đã thêm vào giỏ hàng ");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã được thêm vào trước đó!!");
                        }

                    }

                    //
                }

                //
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (fTrangChu.game.Count > 3)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
                if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (conn)
                    {
                        conn.Open();
                        string gameid = fTrangChu.game[3].GAMEID;
                        string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == false)
                        {
                            conn.Close();
                            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = conn;
                                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[3].GAMEID;
                                conn.Open();
                                querySaveStaff.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Đã thêm vào giỏ hàng ");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã được thêm vào trước đó!!");
                        }
                    }

                    //
                }
            }
            //

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (fTrangChu.game.Count > 4)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
                if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (conn)
                    {
                        conn.Open();

                        string gameid = fTrangChu.game[4].GAMEID;
                        string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == false)
                        {
                            conn.Close();
                            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {
                                querySaveStaff.Connection = conn;
                                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[4].GAMEID;
                                conn.Open();
                                querySaveStaff.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Đã thêm vào giỏ hàng ");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã được thêm vào trước đó !!");
                        }
                    }


                    //
                }
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (fTrangChu.game.Count > 5)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
                if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (conn)
                    {
                        conn.Open();

                        string gameid = fTrangChu.game[5].GAMEID;
                        string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == false)
                        {
                            conn.Close();
                            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                            {

                                querySaveStaff.Connection = conn;
                                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[5].GAMEID;
                                conn.Open();
                                querySaveStaff.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Đã thêm vào giỏ hàng ");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã được thêm vào trước đó !!");
                        }
                    }

                    //
                }

                //
                conn.Close();

            }
        }

    }
    public class GAME
    {

        public string GAMEID { get; set; }
        public string TENGAME { get; set; }
        public string THELOAI { get; set; }
        public DateTime NGAYPH { get; set; }
        public int GIA { get; set; }
        public int PHOBIEN { get; set; }
        public string MOTA { get; set; }
        public string ANH { get; set; }
        public string HINHTHUC { get; set; }
        public GAME(string GAMEID, string TENGAME, string THELOAI, DateTime NGAYPH, int GIA, int PHOBIEN, string MOTA, string HINHTHUC, string ANH)
        {
            this.GAMEID = GAMEID;
            this.TENGAME = TENGAME;
            this.THELOAI = THELOAI;
            this.NGAYPH = NGAYPH;
            this.PHOBIEN = PHOBIEN;
            this.MOTA = MOTA;
            this.ANH = ANH;
            this.GIA = GIA;
            this.HINHTHUC = HINHTHUC;
        }


    }

}
