
using AcademyApp.Business.Servicess;
using AcademyApp.Domain.Models;
using AcademyApp.Helper;
StudentService servic=new ();
Helper.ChangeTextColor(ConsoleColor.Green,"Academy App");
Helper.ChangeTextColor(ConsoleColor.White, "Enter number");
Helper.ChangeTextColor(ConsoleColor.Yellow, "1.Created Student 2.Get all students 0.exit");
 string menu = Console.ReadLine();
bool result=int.TryParse(menu, out int intmenu);
while(true)
{
    if(result&& intmenu>0&& intmenu<3)
    {
        switch (intmenu)
        {
            case 1:
                Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student name");
                string name=Console.ReadLine();
                Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Surname");
                string surname = Console.ReadLine();
                Helper.ChangeTextColor(ConsoleColor.Blue, "Enter student Group Name");
                string groupName = Console.ReadLine();
                Student newstudent = new ();
                newstudent.Name = name;
                newstudent.Surname = surname;
                if (servic.Create(newstudent,groupName) is null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Daxil Etdiyiniz melumatlarda sehflik var");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Telebe  yaradildi");
                }
                break;
        }
    }
    else if (intmenu==0) 
    {
        Helper.ChangeTextColor(ConsoleColor.Red, "Menyudan cixis edildi");
        break;
    }
    else
    {
        Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun secim edin");
    }

}


