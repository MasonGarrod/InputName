using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputName_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Invalid input, enter your name again: ");
                name = Console.ReadLine();

            }

            if (name == name)
            {
                Console.WriteLine("Your name is " + name);
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
