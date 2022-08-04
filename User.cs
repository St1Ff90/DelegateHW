using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    internal class User : IComparer<User>
    {
        public string ?FierstName { get; set; }
        public string ?LastName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string ?PhoneNumber { get; set; }

        public User(string fierstName, string lastName, DateTime dateOfBierthday, string phoneNumber)
        {
            FierstName = fierstName;
            LastName = lastName;
            DateOfBirthday = dateOfBierthday;
            PhoneNumber = phoneNumber;
        }
        
        public int CompareFierstName(User u1, User u2)
        {
            return u1.FierstName.CompareTo(u2.FierstName);
        }

        public int CompareLastName(User u1, User u2)
        {
            return u1.LastName.CompareTo(u2.FierstName);
        }

        public static int CompareDateOfBirthday(User u1, User u2)
        {
            return u1.DateOfBirthday.CompareTo(u2.FierstName);
        }

        public int ComparePhoneNumber(User u1, User u2)
        {
            return u1.PhoneNumber.CompareTo(u2.FierstName);
        }

        public int Compare(User? x, User? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            return x.DateOfBirthday.CompareTo(y.DateOfBirthday);
        }
    }
}
