using Lbi_Tinhtientaxi1;
using Newtonsoft.Json;
using System;
using System.Web.UI;

namespace WebApplication3
{
    public partial class api : System.Web.UI.Page
    {
        class PhanHoi
        {
            public bool ok;
            public string msg;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string kq = "";
            PhanHoi p= new PhanHoi();
            try
            {
                double GiaMoiKm = double.Parse(this.Request.Form["GiaMoiKm"]);
                double QuangDuong = double.Parse(this.Request.Form["QuangDuong"]);

                Lbi_Tinhtientaxi1.Taxi taxi = new Lbi_Tinhtientaxi1.Taxi();
                taxi.GiaMoCua = 9000;
                taxi.GiaMoiKm = GiaMoiKm;
                taxi.QuangDuong = QuangDuong;

                double tongTien = taxi.TinhTien();
                kq = "$Tổng tiền taxi: {tongTien.ToString("0.00")} VND";
            }
            p.ok = Taxi.ok;
            p.msg = kq;
            catch (Exception ex)
            {
                kq = $"Lỗi: {ex.Message}";
                p.ok = false;
                p.msg = kq;
            }
            finally
            {
                string json = JsonConvert.SerializeObject(p);
                this.Response.ContentType = "text/plain";
                this.Response.Write(json);
            }
        }
    }
}
