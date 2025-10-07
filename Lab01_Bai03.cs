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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            string input = txtSo.Text.Trim();

            if (string.IsNullOrEmpty(input) || !ulong.TryParse(input, out ulong so))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ (tối đa 12 chữ số)!");
                return;
            }

            if (input.Length > 12)
            {
                MessageBox.Show("Số quá lớn! Chỉ đọc được tối đa 12 chữ số (đến nghìn tỷ).");
                return;
            }

            string ketQua = DocSoTiengViet(so);
            txtKetQua.Text = ketQua;
        }

        private string[] hangDonVi = { "", "nghìn", "triệu", "tỷ" };
        private string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private string DocSoTiengViet(ulong so)
        {
            if (so == 0) return "Không";

            StringBuilder sb = new StringBuilder();
            int nhom = 0;

            while (so > 0)
            {
                int baChuSo = (int)(so % 1000);
                so /= 1000;

                if (baChuSo > 0)
                {
                    string docNhom = DocBaChuSo(baChuSo);
                    if (nhom > 0)
                        sb.Insert(0, $"{docNhom} {hangDonVi[nhom]}, ");
                    else
                        sb.Insert(0, $"{docNhom} ");
                }
                nhom++;
            }

            string ketQua = sb.ToString().Trim();
            // Viết hoa chữ cái đầu
            return char.ToUpper(ketQua[0]) + ketQua.Substring(1);
        }

        private string DocBaChuSo(int n)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donvi = n % 10;
            StringBuilder s = new StringBuilder();

            if (tram > 0)
            {
                s.Append($"{chuSo[tram]} trăm");
                if (chuc == 0 && donvi > 0)
                    s.Append(" linh");
            }

            if (chuc > 0 && chuc != 1)
            {
                s.Append($" {chuSo[chuc]} mươi");
                if (donvi == 1) s.Append(" mốt");
                else if (donvi == 5) s.Append(" lăm");
                else if (donvi > 0) s.Append($" {chuSo[donvi]}");
            }
            else if (chuc == 1)
            {
                s.Append(" mười");
                if (donvi == 1) s.Append(" một");
                else if (donvi == 5) s.Append(" lăm");
                else if (donvi > 0) s.Append($" {chuSo[donvi]}");
            }
            else if (chuc == 0 && donvi > 0)
            {
                s.Append($" {chuSo[donvi]}");
            }

            return s.ToString().Trim();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            txtKetQua.Clear();
            txtSo.Focus();
        }
    }
}
