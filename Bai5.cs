using System;
using System.Text;

namespace BaiTap
{
    class Bai5
    {
        public static void run()
        {
            Console.WriteLine("Bai 5");
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] ds = new int[n];

            int i, max;
            for(i=0; i< n; i++)
            {
                Console.Write("Nhap so phan tu thu {0}: ", (i + 1));
                ds[i] = int.Parse(Console.ReadLine());
            }

            max = ds[0];
            for(i=0; i<n; i++)
                if(ds[i] > max)
                    max = ds[i];
            Console.WriteLine("Phan tu lon nhat trong mang la: "+max);

            Console.ReadKey();
        }
    }
}