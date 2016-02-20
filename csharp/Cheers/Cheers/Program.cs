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
            Console.WriteLine("\nWhat's your name?");
            Console.WriteLine();
            do
            {
                Console.Write("  ");
                name = Console.ReadLine();
                if (name != null)
                    Console.WriteLine("Give me a(n) ..."+ (name[0]));
                       //Assert.Equal(name, name[0]);
                    Console.WriteLine("Give me a(n) ...  " + (name[1]));
                    Console.WriteLine("Give me a(n)..." + (name[2]));

                    Console.WriteLine( name + " is .. GRAND!");

            } while (name != null);

             
        }
    }
}
