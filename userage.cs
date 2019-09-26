using System;

namespace basicexercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?: ");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            if (userAge < 21)
            {
                Console.WriteLine("Unfortunately, you aren't old enough to vote.");
            } else if (userAge >= 21)
            {
                Console.WriteLine("Congratulations! You're able to vote this year.");
            }
            

        }
    }
}
