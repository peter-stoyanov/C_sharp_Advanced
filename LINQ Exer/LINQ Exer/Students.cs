using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQ_Exer
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FN { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
        public List<int> Grades { get; set; }
    }

    class Students
    {
        static void Main(string[] args)
        {
            string filepath = @"StudentData.txt";

            var students = ReadStudents(filepath);

            var studentsGroup2 = students.Where(s => s.Group == 2).OrderBy(s => s.FirstName).ToList();

            foreach (var student in studentsGroup2)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        public static List<Student> ReadStudents(string filepath)
        {
            //FN	First name	Last Name	Email	Age	Group	Grade1	Grade2	Grade3	Grade4	Phones
            var students = new List<Student>();

            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines.Skip(1))
            {
                var tokens = line
                   .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

                students.Add(new Student()
                {
                    FN = tokens[0],
                    FirstName = tokens[1],
                    LastName = tokens[2],
                    Email = tokens[3],
                    Age = int.Parse(tokens[4]),
                    Group = int.Parse(tokens[5]),
                    Grades = new List<int>()
                    {
                        int.Parse(tokens[6]),
                        int.Parse(tokens[7]),
                        int.Parse(tokens[8]),
                        int.Parse(tokens[9])
                    },
                     Phone = tokens[10]
                });

            }

            return students;
        }
    }
}
