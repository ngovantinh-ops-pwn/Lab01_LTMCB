using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int A, B;
            if (!int.TryParse(txtA.Text.Trim(), out A) || !int.TryParse(txtB.Text.Trim(), out B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            string kq = "";

            int start = Math.Min(A, B);
            int end = Math.Max(A, B);

            kq += $"📌 Bảng cửu chương từ {start} đến {end}:\r\n";
            for (int i = start; i <= end; i++)
            {
                kq += $"--- Bảng {i} ---\r\n";
                for (int j = 1; j <= 9; j++)
                {
                    kq += $"{i} x {j} = {i * j}\r\n";
                }
                kq += "\r\n";
            }




            // 2. (A – B)!
            int hieu = A - B;
            if (hieu < 0)
            {
                kq += $"(A - B)! không xác định vì {A} - {B} < 0\r\n";
            }
            else
            {
                BigInteger gt = GiaiThua(hieu);
                kq += $"(A - B)! = {gt}\r\n";
            }

            // 3. Tổng S = A^1 + A^2 + ... + A^B
            BigInteger tong = 0;
            for (int i = 1; i <= B; i++)
            {
                tong += BigInteger.Pow(A, i);
            }
            kq += $"Tổng S = A^1 + ... + A^B = {tong}\r\n";

            txtKetQua.Text = kq;
        }

        private BigInteger GiaiThua(int n)
        {
            BigInteger kq = 1;
            for (int i = 2; i <= n; i++)
                kq *= i;
            return kq;
        }
    }
}
