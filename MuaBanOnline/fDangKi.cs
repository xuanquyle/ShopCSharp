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
    public partial class fDangKi : Form
    {
        public fDangKi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = textBox1.Text;
            string mk = textBox2.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            using (conn)
            {
                string saveStaff = "INSERT into TAIKHOAN (TENTK,MATKHAU) VALUES (@TENTK,@MATKHAU)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = conn;
                    querySaveStaff.Parameters.Add("@TENTK", SqlDbType.VarChar, 10).Value = tk;
                    querySaveStaff.Parameters.Add("@MATKHAU", SqlDbType.VarChar, 50).Value = mk;
                    conn.Open();
                    querySaveStaff.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoản thành công");
                    this.Hide();
                }
            }
            conn.Close();
        }
    }
}
