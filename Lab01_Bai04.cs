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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtpNgaySinh.Value;
            int d = ngaySinh.Day;
            int m = ngaySinh.Month;



            string zodiac = XacDinhCung(d, m);

            txtKetQua.Text = $"Ngày sinh: {ngaySinh:dd/MM/yyyy}\r\n" +
                             $"Cung hoàng đạo: {zodiac}";
        }

        private string XacDinhCung(int day, int month)
        {
            switch (month)
            {
                case 1:
                    return (day >= 21) ? "Bảo Bình" : "Ma Kết";
                case 2:
                    return (day >= 20) ? "Song Ngư" : "Bảo Bình";
                case 3:
                    return (day >= 21) ? "Bạch Dương" : "Song Ngư";
                case 4:
                    return (day >= 21) ? "Kim Ngưu" : "Bạch Dương";
                case 5:
                    return (day >= 22) ? "Song Tử" : "Kim Ngưu";
                case 6:
                    return (day >= 22) ? "Cự Giải" : "Song Tử";
                case 7:
                    return (day >= 23) ? "Sư Tử" : "Cự Giải";
                case 8:
                    return (day >= 23) ? "Xử Nữ" : "Sư Tử";
                case 9:
                    return (day >= 24) ? "Thiên Bình" : "Xử Nữ";
                case 10:
                    return (day >= 24) ? "Thần Nông" : "Thiên Bình";
                case 11:
                    return (day >= 23) ? "Nhân Mã" : "Thần Nông";
                case 12:
                    return (day >= 22) ? "Ma Kết" : "Nhân Mã";
                default:
                    return "Không xác định";
            }
        }
    }
}
