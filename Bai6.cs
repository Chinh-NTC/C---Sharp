using System;
using System.Text;

namespace BaiTap
{
    class Bai6
    {
        public static void run()
        {
            Console.WriteLine("Bai 6");
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] ds = new int[n];
            int i;
            for(i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", (i + 1));
                ds[i] = int.Parse(Console.ReadLine());
            }

            int dem = 0;
            for(i=0; i<n; i++)
                if (ds[i] % 2 == 0)
                    dem++;

            Console.WriteLine("So phan tu chan trong mang la: "+dem);
            Console.ReadKey();
        }
    }
}