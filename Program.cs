using DelegateHW;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static IEnumerable<T> Sort<T>(IEnumerable<T> source, Func<T, T, int> comparer)
        {
            var items = source.ToArray();

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (comparer(items[i], items[j]) > 0)
                    {
                        Swap(ref items[i], ref items[j]);
                    }
                }
            }

            IEnumerator<T> iEnumerator = items.Take(items.Count()).GetEnumerator();

            while (iEnumerator.MoveNext())
            {
                yield return iEnumerator.Current;
            }
        }

        static private void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        static IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            foreach (var item in source)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }

        public static void RepeatCode(Action action, Func<bool> condition, int timesCount)
        {
            int repeated = 0;

            while (condition() && ++repeated <= timesCount)
            {
                action();
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

            var sorted = Sort(users, (x, y) => x.PhoneNumber.CompareTo(y.PhoneNumber)).ToList();
            var selection = Filter(users, t => t.PhoneNumber == "123").ToList();
            Func<bool> condition = new Func<bool>(() => true);
            RepeatCode(Console.WriteLine, condition, 5);
        }
    }
}