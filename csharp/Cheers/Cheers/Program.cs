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
            name = Console.ReadLine();

            Console.WriteLine("What's your birthday (mm/dd)?");
            bday = Console.ReadLine();

            DateTime today = DateTime.Now;
            DateTime bdaydate = Convert.ToDateTime(bday);
            var daysTill = (today - bdaydate).Days;
            Console.WriteLine(name);
            Console.WriteLine(bday);
            Console.WriteLine(daysTill);
/*
            do
            {
                Console.Write("  ");
                name = Console.ReadLine();
               if (name != null) */
                    for (int i = 0; i < name.Length; i++) {
                        Console.WriteLine("Give me a(n) ..." + (name[i]));
                       
                    } 
                //Assert.Equal(name, name[0]);
                //Console.WriteLine("Give me a(n) ...  " + (name[1]));
                //Console.WriteLine("Give me a(n)..." + (name[2]));

                Console.WriteLine( name + " is .. GRAND!");

            //} while (name != null);
            Console.ReadLine();
             
        }
    }
}
