using System;

namespace Arrays
{
    class Program
    {
        /*Create parallel arrays, one will have the course subject (e.g. MIS, MATH, etc.) 
         * and the other will hold course numbers (e.g. 3033, 3013, etc.).  Ask the user 
         * to input 3 for each, store them in the array.  Then use a different loop to output 
         * the results to the user concatenated together (e.g. MIS3033, MATH3013).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first course.");
            string firstCourse = Console.ReadLine().ToUpper();

            Console.WriteLine("Please input your second course.");
            string secondCourse = Console.ReadLine().ToUpper();

            Console.WriteLine("Please input your third course.");
            string thirdCourse = Console.ReadLine().ToUpper();

            string[] courses = { firstCourse, secondCourse, thirdCourse };

            int firstNumbers;
            int secondNumbers;
            int thirdNumbers;



            Console.WriteLine("Please input your first course numbers.");
            string first = Console.ReadLine().ToUpper();
            while (int.TryParse(first, out firstNumbers) == false)
            {
                Console.WriteLine("Please input a number.>>");
                first = Console.ReadLine();
            }

            Console.WriteLine("Please input your second course numbers.");
            string second = Console.ReadLine();
            while (int.TryParse(second, out secondNumbers) == false)
            {
                Console.WriteLine("Please input a number.>>");
                second = Console.ReadLine();
            }

            Console.WriteLine("Please input your third course numbers.");
            string third = Console.ReadLine();
            while (int.TryParse(third, out thirdNumbers) == false)
            {
                Console.WriteLine("Please input a number.>>");
                third = Console.ReadLine();
            }

            int[] courseNumbers = { firstNumbers, secondNumbers, thirdNumbers };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine($"{courses[i]}{ courseNumbers[i]}");
            }
        }
    }
}
