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
    public partial class Lab01_Bai08 : Form
    {
        // Danh sách món ăn
        List<string> monAn = new List<string>()
        {
            "Phở bò",
            "Bún chả",
            "Cơm tấm",
            "Hủ tiếu",
            "Bánh mì",
            "Lẩu Thái",
            "Gà rán"
        };

        Random rd = new Random();

        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }

        private void CapNhatDanhSach()
        {
            lstMonAn.Items.Clear();
            foreach (var m in monAn)
                lstMonAn.Items.Add(m);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monMoi = txtMonMoi.Text.Trim();
            if (!string.IsNullOrEmpty(monMoi))
            {
                monAn.Add(monMoi);
                CapNhatDanhSach();
                txtMonMoi.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
            }
        }

        private void btnAnGi_Click(object sender, EventArgs e)
        {
            if (monAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống!");
                return;
            }

            int index = rd.Next(monAn.Count);
            string monChon = monAn[index];
            lblKetQua.Text = $"Hôm nay ăn: {monChon}";
        }


    }
}
