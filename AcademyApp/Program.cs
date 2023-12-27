
using AcademyApp.Controller;
using AcademyApp.Helpers;

StudentController studentController=new ();
GroupController groupController=new ();

while(true)
{
    Helper.ChangeTextColor(ConsoleColor.Green, "Academy App");
    Helper.ChangeTextColor(ConsoleColor.White, "Enter number");
    Helper.ChangeTextColor(ConsoleColor.Yellow, "1.Student Menu 2.Group Menu 0.exit");
    string menu = Console.ReadLine();
    bool result = int.TryParse(menu, out int intmenu);
    if (result && intmenu == (int)StartMenus.Studens)
    {
        Helper.ChangeTextColor(ConsoleColor.Green, "Student Menu");
        Helper.ChangeTextColor(ConsoleColor.White, "Enter number");
        Helper.ChangeTextColor(ConsoleColor.Yellow, "1.CreatStudent\r\n" +
            "2.GetAllStudents\r\n" +
            "3.GetAllStudentsWithName\r\n" +
            "4.GetStudentById\r\n" +
            "5.UpdateStudentById\r\n" +
            "6.DeleteStudentById\r\n"+
            "0.Home\r\n");
        string studentmenu = Console.ReadLine();
        bool sturesult = int.TryParse(studentmenu, out int stumenu);
        if (sturesult && stumenu >= 0 && stumenu < 7)
        {
            switch (stumenu)
            {
                case (int)StudentMenus.CreatStudent:
                    studentController.CreatStudent();
                    break;

                case (int)StudentMenus.GetAllStudents:
                    studentController.GetAllStudent();
                    break;

                case (int)StudentMenus.GetAllStudentsWithName:
                    studentController.GetAllStudentsWithName();
                    break;

                case (int)StudentMenus.GetStudentById:
                    studentController.GetStudentById();
                    break;

                case (int)StudentMenus.UpdateStudentById:
                    studentController.UpdateStudent();
                    break;

                case (int)StudentMenus.DeleteStudentById:
                    studentController.DeleteStudent();
                    break;

                case (int)StudentMenus.Home:

                default:
                    break;
            }
        }
        else  Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun secim edin"); 
    }

    else if (result && intmenu == (int)StartMenus.Groups)
    {
        Helper.ChangeTextColor(ConsoleColor.Green, "Group Menu");
        Helper.ChangeTextColor(ConsoleColor.White, "Enter number");
        Helper.ChangeTextColor(ConsoleColor.Yellow, "1.CreatGroup\r\n" +
            "2.GetAllGroups\r\n" +
            "3.GetGroupById\r\n" +
            "4.UpdateGroup\r\n" +
            "5.DeleteGroup\r\n" +
            "0.Home\r\n");
        string Groupmenu = Console.ReadLine();
        bool grresult = int.TryParse(Groupmenu, out int grmenu);
        if (grresult && grmenu >=0 && grmenu < 6)
        {
            switch (grmenu)
            {
                case (int)GroupMenus.CreatGroup:
                    groupController.CreatGroup();
                    break;

                case (int)GroupMenus.GetAllGroups:
                    groupController.GetAll();
                    break;

                case (int)GroupMenus.GetGroupById:
                    break;

                case (int)GroupMenus.UpdateGroup:
                    break;

                case (int)GroupMenus.DeleteGroup:
                    break;

                case (int)GroupMenus.Home:
                    break;

                default:
                    break;
            }
        }
         else Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun secim edin");
    }

    else if (result && intmenu == (int)StartMenus.Exit)
    {
        Helper.ChangeTextColor(ConsoleColor.Red, "Menyudan cixis edildi");
        break;
    }
    else Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun secim edin");
   

}


