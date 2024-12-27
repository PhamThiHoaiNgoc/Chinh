﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN
{
    public partial class Ngoc : Form
    {
        string sCon = "Data Source=ADMIN-PC;Initial Catalog=Banhang;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Ngoc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sQuery = "select * from khachhang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];

            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            string sMaKH = txtMaKH.Text;
            string sTenKH= txtTenKH.Text;
            string sSDT= txtSDT.Text;
            string sMaUD= txtMaUD.Text;

            string sQuery = "insert into khachhang values(@makh, @tenkh, @sdt, @maud)";
            SqlCommand cmd= new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@sdt", sSDT);
            cmd.Parameters.AddWithValue("@maud", sMaUD);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới");
            }
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtMaUD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaUuDai"].Value.ToString();
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSDT = txtSDT.Text;
            string sMaUD = txtMaUD.Text;

            string sQuery = "update khachhang set TenKhachHang=@tenkh, SDT=@sdt, MaUuDai=@maud "
                + "where MaKhachHang=@makh";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@sdt", sSDT);
            cmd.Parameters.AddWithValue("@maud", sMaUD);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật");
            }
            con.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                }

                string sMaKH = txtMaKH.Text;
                string sQuery = "delete khachhang where MaKhachHang=@makh";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@makh", sMaKH);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xoá");
                }
                con.Close();
            }


        }
    }
}
