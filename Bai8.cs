using System;
using System.Text;

namespace BaiTap
{
    class Bai8
    {
        public static void run()
        {
            Console.WriteLine("Bai 8");
            Console.Write("Nhap cau: ");
            string input = Console.ReadLine();

            if (input == null)
                Console.WriteLine("Thông báo: Chuỗi bị null, không thể xử lý!");
            else
            {
                string[] dsTu = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (dsTu.Length == 0)
                    Console.WriteLine("Thông báo: Chuỗi rỗng hoặc chỉ toàn dấu cách!");
                else
                {
                    string tuDaiNhat = dsTu[0];

                    for (int i = 1; i < dsTu.Length; i++)
                        if (dsTu[i].Length > tuDaiNhat.Length)
                            tuDaiNhat = dsTu[i]; 
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Từ dài nhất trong câu là: {tuDaiNhat}");
                    Console.WriteLine("---------------------------------------");
                }
            }
            Console.ReadKey();
        }
    }
}