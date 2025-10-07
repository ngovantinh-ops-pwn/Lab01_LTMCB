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
    public partial class Lab01_Bai06 : Form
    {
        Dictionary<string, (int giaVe, List<int> phongChieu)> phim = new();
        Dictionary<int, HashSet<string>> gheDaMua = new(); // Lưu ghế đã mua theo phòng
        Dictionary<int, string> veDaMuaTheoPhong = new();   // 1 người chỉ được 1 vé mỗi rạp

        public Lab01_Bai06()
        {
            InitializeComponent();
            KhoiTaoPhim();
            KhoiTaoPhong();
        }

        private void KhoiTaoPhim()
        {
            phim.Add("Đào, phở và piano", (45000, new List<int> { 1, 2, 3 }));
            phim.Add("Mai", (100000, new List<int> { 2, 3 }));
            phim.Add("Gặp lại chị bầu", (70000, new List<int> { 1 }));
            phim.Add("Tarot", (90000, new List<int> { 3 }));

            cboPhim.Items.AddRange(phim.Keys.ToArray());
        }

        private void KhoiTaoPhong()
        {
            for (int i = 1; i <= 3; i++)
            {
                gheDaMua[i] = new HashSet<string>();
            }
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();

            var phimChon = cboPhim.SelectedItem.ToString();
            var phongList = phim[phimChon].phongChieu;
            foreach (var p in phongList)
                cboPhong.Items.Add($"Phòng {p}");
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlGhe.Controls.Clear();

            int phong = int.Parse(cboPhong.Text.Split(' ')[1]);

            // Tạo nút ghế
            string[] hang = { "A", "B", "C" };
            foreach (string h in hang)
            {
                for (int i = 1; i <= 5; i++)
                {
                    string tenGhe = h + i;
                    Button btn = new Button();
                    btn.Text = tenGhe;
                    btn.Width = 60;
                    btn.Height = 40;
                    btn.Margin = new Padding(5);
                    btn.Tag = phong;
                    btn.BackColor = LayMauTheoLoaiGhe(tenGhe);

                    if (gheDaMua[phong].Contains(tenGhe))
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;
                    }

                    btn.Click += Ghe_Click;
                    pnlGhe.Controls.Add(btn);
                }
            }
        }

        private Color LayMauTheoLoaiGhe(string ghe)
        {
            if (new[] { "A1", "A5", "C1", "C5" }.Contains(ghe)) return Color.LightGreen; // Vé vớt
            if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(ghe)) return Color.LightBlue; // Vé thường
            if (new[] { "B2", "B3", "B4" }.Contains(ghe)) return Color.Gold; // Vé VIP
            return Color.White;
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int phong = (int)btn.Tag;
            string ghe = btn.Text;

            // kiểm tra nếu người này đã mua vé ở phòng này rồi
            if (veDaMuaTheoPhong.ContainsKey(phong))
            {
                MessageBox.Show($"Bạn đã mua vé ở phòng {phong} rồi!");
                return;
            }

            // kiểm tra vé đã có người khác mua
            if (gheDaMua[phong].Contains(ghe))
            {
                MessageBox.Show($"Ghế {ghe} đã được mua!");
                return;
            }

            // Ghi nhận vé đã mua
            gheDaMua[phong].Add(ghe);
            veDaMuaTheoPhong[phong] = ghe;
            btn.BackColor = Color.Gray;
            btn.Enabled = false;

            // Hiển thị thông tin vé
            string phimChon = cboPhim.Text;
            string loaiVe = LayLoaiVe(ghe);
            int giaCoBan = phim[phimChon].giaVe;
            double heSo = LayHeSoTheoLoai(loaiVe);
            double thanhTien = giaCoBan * heSo;

            string tenKH = txtTenKH.Text.Trim();
            if (tenKH == "")
                tenKH = "Khách vãng lai";

            txtThongTin.AppendText($"Khách: {tenKH}\r\n" +
                                   $"Phim: {phimChon}\r\n" +
                                   $"Phòng: {phong}\r\n" +
                                   $"Ghế: {ghe} ({loaiVe})\r\n" +
                                   $"Giá vé: {thanhTien:N0}đ\r\n" +
                                   $"-----------------------------\r\n");
        }

        private string LayLoaiVe(string ghe)
        {
            if (new[] { "A1", "A5", "C1", "C5" }.Contains(ghe)) return "Vé vớt";
            if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(ghe)) return "Vé thường";
            if (new[] { "B2", "B3", "B4" }.Contains(ghe)) return "Vé VIP";
            return "Không xác định";
        }

        private double LayHeSoTheoLoai(string loai)
        {
            return loai switch
            {
                "Vé vớt" => 0.25,
                "Vé thường" => 1.0,
                "Vé VIP" => 2.0,
                _ => 1.0
            };
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
