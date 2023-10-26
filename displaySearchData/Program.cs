using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displaySearchData
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string filePath = "students.txt";

            // Read data from the file
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length == 2)
                {
                    students.Add(new Student
                    {
                        Name = data[0].Trim(),
                        Class = data[1].Trim()
                    });
                }
            }

            Console.WriteLine("Student data retrieved and unsorted:");
            DisplayStudents(students);

            // Sort students by name
            students = students.OrderBy(s => s.Name).ToList();
            Console.WriteLine("\nStudent data sorted by name:");
            DisplayStudents(students);

            // Search for a student by name
            Console.Write("\nEnter a student name to search: ");
            string searchName = Console.ReadLine();
            var foundStudents = students.FindAll(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (foundStudents.Count > 0)
            {
                Console.WriteLine("Student(s) found:");
                DisplayStudents(foundStudents);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            Console.ReadLine();
        }

        static void DisplayStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
            }
            Console.ReadLine();
        }
    }
}
    





   
  



        //Console.ReadLine();

        
    

        