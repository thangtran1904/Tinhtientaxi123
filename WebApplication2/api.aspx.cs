using System;
using System.Web.UI;

namespace WebApplication2
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string kq = "";
            try
            {
                double GiaMoiKm = double.Parse(this.Request.Form["GiaMoiKm"]);
                double QuangDuong = double.Parse(this.Request.Form["QuangDuong"]);

                Lbi_Tinhtientaxi1.Taxi taxi = new Lbi_Tinhtientaxi1.Taxi();
                taxi.GiaMoCua = 9000;
                taxi.GiaMoiKm = GiaMoiKm;
                taxi.QuangDuong = QuangDuong;

                double tongTien = taxi.TinhTien();
                kq = $"Tổng tiền taxi: {tongTien.ToString("0.00")} VND";
            }
            catch (Exception ex)
            {
                kq = $"Lỗi: {ex.Message}";
            }
            finally
            {
                this.Response.ContentType = "text/plain";
                this.Response.Write(kq);
            }
        }
    }
}
