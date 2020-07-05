using System;
using System.Collections.Generic;

namespace GPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            test.introduction();
        }
        public void introduction()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the GPA calculator");
            Console.WriteLine("PLease select an option: ");
            message_options();
        }
        public void message_options()
        {
            Console.Write("1) Calculate GPA for a whole year: ");
            Console.Write("2) Calculate GPA based on existing GPA: ");
            string userInput =  Console.ReadLine();
            int converted_user_input = 0;
            try
            {
                converted_user_input = Convert.ToInt32(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{converted_user_input}'");
            }
            if (converted_user_input == 1)
            {
                Console.WriteLine("1) Calculate GPA for a whole year: ");
                calculation(converted_user_input);
            }
            else if (converted_user_input == 2)
            {
                Console.WriteLine("2) Calculate GPA based on existing GPA: ");
                calculation(converted_user_input);
            }
        }
        public void calculation(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Please enter your course grades (0 - 7)");
                List<string> grade_list = new List<string>();
                string userInput = Console.ReadLine();
                for (int next = 0; next <= 8; next++)
                {
                    userInput = Console.ReadLine();
                    Console.WriteLine(Convert.ToString(next) + ") " + userInput);
                    grade_list.Add(userInput);
                }
                Console.WriteLine(grade_list);
            }
            else if (option == 2)
            {

            }
        }

    }
}
