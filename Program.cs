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
            string userInput = Console.ReadLine();
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
                double convered_user_input;
                Console.WriteLine("Please enter your course grades (0 - 7)");
                List<double> grade_list = new List<double>();
                for (int next = 0; next <= 7; next++)
                {
                    string userInput = Console.ReadLine();
                    convered_user_input = Convert.ToDouble(userInput);
                    Console.WriteLine(Convert.ToString(next + 1) + ") " + userInput);
                    grade_list.Add(convered_user_input);
                }
                Console.WriteLine(grade_list.Count);
                for (int next = 0; next <= grade_list.Count - 1; next++)
                {
                    Console.WriteLine(grade_list[next]);
                }
                double sum = 0;
                double course_cal = 0;
                for (int item = 0; item <= grade_list.Count - 1; item++)
                {
                    course_cal = grade_list[item];
                    course_cal = course_cal * 4.5;
                    sum = sum + course_cal;
                }
                double total = sum / (4.5 * 8);
                Console.WriteLine("Result: " + total);

            }
            else if (option == 2)
            {
                double known_gpa = 0;
                double num_of_courses = 0;
                bool check = true;

                Console.WriteLine("Please enter your gpa:");
                known_gpa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter number of courses:");
                num_of_courses = Convert.ToDouble(Console.ReadLine());

                double value = known_gpa * num_of_courses;

                int num_of_added_courses = 0;
                while (check)
                {
                    Console.WriteLine("Please enter number of grade:");
                    string input = Console.ReadLine();
                    if (input == "e")
                    {
                        break;
                    }
                    else
                    {
                        value += Convert.ToDouble(input);
                    }
                    num_of_added_courses += 1;
                }
                double new_gpa = value / (num_of_added_courses + num_of_courses);
                Console.WriteLine(new_gpa);
            }
        }
    }
}
