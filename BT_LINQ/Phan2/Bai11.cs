using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_Bai11
{
    internal class Bai11
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Score { get; set; }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> students = new List<Student>()
            {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Bình", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dũng", Score = 7 }
            };

            Console.WriteLine("=== DANH SÁCH TẤT CẢ SINH VIÊN ===");
            foreach (var sv in students)
            {
                Console.WriteLine($"ID: {sv.Id} | Tên: {sv.Name} | Điểm: {sv.Score}");
            }

            var students_Max = students.OrderByDescending(x => x.Score).FirstOrDefault();
            Console.WriteLine("\nBài 11: ");
            if(students_Max != null)
            {
                Console.WriteLine("SINH VIÊN CÓ ĐIỂM CAO NHẤT: ");
                Console.WriteLine($"ID: {students_Max.Id} | Tên: {students_Max.Name} | Điểm: {students_Max.Score}");
            }    

            Console.ReadKey();
        }
    }
}
