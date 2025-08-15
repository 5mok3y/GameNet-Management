using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.App.User
{
    public static class CurrentUser
    {
        public static string LoggedInUsername { get; set; }
        public static UserRole Role { get; set; }


        public static bool IsAdmin()
        {
            return Role == UserRole.Admin;
        }
    }
}
