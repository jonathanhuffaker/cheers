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

            DateTime myDayOBirth = DateTime.Parse(bday);

            //DateTime today = DateTime.Now;
            DateTime today = DateTime.Today;

           // tested below to see if this is the same result as myDayOBirth - it is
            DateTime bdaydate = Convert.ToDateTime(bday);
            //var daysTill = (today - bdaydate).Days;
            var daysTill = (today - myDayOBirth).Days;

            TimeSpan diff1 = today.Subtract(bdaydate);

            //Console.WriteLine(myDayOBirth);
            //Console.WriteLine(bdaydate);
            //Console.WriteLine(name);
            //Console.WriteLine(bday);
            //Console.WriteLine(today);

                if (bdaydate.Month < today.Month)
            {
                daysTill = 365 - daysTill;
                Console.WriteLine("Your birthday is in .... " + daysTill + " days!");
            }
            else
            {
                Console.WriteLine("Your birthday is in .... " + diff1 + " days!");
            }  

                if(daysTill == 0)
                {
                    Console.WriteLine("Happy Birthday!!!!!");

                }
            
            



           for (int i = 0; i < name.Length; i++) {
                //halfnorsemix

                string giveA = "a";
                string giveAn = "an";
                if (name[i] == 'h' || name[i] == 'a' || name[i] == 'l' || name[i] == 'f' || name[i] == 'n' || name[i] == 'o' || name[i] == 'r' || name[i] == 's' || name[i] == 'e' || name[i] == 'm' || name[i] == 'i' || name[i] == 'x')
                {
                    Console.WriteLine("Give me " + giveAn + "..." + name[i]);
                } else
                {
                    Console.WriteLine("Give me " + giveA + "..." + name[i]);
                }

            }
            Console.WriteLine(name + " is .. GRAND!");

            //} while (name != null);
            Console.ReadLine();
        }
    }
}
