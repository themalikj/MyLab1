using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string name;
            int age;
            if (args.Length == 0)
            {
                Console.WriteLine("Type your first name and press Enter:");
                name = Console.ReadLine();
                Console.WriteLine("Hello, " + name);
                Console.ReadLine();
            }
            else if (args.Length != 2)
            {
                Console.WriteLine("User Error: incorrect number of arguments");
            }
            else 
            {
                name = args[0];
                if (int.TryParse(args[1], out age))
                {
                    age = Int32.Parse(args[1]);
                    if (age > 1)
                    {
                        Console.WriteLine(name + " is " + age + " years old.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("User Error: 2nd argument(age) is invalid");
                    }
                }
                else
                {
                    Console.WriteLine("User Error: 2nd argument(age) is invalid");
                }
            }


        }
    }
}
