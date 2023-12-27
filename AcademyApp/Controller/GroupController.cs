using AcademyApp.Business.Interface;
using AcademyApp.Business.Servicess;
using AcademyApp.Domain.Models;
using AcademyApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AcademyApp.Controller
{
    internal class GroupController
    {
        private readonly GroupService groupService;
        public GroupController()
        {
                groupService = new ();
        }
        public void CreatGroup()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter group name");
            string groupname = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter group size");
            string size = Console.ReadLine();
            bool result = int.TryParse(size, out int intSize);
            if (result)
            {
                Group group = new();
                group.Name = groupname;
                group.MaxSize = intSize;
                if (groupService.Creat(group) is null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Group  yaradildi");
                }
               
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun size daxil edin");
            }
        }
        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Group List");
            var groups= groupService.GetAll();
            if (groups.Count>0)
            {
                foreach (var item in groups)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.MaxSize}");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Empty List");
            }
        }
    }
}
