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
    
    public partial class fViewGame : Form
    {
        public static GAME game;
        public static string title = "";
        public fViewGame()
        {
            InitializeComponent();
        }
        int loca = 123;
        private void ViewGame_Load(object sender, EventArgs e)
        {
            Title.Text = title;
            Title.Font = new Font("SVN-Batman Forever Alternate", 16, FontStyle.Bold);
            this.Width = 990;
            this.Height = 600;
            for (int i = 0; i < fTrangChu.game.Count; i++)
            {
                //ANH
                PictureBox p = new PictureBox();
                p.Width = 240;
                p.Height = 135;
                p.Location = new Point(23, loca);
                Image image = Image.FromFile(fTrangChu.game[i].ANH);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Name = fTrangChu.game[i].GAMEID;
                p.Image = (Image)image;
                Controls.Add(p);
                p.Click += this.PictureClick;
                //MOTA
                Label l = new Label();
                l.Location = new Point(284, loca);
                l.MaximumSize = new Size(240, 120);
                l.FlatStyle = FlatStyle.Standard;
                l.AutoSize = true;
                l.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                l.Text = fTrangChu.game[i].MOTA;
                Controls.Add(l);
                // The Loai
                Label l1 = new Label();
                l1.Location = new Point(579, loca);
                l1.MaximumSize = new Size(240, 120);
                l1.FlatStyle = FlatStyle.Standard;
                l1.AutoSize = true;
                l1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                l1.Text = fTrangChu.game[i].THELOAI;
                Controls.Add(l1);
                //Pho bien
                Label l2 = new Label();
                l2.Location = new Point(690, loca);
                l2.MaximumSize = new Size(240, 120);
                l2.FlatStyle = FlatStyle.Standard;
                l2.AutoSize = true;
                l2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                l2.Text = fTrangChu.game[i].PHOBIEN.ToString() + " lượt tải";
                Controls.Add(l2);
                //Gia
                Label l3 = new Label();
                l3.Location = new Point(850, loca);
                l3.MaximumSize = new Size(240, 120);
                l3.FlatStyle = FlatStyle.Standard;
                l3.AutoSize = true;
                l3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                l3.Text = fTrangChu.game[i].GIA.ToString() + " VND";
                Controls.Add(l3);
                loca += 140;
            }

        }

        private void PictureClick(object sender, EventArgs e)
        {
           
            PictureBox pictureBox = (PictureBox)sender;
            string a = pictureBox.Name;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            string sql = "select * from GAME where GAMEID='" + a + "'";
             using (conn)
             {

                 SqlCommand command = new SqlCommand(sql, conn);
                 conn.Open();
                 SqlDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     game= new GAME((string)reader["GAMEID"],(string)reader["TENGAME"],(string)reader["THELOAI"],(DateTime)reader["NGAYPH"],(int)reader["PHOBIEN"],(int)reader["GIA"],(string)reader["MOTA"],(string)reader["HINHTHUC"],(string)reader["ANH"]);
                 }

             }
             fDeTail news = new fDeTail();
            this.Hide();
            news.ShowDialog();
            this.Show();
            //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            //if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    using (conn)
            //    {
            //        conn.Open();
            //        string sql = " select * from GIOHANG where GAMEID ='" + a + "'";
            //        SqlCommand cmd = new SqlCommand(sql, conn);
            //        SqlDataReader dta = cmd.ExecuteReader();
            //        if (dta.Read() == false)
            //        {
            //            conn.Close();
            //            string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

            //            using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
            //            {
            //                querySaveStaff.Connection = conn;
            //                querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = a;
            //                conn.Open();
            //                querySaveStaff.ExecuteNonQuery();
            //            }
            //            conn.Close();
            //            MessageBox.Show("Đã thêm vào giỏ hàng ");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Sản phẩm đã được thêm vào trước đó!!");
            //        }
            //    }

            //    //
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gIÁCAOTRƯỚCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByGiaGiam();
            this.Hide();
            fViewGame news = new fViewGame();
            news.ShowDialog();
        }

        private void gIÁTHẤPTRƯỚCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByGia();
            this.Hide();
            fViewGame news = new fViewGame();
            news.ShowDialog();
        }

        private void pHỔBIẾNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTrangChu.sortByPhobien();
            this.Hide();
            fViewGame news = new fViewGame();
            news.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Crimson;
            button1.ForeColor = System.Drawing.Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
        }

        //

    }
}



//private List<GAME> sortByGia(List<GAME> game)
//{

//    int i = 0;
//    while (fTrangChu.game[i] != null)
//    {
//        i++;
//    }
//    for (int j = 0; j < i; j++)
//    {
//        for (int t = j + 1; t < i; t++)
//            if (fTrangChu.game[t].GIA < fTrangChu.game[j].GIA)
//            {
//                GAME a = fTrangChu.game[j];
//                fTrangChu.game[j] = fTrangChu.game[t];
//                fTrangChu.game[t] = a;
//            }
//    }
//    return fTrangChu.game;
//}

//private List<GAME> sortByPhobien(List<GAME> game)
//{

//    int i = 0;
//    while (fTrangChu.game[i] != null)
//    {
//        i++;
//    }
//    for (int j = 0; j < i; j++)
//    {
//        for (int t = j + 1; t < i; t++)
//            if (fTrangChu.game[t].PHOBIEN < fTrangChu.game[j].PHOBIEN)
//            {
//                GAME a = fTrangChu.game[j];
//                fTrangChu.game[j] = fTrangChu.game[t];
//                fTrangChu.game[t] = a;
//            }
//    }
//    return fTrangChu.game;
//}
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

//private void pictureBox1_Click(object sender, EventArgs e)
//{
//    if (fTrangChu.game.Count > 0)
//    {
//        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
//        if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
//        {
//            using (conn)
//            {
//                conn.Open();

//                string gameid = fTrangChu.game[0].GAMEID;
//                string sql = " select * from GIOHANG where GAMEID ='" + gameid + "'";

//                SqlCommand cmd = new SqlCommand(sql, conn);
//                SqlDataReader dta = cmd.ExecuteReader();
//                if (dta.Read() == false)
//                {
//                    conn.Close();
//                    string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

//                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
//                    {
//                        querySaveStaff.Connection = conn;
//                        querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fTrangChu.game[0].GAMEID;
//                        conn.Open();
//                        querySaveStaff.ExecuteNonQuery();
//                    }
//                    conn.Close();
//                    MessageBox.Show("Đã thêm vào giỏ hàng ");
//                }
//                else
//                {
//                    MessageBox.Show("Sản phẩm đã được thêm vào trước đó!!");
//                }
//            }
//        }
//    }
//}


