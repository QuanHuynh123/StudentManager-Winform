using DTO;

namespace BLL
{
    public static class SessionLogin
    {
        public static TeacherDTO LoggedInTeacher { get; set; }
        public static bool IsLoggedIn => !(LoggedInTeacher is null);
        public static void Logout()
        {
            LoggedInTeacher = null;
        }
    }
}
