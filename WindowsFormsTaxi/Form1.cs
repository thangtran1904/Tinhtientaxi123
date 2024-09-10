using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTaxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbi_Tinhtientaxi1.Taxi taxi = new Lbi_Tinhtientaxi1.Taxi();

            taxi.GiaMoCua = 9000;

            double quangDuong;
            bool isValidQuangDuong = double.TryParse(quangduong.Text, out quangDuong);

            double giaMoiKm;
            bool isValidGiaMoiKm = double.TryParse(giatien.Text, out giaMoiKm);

            if (isValidQuangDuong && isValidGiaMoiKm && quangDuong > 0 && giaMoiKm > 0)
            {
                taxi.QuangDuong = quangDuong;
                taxi.GiaMoiKm = giaMoiKm;

                double tongTien = taxi.TinhTien();
                text_kq.Text = $"Tổng tiền taxi: {tongTien.ToString("0.00")} VND";
            }
            else
            {
                text_kq.Text = "Lỗi: Vui lòng nhập số dương cho quãng đường và giá mỗi km.";
            }
        }
    }
}
