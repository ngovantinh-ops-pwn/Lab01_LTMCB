using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c;

            try
            {
                a = double.Parse(txtSo1.Text.Trim());
                b = double.Parse(txtSo2.Text.Trim());
                c = double.Parse(txtSo3.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ (có thể là số thực)!",
                                "Lỗi nhập liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            double max = a, min = a;

            if (b > max) max = b;
            if (c > max) max = c;

            if (b < min) min = b;
            if (c < min) min = c;

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnXoa_Click_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox
            txtSo1.Clear();
            txtSo2.Clear();
            txtSo3.Clear();
            txtMax.Clear();
            txtMin.Clear();

            // Đưa con trỏ về ô nhập đầu tiên
            txtSo1.Focus();
        }
    }
}
