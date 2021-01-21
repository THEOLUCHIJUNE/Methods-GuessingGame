using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int Level = 0;
            Console.WriteLine("Hi Friend. Welcome to the Guessing Game.");
            Console.WriteLine("In this game,there are three levels: ");
            Console.WriteLine("1 signifies the Easy Level");
            Console.WriteLine("2 signifies the Intermediate Level");
            Console.WriteLine("3 signifies the Hard Level");
            Console.WriteLine("Friend, kindly signify below which level you would like to play with either 1,2 or 3 ");
            Level = int.Parse(Console.ReadLine());
            Console.WriteLine("You are playing Level" + Level);

            int level1 = 1;
            int level2 = 2;
            int level3 = 3;

            if (Level == level1)
            {
                GameLevel(6,1,10);
            }

            if (Level == level2)
            {
                GameLevel(4,1,20);
            }

            if (Level == level3)
            {
                GameLevel(3,1,50);
            }
        }
        public static void GameLevel(int trials, int min, int max)
        {

            int input = 0;
            int randomNumber = new Random().Next(min,max);
                
            for(int i = 0; i < trials; i++)
            {
                Console.Write("Take a guess");
                input = int.Parse(Console.ReadLine());   

                if(i == (trials - 1) && input != randomNumber)
                {
                    Console.WriteLine("Sorry, You Lose. The number was " + randomNumber );
                }
                if (i != (trials - 1) && input != randomNumber)
                {
                    Console.WriteLine("Wrong Number. Kindly Try Again");
                }
                else if (i <= trials && input == randomNumber)
                {
                    Console.WriteLine("Yay! You Win. The number was " + randomNumber);
                    break;
                }
      
            }
            
                
        }
    }
}
