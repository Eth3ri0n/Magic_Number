using System;

namespace Magic_Number
{
    class Program
    {
        static int DisplayMagicNumber(int min, int max)
        {

            int number = min - 1; // number is not in the range [min, max]
            while ((number < min) || (number > max)) // while the number is not in the range [min, max]
            {
                Console.Write($"Please enter a number between {min} and {max} ! "); // ask the user to enter a number
                string user_answer_number_str = Console.ReadLine(); // get the user's answer

                try
                {
                    number = int.Parse(user_answer_number_str); // convert the user's answer to an integer

                    if ((number < min) || (number > max)) // if the number is not in the range [min, max]
                    {
                        Console.WriteLine($"The number must be between {min} and {max} !"); // display an error message
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number !"); // display an error message
                }
            }
            return number; // return the number
        }

        static void Main(string[] args)
        {
            const int NUMBER_MIN = 1; // minimum number
            const int NUMBER_MAX = 10; // maximum number

            Random random = new Random(); // random number generator
            int Magic_Number = random.Next(NUMBER_MIN, NUMBER_MAX + 1); // magic number

            int user_number = Magic_Number + 1; // user's number is not the magic number
            int life = 4; // number of life

            //while (life > 0)
            for (; life > 0; life--)
            {
                Console.WriteLine(); // empty line
                Console.WriteLine(life + " life(s) left !");
                Console.WriteLine(); // empty line

                user_number = DisplayMagicNumber(NUMBER_MIN, NUMBER_MAX); // get the user's number

                if (Magic_Number < user_number)
                {
                    Console.WriteLine("The magic number is smaller !");
                }
                else if (Magic_Number > user_number)
                {
                    Console.WriteLine("The magic number is greater !");
                }
                else
                {
                    Console.WriteLine("Good Job, you found the magic number !");
                    break;
                }
                //life--;
            }

            if (life == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry you lost !");
                Console.WriteLine("The magic number was : " + Magic_Number);
            }
            //Console.WriteLine($"Your number is : {user_number}"); // display the user's number
        }
    }
}