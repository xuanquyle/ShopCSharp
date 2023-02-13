using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class fPay : Form
    {
        public fPay()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value) && int.TryParse(textBox1.Text, out value))
            {
                if (textBox1.Text.Length == 10 && textBox2.Text.Length == 6)
                {
                    MessageBox.Show("Thanh toán thành công");
                    this.Hide();

                    fThanhToan.clearThanhToan();

                }
            }
            else
                MessageBox.Show("Số tài khoản hoặc mật khẩu không hợp lệ ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
