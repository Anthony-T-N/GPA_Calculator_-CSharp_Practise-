using System;
using System.Collections.Generic;

namespace GPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main_program = new Program();
            main_program.introduction();
        }
        public void introduction()
        {
            Console.WriteLine("Welcome to the GPA calculator");
            Console.WriteLine("Please select one of the following option: ");
            message_options();
        }
        public void message_options()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.Write("1) Custom GPA calculation: ");
                Console.Write("2) Calculate future GPA based on existing GPA: ");
                Console.Write("3) Exit program.");
                Console.WriteLine("");
                string user_input = Console.ReadLine();
                int converted_user_input = 0;
                try
                {
                    converted_user_input = Convert.ToInt32(user_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{converted_user_input}'");
                }
                if (converted_user_input == 1)
                {
                    Console.WriteLine("Expected GPA: " + Calculation(converted_user_input));
                }
                else if (converted_user_input == 2)
                {
                    Console.WriteLine("Expected GPA: " + Calculation(converted_user_input));
                }
                else if (converted_user_input == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input - Please Try Again");
                }
            }
        }
        public double Calculation(int option)
        {
            double course_unit_value = 4.5;

            if (option == 1)
            {
                int item = 0;
                double convered_user_input;
                double sum = 0;
                double course_cal = 0;

                Console.WriteLine("Please enter your course grades (0 - 7):");
                List<double> grade_list = new List<double>();
                while (true)
                {
                    string userInput = Console.ReadLine();
                    if (userInput == "e")
                    {
                        break;
                    }
                    convered_user_input = Convert.ToDouble(userInput);
                    Console.WriteLine(Convert.ToString(item + 1) + ") " + userInput);
                    grade_list.Add(convered_user_input);
                    item++;
                }
                Console.WriteLine("Courses completed: " + grade_list.Count);
                for (item = 0; item <= grade_list.Count - 1; item++)
                {
                    course_cal = grade_list[item];
                    course_cal = course_cal * course_unit_value;
                    sum = sum + course_cal;
                }
                return (sum / (course_unit_value * grade_list.Count));
            }
            else if (option == 2)
            {
                double known_gpa = 0;
                double num_of_courses = 0;
                int num_of_added_courses = 0;
                int item = 0;

                Console.WriteLine("Please enter your current GPA:");
                known_gpa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter number of courses you've completed so far:");
                num_of_courses = Convert.ToDouble(Console.ReadLine());

                double value = known_gpa * num_of_courses;

                Console.WriteLine("Please enter a predicted/future grade (0 - 7):");
                while (true)
                {
                    string user_input = Console.ReadLine();
                    if (user_input == "e")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(Convert.ToString(item + 1) + ") " + user_input);
                        value += Convert.ToDouble(user_input);
                    }
                    num_of_added_courses += 1;
                    item++;
                }
                return (value / (num_of_added_courses + num_of_courses));
            }
            else
            {
                return 0;
            }
        }
    }
}
