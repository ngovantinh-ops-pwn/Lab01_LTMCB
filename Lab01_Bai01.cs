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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int so1, so2;

            // Kiểm tra nhập số nguyên
            bool check1 = Int32.TryParse(txtSo1.Text.Trim(), out so1);
            bool check2 = Int32.TryParse(txtSo2.Text.Trim(), out so2);

            if (!check1 || !check2)
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên!",
                                "Lỗi nhập liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int tong = so1 + so2;
            txtKetQua.Text = tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form bài 1
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
