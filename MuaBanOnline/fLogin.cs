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

    public partial class fLogin : Form
    {
        public static string tk="";
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void txbLoginName_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLoginAd_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            fTrangChu f = new fTrangChu();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAmin_Click(object sender, EventArgs e)
        {
            this.tabControlCustomer.BackColor = Color.Blue;
        }


        public void fLogin_FormClosing(object sender, FormClosingEventArgs cArgs)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void btExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            using(conn)
            {
                conn.Open();
                fLogin.tk = tbNameLogin.Text;
                string mk = tbPassWord.Text;
                string sql = " select * from TAIKHOAN where TENTK='" + tk + "'and MATKHAU='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    fTrangChu news = new fTrangChu();
                    this.Hide();
                    news.ShowDialog();
                    fTrangChu.clearGioHang();
                }
                else
                {
                    MessageBox.Show("Sai Tên Người Dùng Hoặc Mật Khẩu");
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
                fTrangChu.clearGioHang();
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fBan news = new fBan();
            this.Hide();
            news.ShowDialog();
        }

        private void tabPageCus_Click(object sender, EventArgs e)
        {

        }

        private void tbNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            fTrangChu.clearGioHang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fDangKi news = new fDangKi();
            this.Hide();
            news.ShowDialog();
            this.Show();
        }
      

    }
}
