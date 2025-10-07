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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }

            // Tách các phần tử theo dấu phẩy
            string[] parts = input.Split(',');

            if (parts.Length < 2)
            {
                MessageBox.Show("Sai format! Phải có họ tên + ít nhất 1 điểm.");
                return;
            }

            string hoTen = parts[0].Trim();

            // Chuyển điểm từ string sang double
            double[] diem;
            try
            {
                diem = parts.Skip(1).Select(p => double.Parse(p.Trim())).ToArray();
            }
            catch
            {
                MessageBox.Show("Sai format! Điểm phải là số.");
                return;
            }

            // Xuất kết quả
            string kq = "";
            kq += $"Họ và tên: {hoTen}\r\n";

            for (int i = 0; i < diem.Length; i++)
                kq += $"Môn {i + 1}: {diem[i]}\r\n";

            // Điểm trung bình
            double dtb = diem.Average();
            kq += $"\r\nĐiểm trung bình: {dtb:F2}\r\n";

            // Môn cao nhất, thấp nhất
            double max = diem.Max();
            double min = diem.Min();
            kq += $"Điểm cao nhất: {max} (Môn {Array.IndexOf(diem, max) + 1})\r\n";
            kq += $"Điểm thấp nhất: {min} (Môn {Array.IndexOf(diem, min) + 1})\r\n";

            // Số môn đậu (>=5) và rớt
            int dau = diem.Count(d => d >= 5);
            int rot = diem.Length - dau;
            kq += $"Số môn đậu: {dau}, Số môn rớt: {rot}\r\n";

            // Xếp loại
            string xeploai = XepLoai(diem, dtb);
            kq += $"Xếp loại: {xeploai}\r\n";

            txtKetQua.Text = kq;
        }

        private string XepLoai(double[] diem, double dtb)
        {
            if (dtb >= 8 && diem.All(d => d >= 6.5)) return "Giỏi";
            if (dtb >= 6.5 && diem.All(d => d >= 5)) return "Khá";
            if (dtb >= 5 && diem.All(d => d >= 3.5)) return "Trung bình";
            if (dtb >= 3.5 && diem.All(d => d >= 2)) return "Yếu";
            return "Kém";
        }
    }
}
