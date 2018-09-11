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
            string nameStr = String.Empty;
            string ageStr = String.Empty;
            switch (args.Length)
            {

                case 0:
                    {
                        nameStr = PromptName();
                        ageStr = PromptAge();
                        break;
                    }
                case 1:
                    {
                        if (IsNum(args[0]))
                        {
                            nameStr = PromptName();
                            ageStr = args[0];
                        }
                        else
                        {
                            nameStr = args[0];
                            ageStr = PromptAge();
                        }

                        break;
                    }
                case 2:
                    {
                        if (IsNum(args[0]) && IsNum(args[1]))
                        {
                            nameStr = args[0];
                            ageStr = args[1];
                        }
                        else 
                        if (IsNum(args[0]))
                        {
                            ageStr = args[0];
                            nameStr = args[1];
                        }
                        else
                            if (IsNum(args[1]))
                        {
                            nameStr = args[0];
                            ageStr = args[1];
                        }
                        else
                        {
                            throw new ArgumentException(String.Format("Neiter {0} or {1} are numbers", args[0], args[1]));
                        }
                        break;
                    }
                default:
                    throw new ArgumentException(String.Format("Wrong number of Errors"));
            }
            
            Console.WriteLine(String.Format("{0} your age is {1}", nameStr, ageStr));
            // Really your parents Named you a 'Number'?
            if (IsNum(nameStr))
            {
                DoNameIsANumber(nameStr, ageStr);
               
            }
            Console.ReadKey();
        }

       

        private static bool IsNum(string v)
        {
            return int.TryParse(v , out int n);

        }

        private static string PromptAge()
        {
            bool ageCaptured = false;
            string ageStr = string.Empty;
            do
            {
                Console.Write("Enter your Age: ");
                ageStr = Console.ReadLine();
                ageCaptured = IsNum(ageStr);
                if (!ageCaptured)
                {
                    Console.WriteLine("Invalid Age");
                }
            } while (!ageCaptured);
            return ageStr;
        }

        private static string PromptName()
        {
            Console.Write("What Is your Name: ");
            return Console.ReadLine();
        }

        private static void DoNameIsANumber(string nameStr, string ageStr)
        {
            if (nameStr == "99")
            {
                Console.WriteLine("I think your Boss Maxwell Smart is Great! I also Have crush on you!");
                Console.WriteLine("Look at this video https://www.youtube.com/watch?v=I6UQW64hxMI");
                if (int.Parse(ageStr) > 29)
                {
                    Console.WriteLine("You really don't look a day over 29");

                }
            }
            else
            {
                Console.WriteLine("Your Parents were Mathematicians! ");

            }
        }
    }
}