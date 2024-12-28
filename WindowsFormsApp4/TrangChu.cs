using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với Trang Chủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnQLKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Quản lý khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var KhachHang = new KhachHang();
            KhachHang.Show();

        }

        private void btnQLDU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Quản lý đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var DoUong = new DoUong();
            DoUong.Show();


        }


        private void btnCTUD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Quản lý CTUD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var CTUD = new CTUD();
            CTUD.Show();

        }


    }
}
