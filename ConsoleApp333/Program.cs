using System;
using System.Text;

namespace ConsoleApp333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập mã hóa đầu vào và đầu ra
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Phần mềm tính tiền taxi -ConsoleApp333");

            double giaMoCua = 9000;

            Console.Write("Nhập quãng đường (đơn vị km): ");
            double quangDuong;
            bool isValidQuangDuong = double.TryParse(Console.ReadLine(), out quangDuong);

            Console.Write("Nhập giá mỗi km: ");
            double giaMoiKm;
            bool isValidGiaMoiKm = double.TryParse(Console.ReadLine(), out giaMoiKm);

            if (isValidQuangDuong && isValidGiaMoiKm && quangDuong > 0 && giaMoiKm > 0)
            {
                double thanhTien = TinhTienTaxi(giaMoCua, quangDuong, giaMoiKm);
                Console.WriteLine("Tổng tiền taxi: " + thanhTien.ToString("0.00") + " VND");
            }
            else
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số dương cho quãng đường và giá mỗi km.");
            }

            Console.ReadKey();
        }

        static double TinhTienTaxi(double giaMoCua, double quangDuong, double giaMoiKm)
        {
            return giaMoCua + (quangDuong * giaMoiKm);
        }
    }
}
