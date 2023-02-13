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

    public partial class fThanhToan : Form
    {
        static int tongtien = 0;
        SqlConnection conn;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        void loadData()
        {

            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select GIOHANG.GAMEID,TENGAME,THELOAI,NGAYPH,GIA,PHOBIEN,MOTA,HINHTHUC,GAME.SOLUONG,ANH from GIOHANG,GAME where GIOHANG.GAMEID=GAME.GAMEID";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        void LoadData1()
        {
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select THANHTOAN.GAMEID, TENGAME, GIA from THANHTOAN,GAME where THANHTOAN.GAMEID=GAME.GAMEID ";
            adapter.SelectCommand = cmd;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView2.DataSource = table1;
            dataGridView2.Columns[0].Visible = false;
        }
        public fThanhToan()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void THANHTOAN_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            label4.Text = "0";
            button1.Enabled = false;
            label2.Text = fLogin.tk;
            tongtien = 0;
            conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            conn.Open();
            loadData();
            LoadData1();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            clearThanhToan();
        }
        int vt = -1;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button5.Click -= button5_Click;
            if (tongtien == 0) label4.Text = "";
            label4.Text = tongtien.ToString();
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = table.Rows[vt];
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");
            using (conn)
            {
                conn.Open();
                string gameid = row["GAMEID"].ToString();
                string sql = " select * from THANHTOAN where GAMEID ='" + gameid + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == false)
                {
                    conn.Close();
                    using (conn)
                    {
                        string saveStaff = "INSERT into THANHTOAN (GAMEID) VALUES (@GAMEID)";
                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = conn;
                            querySaveStaff.Parameters.Add("@GAMEID", SqlDbType.VarChar, 10).Value = row["GAMEID"].ToString();
                            conn.Open();
                            querySaveStaff.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                    tongtien = tongtien + Int32.Parse(row["GIA"].ToString());


                }
                label4.Text = tongtien.ToString() + " VND";
                LoadData1();

            }
            if (tongtien != 0)
                button1.Enabled = true;
            fViewGame.game = new GAME(row["GAMEID"].ToString(), row["TENGAME"].ToString(), row["THELOAI"].ToString(), (DateTime)row["NGAYPH"], (int)row["GIA"], (int)row["PHOBIEN"], row["MOTA"].ToString(), row["HINHTHUC"].ToString(), row["ANH"].ToString());
            button5.Enabled = true;
            button5.Click += button5_Click;  
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void clearThanhToan()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");

            string sqlStatement = "DELETE FROM THANHTOAN ";

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
        private void fThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearThanhToan();
        }

        private void fThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearThanhToan();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (tongtien == 0) label4.Text = "";
            label4.Text = tongtien.ToString();
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = table1.Rows[vt];
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-CD3OO2KS;Initial Catalog=ShopAccount;Integrated Security=True");

            string sqlStatement ="DELETE FROM THANHTOAN WHERE GAMEID ='" + row["GAMEID"].ToString() + "'";

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
            tongtien = Math.Max(tongtien - Int32.Parse(row["GIA"].ToString()),0);
            label4.Text = tongtien.ToString()+" VND" ;
            LoadData1();
            if (tongtien == 0)
                button1.Enabled = false;
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fPay news = new fPay();
            this.Hide();
            news.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            label4.Show();
            fTrangChu.clearGioHang();
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            label4.Show();
            clearThanhToan();
            LoadData1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button5 = (Button)sender;
            string a = button5.Name;
            fDeTail news = new fDeTail();
            news.Show();
            
        }
    }


}
