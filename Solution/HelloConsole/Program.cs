using System;
using System.Configuration;
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
            AppDomain.CurrentDomain.GetData("C:\\Users\\malik.jones\\source\repos\\MyLab1\\Solution\\HelloConsole\\HelloConsole.exe");

            //The code provided will print ‘Hello World’ to the console.
            //Press Ctrl+F5(or go to Debug > Start Without Debugging) to run your app.
             string strName = ConfigurationManager.AppSettings["name"];
            string strAge = ConfigurationManager.AppSettings["age"];
            
            Console.WriteLine(String.Format("Hello {0} you are {1} years old", strName, strAge));
            Console.ReadKey();

            //string strName = String.Empty;
            //string strAge = String.Empty;
            switch (args.Length)
            {

                case 0:
                    {
                        strName = PromptName();
                        strAge = PromptAge();
                        break;
                    }
                case 1:
                    {
                        if (IsNum(args[0]))
                        {
                            strName = PromptName();
                            strAge = args[0];
                        }
                        else
                        {
                            strName = args[0];
                            strAge = PromptAge();
                        }

                        break;
                    }
                case 2:
                    {
                        if (IsNum(args[0]) && IsNum(args[1]))
                        {
                            strName = args[0];
                            strAge = args[1];
                        }
                        else 
                        if (IsNum(args[0]))
                        {
                            strAge = args[0];
                            strName = args[1];
                        }
                        else
                            if (IsNum(args[1]))
                        {
                            strName = args[0];
                            strAge = args[1];
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
            
            Console.WriteLine(String.Format("{0} your age is {1}", strName, strAge));
            // Really your parents Named you a 'Number'?
            if (IsNum(strName))
            {
                DoNameIsANumber(strName, strAge);
               
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