using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        /*Create a dictionary that will hold multiple values.  
         * The key will be the course code (e.g. MIS3013, MIS3383, etc.) 
         * and the values will be all of the students final grades (e.g. 0.95, 0.8, etc.).  
         * Add at least 3 courses codes and at least 3 grades in each one.  
         * Calculate the average for each course code and output it to the user, make sure to format it as a percent.
           If you have time, convert #3 to getting input from the user 
           and making sure the key doesn't exist prior to adding it
         */
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            studentGrades.Add("MIS3013", new List<double>());
            studentGrades["MIS3013"].Add(99);
            studentGrades["MIS3013"].Add(86);
            studentGrades["MIS3013"].Add(82);

            studentGrades.Add("ACCT 3013", new List<double>());
            studentGrades["ACCT 3013"].Add(96);
            studentGrades["ACCT 3013"].Add(82);
            studentGrades["ACCT 3013"].Add(79);

            studentGrades.Add("FIN 3033", new List<double>());
            studentGrades["FIN 3033"].Add(100);
            studentGrades["FIN 3033"].Add(95);
            studentGrades["FIN 3033"].Add(88);

            double average = 0; 
            double extra = 0;

            foreach (string courseCode in studentGrades.Keys)
            {
                List<double> grades = studentGrades[courseCode];
                double sum = 0;

                foreach (double grade in grades)
                {
                    extra = grade;
                    sum = sum + grade;

                    average = sum / grades.Count / 100;

                    Console.WriteLine(grade.ToString("N0"));
                }
                Console.WriteLine($"Your average for {courseCode} is {average.ToString("P")}");
            }
            



        }
    }
}
