using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp444
{
    internal class Tinhtientaxi
    {
        public class Taxi
        {
            public double GiaMoCua { get; set; }
            public double GiaMoiKm { get; set; }
            public double QuangDuong { get; set; }
            public double TinhTien()
            {
                return GiaMoCua + (QuangDuong * GiaMoiKm);
            }
        }
    }
}
