using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Button1_click(object sender, EventArgs e)
        {
            Lbi_Tinhtientaxi1.Taxi taxi = new Lbi_Tinhtientaxi1.Taxi();

            taxi.GiaMoCua = 9000;

            double quangDuong;
            bool isValidQuangDuong = double.TryParse(TextBox2.Text, out quangDuong);

            double giaMoiKm;
            bool isValidGiaMoiKm = double.TryParse(TextBox1.Text, out giaMoiKm);

            if (isValidQuangDuong && isValidGiaMoiKm && quangDuong > 0 && giaMoiKm > 0)
            {
                taxi.QuangDuong = quangDuong;
                taxi.GiaMoiKm = giaMoiKm;

                double tongTien = taxi.TinhTien();
                ketqua_web.InnerHtml = $"Tổng tiền taxi: {tongTien.ToString("0.00")} VND";
            }
            else
            {
                ketqua_web.InnerHtml = "Lỗi: Vui lòng nhập số dương cho quãng đường và giá mỗi km.";
            }
        }
    }
}