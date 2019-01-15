using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");
            Console.WriteLine("Enter a Numerical Grade: ");
            String grade = Console.ReadLine();

            if (grade == "100" || grade == "99")
            {
                Console.WriteLine("Letter Grade: A+");
            }
            else if (grade == "98" || grade == "97" || grade == "96" || grade == "95" || grade == "94")
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade == "93" || grade == "92" || grade == "91" || grade == "90")
            {
                Console.WriteLine("Letter Grade: A-");
            }
            else if (grade == "89" || grade == "88" || grade == "87")
            {
                Console.WriteLine("Letter Grade: B+");
            }
            else if (grade == "86" || grade == "85" || grade == "84" || grade == "83")
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade == "82" || grade == "81" || grade == "80")
            {
                Console.WriteLine("Letter Grade: B-");
            }
            else if (grade == "79" || grade == "78" || grade == "77")
            {
                Console.WriteLine("Letter Grade: C+");
            }
            else if (grade == "76" || grade == "75" || grade == "74" || grade == "73")
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade == "72" || grade == "71" || grade == "70")
            {
                Console.WriteLine("Letter Grade: C-");
            }
            else if (grade == "69" || grade == "68" || grade == "67")
            {
                Console.WriteLine("Letter Grade: D+");
            }
            else if (grade == "66" || grade == "65" || grade == "64" || grade == "63")
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (grade == "62" || grade == "61" || grade == "60")
            {
                Console.WriteLine("Letter Grade: D-");
            }
            else (grade == )
        }
    }
}
