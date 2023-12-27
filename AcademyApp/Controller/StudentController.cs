using AcademyApp.Business.Servicess;
using AcademyApp.Domain.Models;
using AcademyApp.Helpers;
using System.Runtime.InteropServices;

namespace AcademyApp.Controller
{
    internal class StudentController
    {
        private readonly StudentService studentService;
        public StudentController()
        {
            studentService= new ();
        }
        public void CreatStudent()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student name");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Surname");
            string surname = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Group Name");
            string groupName = Console.ReadLine();
            Student newstudent = new();
            newstudent.Name = name;
            newstudent.Surname = surname;
            if (studentService.Create(newstudent, groupName) is null)
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Green, "Telebe  yaradildi");
            }
        }

        public void GetAllStudent()
        {
            var students = studentService.GetAll();
            
            if (students.Count > 0)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, "Student List");
                foreach (var item in students)
                {
                    Console.WriteLine($"Id:{item.Id} FullName:{item.Name}{item.Surname} Group:{item.Group.Name}");
                }
            }
            else Helper.ChangeTextColor(ConsoleColor.Red, "Empty List");

        }
        public void GetAllStudentsWithName()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student name");
            string name = Console.ReadLine();
            var students = studentService.GetAll(name);

            if (students.Count > 0)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, "Student List");
                foreach (var item in students)
                {
                    Console.WriteLine($"Id:{item.Id} FullName:{item.Name}{item.Surname} Group:{item.Group.Name}");
                }
            }
            else Helper.ChangeTextColor(ConsoleColor.Red, "Empty List");
            
        }

        public void GetStudentById()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Id");
            string id = Console.ReadLine();
            bool result = int.TryParse(id, out int intId);
            if (result)
            {
                var stu = studentService.Get(intId);
                if (stu is not null)
                {
                    Console.WriteLine($"Id:{stu.Id} FullName:{stu.Name}{stu.Surname} Group:{stu.Group.Name}");
                }
                else Helper.ChangeTextColor(ConsoleColor.Red, "Somthing went wrong"); 


            }
            else Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun daxil et");
        }

        public void UpdateStudent()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student id");
            string studentId = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student name");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Surname");
            string surname = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Group Name");
            string groupName = Console.ReadLine();
            bool result = int.TryParse(studentId, out int intId);
            if (result)
            {
                Student newstudent = new();
                newstudent.Name = name;
                newstudent.Surname = surname;
                if (studentService.Update(intId, newstudent, groupName) is null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Telebe  yaradildi");
                }
            }
            
        }
        public void DeleteStudent()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Id");
            string id = Console.ReadLine();
            bool result = int.TryParse(id, out int intId);
            if (result)
            {
                if (studentService.Delete(intId) is not null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Student Deleted ");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
                }
            }
        }
    }
}
