﻿using System;
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



        }
    }
}