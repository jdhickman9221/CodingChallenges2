using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Multiples3And5
{
    class _Monday1
    {
        static void Main(string[] args)
        {
             
                //Create a new, public repository and add a blank solution.Add a new Console Application project called Multiples3And5.

                //If we list all the natural numbers below 10
                //that are multiples of 3 or 5, we get 3, 5,
                //6 and 9. The sum of these multiples is 23.

                //Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

                //Remember to commit changes to the repository.Submit your repo url to this assignment.


                //Documentation by Jordan
                //1) We know that we need to account for all multiples of 3 and 5 under 1000
                //2) A for loop could be used to jump by 3 or 5 while the condition was less than or equal to 1000.
                //3) If we For tab tab, it will create the skeleton of the for loop, but we want to focus on the counter part, as we need to
                //reassign it by 3 at a time. We can repeat this for multiples of 5. 
                //4)by the end we will need to console.writeline the sum of all the multiples. we can use a collection .sum() to create 1 variable. 
                //5) in the for block we know that if the condition isn't met it will execute the code in the block until it's met. Thus the loop.

                ArrayList threes = new ArrayList();//made an empty list for multiples of 3. 
                ArrayList fives = new ArrayList();//made an empty list for multiples of 5.
                int sum3 = 0;//int is our data type because we are dealing with natural numbers. 
                int sum5 = 0;

                for (int i = 3; i <= 1000; i += 3)
                {
                    sum3 += i;//simple way to reassign our sum for 3's.
                    threes.Add(i);//this is adding to our arraylist for printout. 
                    
                }
            foreach (int three in threes)
            {
                Console.WriteLine(three);
            }
            Console.WriteLine($"All multiples of 3 are above. The sum in which is {sum3}.");//lets user know what data they are looking at.

            Console.ReadLine();
            Console.Clear();//console clear for the next multiples.
            for (int i = 5; i <= 1000; i += 5)
            {
                sum5 += i;//simple way to reassign our sum for 5's.
                fives.Add(i);//this is adding to our arraylist for printout. 

            }
            foreach (int five in fives)
            {
                Console.WriteLine(five);//we just want to write out each item in the collection. So each multiple.
            }
            Console.WriteLine($"All multiples of 5 are above. The sum in which is {sum5}");//lets user know what data they are looking at.
            Console.ReadLine();
            Console.Clear();//console clear for the next multiples.
            Console.WriteLine($"The sum of the multipliers of 3 and 5 under 1000 are:{sum3 + sum5}. ");


        }//end main
        }//end class
    }//end namespace
 