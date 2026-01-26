using System;
using System.Text;

namespace BaiTap
{
    class Bai4
    {
        public static void run()
        {
            Console.WriteLine("Bai 4");
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] ds = new int[n];
            int i;
            for(i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", (i + 1));
                ds[i] = int.Parse(Console.ReadLine());
            }    

            int tg = 0;
            for (i = 0; i < n; i++)
                tg = tg + ds[i];

            Console.WriteLine("Tong cac phan tu trong mang la: " + tg);
            Console.ReadKey();
        }
    }
}