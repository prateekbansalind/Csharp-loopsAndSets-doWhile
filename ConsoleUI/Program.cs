using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // demonstration on the use of the do while loop

            // do while

            /************************** CODE (DO WHILE) EXAMPLE ***********************************/
         

            string decisionVariable = ""; 

            do
            {
                Console.Write("What is your name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine($"Hello, {firstName}");

                Console.Write("Do you want to make another entry? (yes/no): ");
                decisionVariable = Console.ReadLine();

            } while (decisionVariable.ToLower() == "yes");

         
            /*******************************************************************************************/




            // while loop

            /************************** CODE (WHILE) EXAMPLE ***********************************/
        


            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            while (isValidAge == false)
            {
                Console.WriteLine("That's not the valid entry. Please try it again.");
                Console.WriteLine("Age should be in numbers.");
                Console.WriteLine("");

                Console.Write("Enter your age: ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);

            }

            Console.WriteLine($"Your age will be {age + 10} in 10 years.");


           
            /*******************************************************************************************/

            Console.ReadLine();
}
}
}