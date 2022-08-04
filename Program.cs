using DelegateHW;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Sort(User[] users, Func<User, User, int> comparer)
        {
            for (int i = 0; i < users.Length; i++)
            {
                for (int j = i + 1; j < users.Length; j++)
                {
                    if (comparer(users[i], users[j]) > 0)
                    {
                        var temp = users[i];
                        users[i] = users[j];
                        users[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User[] users = new User[3]
            {
                new User("Vasia","Pupkin", DateTime.Now, "123"),
                new User("Kolia","Petechkin", DateTime.Now, "321"),
                new User("Seergay","Andreyev", DateTime.Now, "222"),
            };

            Sort(users, User.CompareDateOfBirthday);
        }
    }
}