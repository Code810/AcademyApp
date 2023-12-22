using AcademyApp.DataContext.Interface;
using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Creat(Student entity)
        {
            try
            {
                DbContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                DbContext.Students.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student Get(Predicate<Student> filter)
        {
            return DbContext.Students.Find(filter);

        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            return filter is null ? DbContext.Students : DbContext.Students.FindAll(filter);
        }

        public bool Update(Student entity)
        {
            try
            {
                var existStudent = Get(u => u.Id == entity.Id);
                existStudent = entity;
                return true; 

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
