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
            List<string> words = new List<string> { "äpple", "banan", "citron" };
            words.Reverse();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
