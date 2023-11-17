using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bansach
{
    public partial class donhang : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7T8I7HD\SQLEXPRESS;Initial Catalog=bansach;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        public donhang()
        {
            
            InitializeComponent();
            connection.Open();
        }
        void LoadcomboBox()
        {
            var cmd = new SqlCommand("Select * from sach3", connection);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox2.ValueMember = dt.Columns[0].ToString();
            comboBox2.DisplayMember = dt.Columns[1].ToString();
            comboBox2.DataSource = dt;
            comboBox2.Text="";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox1.Text != "" && textBox5.Text != "")
            {
                try
                {
                    int soluong = Convert.ToInt32(textBox1.Text);
                    try
                    {
                        int gia = Convert.ToInt32(textBox5.Text);
                        for (int i = 0; i < dataGridView1.Rows.Count -1; i++)
                        {
                            if (dataGridView1[1, i].Value.ToString() == comboBox2.Text)
                            {
                                if (Convert.ToInt32(dataGridView1[5, i].Value) - Convert.ToInt32(textBox1.Text) >= 0)
                                {
                                    int thanhtien = Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox1.Text);
                                    dataGridView2.Rows.Add(dataGridView1[1, i].Value, textBox1.Text, thanhtien.ToString(), dateTimePicker1.Value);
                                    dataGridView1[5, i].Value = Convert.ToInt32(dataGridView1[5, i].Value) - Convert.ToInt32(textBox1.Text);
                                    dataGridView1[7, i].Value = Convert.ToInt32(dataGridView1[7, i].Value) + Convert.ToInt32(textBox1.Text);
                                }
                                else
                                {
                                    MessageBox.Show("Sách không đủ");
                                }
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nhập sai dữ liệu");
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Nhập sai dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin");
            }    
        }

        private void donhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bansachDataSet11.sach3' table. You can move, or remove it, as needed.
            this.sach3TableAdapter.Fill(this.bansachDataSet11.sach3);
            LoadcomboBox();
        }

        private void donhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int i = 0;
                string constring = @"Data Source=DESKTOP-7T8I7HD\SQLEXPRESS;Initial Catalog=bansach;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("insert into hoadon3 (tensach, soluong, thanhtien, ngaylap) values (@tensach, @soluong, @thanhtien, @ngaylap)" , con))
                    {
                        string tensachValue = row.Cells["tensach"].Value?.ToString() ?? "";
                        string soluongValue = row.Cells["soluong"].Value?.ToString() ?? "";
                        string thanhtienValue = row.Cells["thanhtien"].Value?.ToString() ?? "";
                        string ngaylapValue = row.Cells["ngaylap"].Value?.ToString() ?? "";

                        
                        cmd.Parameters.AddWithValue("@tensach", tensachValue);
                        cmd.Parameters.AddWithValue("@soluong", soluongValue);
                        cmd.Parameters.AddWithValue("@thanhtien", thanhtienValue);
                        cmd.Parameters.AddWithValue("@ngaylap", ngaylapValue);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }
    }
}
