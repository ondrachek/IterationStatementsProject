using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            
            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            var int = num 
            //initialize the variable with a value of 0
            var myNum = 0



            // Create a do-while loop and use the template below:
            

            {
                // Increment num by 1
                do
                {
                    myNum++;
                    int.Add(myNum);

                    while (myNum < 100);






                } 



                // Then add num to the collection - numbers

                    // Hint: reference num inside of the Add method's parentheses
                
                num.Add(myNum);


            } // <---- While your variable is less than 100
            while(myNum < 100);




            // Create a while loop
            // <--- While num is less than 200
            while(myNum < 200);
            {
                // Increment num by 1
                myNum++;
                // Then add num to the collection numbers
                int.Add(myNum);

                    //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
                foreach(var item in num)
                {
                    Console.Writeline($"{item}");
                }

             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            for(int i = 199; i <= num.Count && i >= 0; i--)
            {
                Console.Writeline($"{num()}"); 
            }
            {
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
    }
}
