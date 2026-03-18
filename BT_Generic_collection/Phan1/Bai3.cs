using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Generic_Bai3
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSachSo = new List<int>();

            Console.WriteLine("Bài 3:");
            // 1. Nhập các số nguyên (Ví dụ nhập 5 số từ bàn phím)
            Console.WriteLine("Nhập vào 5 số nguyên:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                int n = int.Parse(Console.ReadLine());
                danhSachSo.Add(n);
            }

            // 2. Tìm số lớn nhất trong List
            int max = danhSachSo.Max();

            Console.WriteLine("Số lớn nhất trong List là: " + max);
            Console.ReadKey();
        }
    }
}
