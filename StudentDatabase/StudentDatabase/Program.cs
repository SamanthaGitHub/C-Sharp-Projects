using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Console.WriteLine("Enter student's name:\n");
                var name = Console.ReadLine();
                var student = new Student();
                student.StudentName = name;
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public Grade Grade { get; set; }
        
    }

    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public virtual List<Student> Students { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
