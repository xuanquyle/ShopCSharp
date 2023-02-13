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
    public partial class fDeTail : Form
    {
        public fDeTail()
        {
            InitializeComponent();
        }



        private void fDeTail_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile(fViewGame.game.ANH);
            label8.Text = fViewGame.game.MOTA;
            label7.Text = fViewGame.game.NGAYPH.ToString();
            label6.Text = fViewGame.game.PHOBIEN.ToString();
            label5.Text = fViewGame.game.GIA.ToString()+" VND";
            label3.Text = fViewGame.game.TENGAME;
            label10.Text = fViewGame.game.THELOAI;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            if (MessageBox.Show("Thêm vào giỏ hàng", "Thêm vào giỏ hàng", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (conn)
                {
                    conn.Open();
                    string sql = " select * from GIOHANG where GAMEID ='" + fViewGame.game.GAMEID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == false)
                    {
                        conn.Close();
                        string saveStaff = "INSERT into GIOHANG (GAMEID) VALUES (@GAMEID)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = conn;
                            querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = fViewGame.game.GAMEID;
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
    }
}
