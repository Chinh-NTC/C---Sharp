using System;
using System.Text;

namespace BaiTap
{
    class Bai9
    {
        public static void run()
        {
            Console.WriteLine("Bai 9");
            Console.Write("Số chuỗi muốn nhập: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Lỗi.Số lượng không hợp lệ!");
                return;
            }
            string[] danhSach = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập chuỗi thứ {i + 1}: ");
                danhSach[i] = Console.ReadLine();
            }
            int dem = 0;
            Console.WriteLine("\n--- Ket qua kiem tra ---");

            for (int i = 0; i < n; i++)
            {
                if (!string.IsNullOrWhiteSpace(danhSach[i]))
                {
                    dem++;
                    Console.WriteLine($"Phần tử [{i}]: '{danhSach[i]}' -> Hợp lệ");
                }
                else
                    Console.WriteLine($"Phần tử [{i}]: (Trống hoặc Null) -> Loại");
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"=> Tổng số chuỗi hợp lệ là: {dem}/{n}");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}