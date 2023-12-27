

namespace AcademyApp.Helpers
{
    public  class Helper
    {
        public static void ChangeTextColor(ConsoleColor color , string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    public enum StartMenus
    {
        Exit,
        Studens,
        Groups
    }
    public enum StudentMenus
    {
        Home,
        CreatStudent,
        GetAllStudents,
        GetAllStudentsWithName,
        GetStudentById,
        UpdateStudentById,
        DeleteStudentById
    }
    public enum GroupMenus
    {
        Home,
        CreatGroup ,
        GetAllGroups,
        GetGroupById,
        UpdateGroup,
        DeleteGroup
    }
}
