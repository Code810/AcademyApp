using AcademyApp.Business.Interface;
using AcademyApp.DataContext.Repositories;
using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Servicess
{
    public class GroupService : IGroup
    {
        private readonly GroupRepository groupRepository;
        private static int count = 1;
        public GroupService()
        {
            groupRepository = new ();
        }
        public Group Creat(Group group)
        {
            group.Id = count;
           var result= groupRepository.Creat(group);
            if (result)
            {
                count++;
                return group;
            }
            else
            {
                return null;
            }
            
        }

        public List<Group> GetAll()
        {
            return groupRepository.GetAll();
        }




        public Group Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public Group Get(string name)
        {
            throw new NotImplementedException();
        }

        

        public List<Group> GetAll(int size)
        {
            throw new NotImplementedException();
        }

        public Group Update(int id, Group group, string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
