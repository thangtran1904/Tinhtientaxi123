using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp444.Tinhtientaxi;

namespace ConsoleApp444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Phần mềm tính tiền taxi");

            Taxi taxi = new Taxi();

            taxi.GiaMoCua = 9000;

            Console.Write("Nhập quãng đường (đơn vị km): ");
            double quangDuong;
            bool isValidQuangDuong = double.TryParse(Console.ReadLine(), out quangDuong);

            Console.Write("Nhập giá mỗi km: ");
            double giaMoiKm;
            bool isValidGiaMoiKm = double.TryParse(Console.ReadLine(), out giaMoiKm);

            if (isValidQuangDuong && isValidGiaMoiKm && quangDuong > 0 && giaMoiKm > 0)
            {
                taxi.QuangDuong = quangDuong;
                taxi.GiaMoiKm = giaMoiKm;

                double tongTien = taxi.TinhTien();
                Console.WriteLine("Tổng tiền taxi: " + tongTien.ToString("0.00") + " VND");
            }
            else
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số dương cho quãng đường và giá mỗi km.");
            }

            Console.ReadKey();

        }
    }
}
