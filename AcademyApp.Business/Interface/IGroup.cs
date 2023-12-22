using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademyApp.Business.Interface
{
    public interface IGroup
    {
        List<Group> GetAll();
        List<Group> GetAll(int size);
        Group Get(int id);
        Group Get(string  name);
        Group Creat(Group group, string groupName);
        Group Update(int id, Group group,string groupName);
        Group Delete(int id);

    }
}
