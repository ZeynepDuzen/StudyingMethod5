using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod5
{
    internal class Program
    {
        static void FirstName(string firstName) {

            Console.WriteLine(firstName + " " + "Sun");
        }
        static void Main(string[] args)
        {
            FirstName("Emy");
            FirstName("Linda");
            FirstName("Lucy");
            FirstName("July");

            Console.Read();
        }
    }
}
