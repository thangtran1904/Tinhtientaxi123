using System;
using System.Text;

namespace ConsoleApp222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bài toán : Phần mềm tính tiền taxi
            // giải thuật:
            //input : quãng đường = s,giá mỗi km =a,giá mở cửa b
            //output : thành tiền q or báo lỗi
            // thuật toán 
            // 1 kiểm tra quãng đường với giá tiền phải là số dương
            // thỏa mãn qua b2
            // 2. áp dụng công thức q = b + (s*a)
            // output là q
            // 3. output là báo lỗi
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Phần mềm tính tiền taxi -ConsoleApp222");

            double giaMoCua = 9000;

            Console.Write("Nhập quãng đường (đơn vị km): ");
            double quangDuong;
            bool isValidQuangDuong = double.TryParse(Console.ReadLine(), out quangDuong);

            Console.Write("Nhập giá mỗi km: ");
            double giaMoiKm;
            bool isValidGiaMoiKm = double.TryParse(Console.ReadLine(), out giaMoiKm);

            if (isValidQuangDuong && isValidGiaMoiKm && quangDuong > 0 && giaMoiKm > 0)
            {
                double thanhTien = giaMoCua + (quangDuong * giaMoiKm);
                Console.WriteLine("Tổng tiền taxi: " + thanhTien.ToString("0.00") + " VND");
            }
            else
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số dương cho quãng đường và giá mỗi km.");
            }

            Console.ReadKey();
        }
    }
}
