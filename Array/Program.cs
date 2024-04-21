using System;
namespace Application

{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();//created a new instance of the System.Random then call the Random.Next

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total} ");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {

                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled trippled! +6 bonus to total");

                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");

                }
                Console.WriteLine($"Your total including the bounus: {total}");
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a brand new laptop");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two");
            }
            else
            {
                Console.WriteLine("You win a Cup");
            }


            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 2)
            {
                Console.WriteLine($"Your subscription expires in {discountPercentage} days");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will soon expire. Renew soon!");
            }
            if (daysUntilExpiration > 0)
            {
                Console.WriteLine($"Renew now and get {discountPercentage}%");
            }


        }
    }
}