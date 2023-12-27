using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Interface
{
    public interface IStudent
    {
        List<Student> GetAll();
        List<Student> GetAll(string name);
        List<Student> GetAll(int age);
        Student Get(int id);
        Student Delete(int id);
        Student Update(int id,Student student,string groupName);
        Student Create(Student student, string groupName);
    }
}
