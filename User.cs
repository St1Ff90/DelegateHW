using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string PhoneNumber { get; set; }

        public User(string fierstName, string lastName, DateTime dateOfBierthday, string phoneNumber)
        {
            FirstName = fierstName;
            LastName = lastName;
            DateOfBirthday = dateOfBierthday;
            PhoneNumber = phoneNumber;
        }
    }
}
