using BrewMaster.Models;
using System.Xml.Linq;

namespace BrewMaster.Models
{
    public class Admin : User
    {
        public Admin() { }
        public Admin(string name, string password)
        {
            Name = name;
            Password = password;
            UserType = "Admin";
        }
    }
}
