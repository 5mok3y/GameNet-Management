using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.ViewModels
{
    public class PersonnelDataViewmodel
    {
        public int PersonnelID { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string IsActive { get; set; }
        public string RegisterDate { get; set; }
    }
}
