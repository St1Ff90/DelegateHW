using DelegateHW;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static IEnumerable<T> Sort<T, K>(IEnumerable<T> source, Func<T, K> keySelector)
        {
            var items = source.ToArray();
            var keys = items.Select(keySelector).ToArray();
            Array.Sort(keys, items);
            foreach (var item in items)
            {
                yield return item;
            }
        }

        static IEnumerable<T> MyFilter<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            return source.Where(filter);
        }

        public delegate void Print<T>(T val);
        public delegate T Read<T>();

        public static void RepeateCode(Action action, bool condition, int timesCount)
        {
            int repiated = 0;

            while (condition && repiated < timesCount)
            {
                action.Invoke();
            }
        }

        static void Main(string[] args)
        {
            IEnumerable<User> users = new User[3]
                {
                new User("Vasia","Pupkin", DateTime.Now, "123"),
                new User("Kolia","Petechkin", DateTime.Now, "321"),
                new User("Seergay","Andreyev", DateTime.Now, "222"),
                };

            var sorted = Sort(users, u => u.PhoneNumber).ToList();
            var selection = MyFilter(users, t => t.PhoneNumber == "123").ToList();
            Print<string> print = Console.WriteLine;
            Read<string> read = Console.ReadLine;
            print("Hello world!");
            string result = read();

            RepeateCode(Console.WriteLine, true, 5);

        }
    }
}