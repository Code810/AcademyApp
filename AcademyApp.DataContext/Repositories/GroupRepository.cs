using AcademyApp.DataContext.Interface;
using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Creat(Group entity)
        {
            try
            {
                DbContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group entity)
        {
            try
            {
                DbContext.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group Get(Predicate<Group> filter)
        {
            return DbContext.Groups.Find(filter);

        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            return filter is null ? DbContext.Groups : DbContext.Groups.FindAll(filter);
        }

        public bool Update(Group entity)
        {
            try
            {
                var existGroup = Get(u => u.Id == entity.Id);
                existGroup = entity;
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
