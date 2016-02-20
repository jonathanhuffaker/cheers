using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowel = new[] { "a", "e", "i", "o", "u" };
            
            Console.Clear();
            string name;
            string bday;
            Console.WriteLine("What's your name?");
            Console.WriteLine();
            do
            {
                Console.Write("  ");
                name = Console.ReadLine();
               if (name != null)
                    for (int i = 0; i < name.Length; i++) {
                        Console.WriteLine("Give me a(n) ..." + (name[i]));
                       
                    }
                //Assert.Equal(name, name[0]);
                //Console.WriteLine("Give me a(n) ...  " + (name[1]));
                //Console.WriteLine("Give me a(n)..." + (name[2]));

                Console.WriteLine( name + " is .. GRAND!");

            } while (name != null);

             
        }
    }
}
