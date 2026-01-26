using System;
using System.Text;

namespace BaiTap
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Mời nhập một câu bất kỳ: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Số từ là: 0");
            }
            else
            {
                string[] cacTu = input.Split(' ');

                int dem = 0;

                for (int i = 0; i < cacTu.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(cacTu[i]))
                    dem++;
                }
                Console.WriteLine("--------------------------");
                Console.WriteLine("Chuỗi bạn nhập: " + input);
                Console.WriteLine("Tổng số từ đếm được: " + dem);
            }

            Console.ReadKey();
        }
    }
}