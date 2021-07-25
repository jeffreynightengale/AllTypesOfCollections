using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        /*Create a list that will hold all of the users grades.  
         * Keep prompting the user if they have another grade to enter until they say 'no'.  
         * Once you have all of the inputs, use a for each loop to iterate through the list and 
         * calculate the average.  Output the users grade average.
         */
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();

            string response;
            do
            {
                Console.WriteLine("Input a grade.>>");
                double answer = Convert.ToDouble(Console.ReadLine());

                grades.Add(answer);

                Console.WriteLine("Would you like to input another grade?");
                response = Console.ReadLine().ToLower();

            } while (response[0] == 'y');
            
            double average = 0;

            foreach (double grade in grades)
            {
                //Console.WriteLine(grade);

                average = average + grade / grades.Count;
            }
            Console.WriteLine(average);
        }
    }
}
