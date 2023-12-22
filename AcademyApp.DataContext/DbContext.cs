using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext
{
    public static class DbContext
    {
       public static List<Student> Students { get; set; }
       public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new ();
            Groups = new ();
        }
    }
}
