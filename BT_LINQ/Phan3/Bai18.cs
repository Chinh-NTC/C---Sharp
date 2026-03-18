using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tên Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace BT_LINQ_Bai18
{
    internal class Bai18
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

            var students_groupBy = students.GroupBy(n => { if (n.Score >= 8) return "Giỏi"; 
                                                           else if (n.Score >= 6) return "Khá"; 
                                                           else return "Trung Bình"; });
            Console.WriteLine("\nBài 18: ");
            Console.WriteLine("DANH SÁCH NHÓM SINH VIÊN THEO XẾP LOẠI: ");
            foreach(var nhom in students_groupBy)
            {
                Console.WriteLine("Nhóm "+nhom.Key);

                foreach(var sv in nhom)
                {
                    Console.WriteLine($"ID: {sv.Id} | Tên: {sv.Name} | Điểm: {sv.Score}");
                }    
            }    

            Console.ReadKey();
        }
    }
}
