using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Collections
{
    public class MetodManager
    {
        public void Reverse()
        {
            List<string> ord = new List<string> { "apple", "banana", "strawberry" };
            ord.Reverse();
            Console.WriteLine("Reverse : " + string.Join(", ", ord));
        }

        public void UniqueName()
        {
            List<string> namn = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Write name {i + 1}: ");
                namn.Add(Console.ReadLine());
            }
            var unika = namn.Distinct().ToList();
            Console.WriteLine("Unika namn: " + string.Join(", ", unika));
        }

        public void ShortLongWords()
        {
            List<string> word = new List<string> { "sun", "snus", "animal", "ocean" };
            string shortWord = word.OrderBy(o => o.Length).First();
            string longWord = word.OrderByDescending(o => o.Length).First();
            Console.WriteLine($"shorest word: {shortWord}, longest word: {longWord}");
        }

        public void EvenNumbers()
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, };
            var evenNumbers = ints.FindAll(n => n % 2 == 0);
            Console.WriteLine("Even numbers" + string.Join(", ", evenNumbers));
        }

        public void RemoveShortWords()
        {
            List<string> strings = new List<string> { "hello", "on", "for", "who", "me" };
            strings.RemoveAll(o => o.Length < 3);
            Console.WriteLine("After the removing: " + string.Join(", ", strings));
        }
    }
}
