using BrewMaster.Models;
using System.Xml.Linq;

namespace BrewMaster.Models
{
    public class Employee : User
    {
        public Employee() { }
        public Employee(string name, string password)
        {
            Name = name;
            Password = password;
            UserType = "Employee";
        }
    }
}
