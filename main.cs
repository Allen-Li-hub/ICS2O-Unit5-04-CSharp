// Created by: Allen Li
// Created on: Oct 2022
//
// This program displays the discount checker

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userAge;
        string userDay;

        Console.WriteLine("Let's see can you get the discount or not");
        Console.WriteLine("");

        Console.WriteLine("Enter your age, then the date that you want to get the discount: ");
        Console.WriteLine("");
        userAge = Convert.ToInt16(Console.ReadLine());
        userDay = (Console.ReadLine());

        Console.WriteLine(" ");
        if ((userDay == "Tuesday" || userDay == "Thursday") || (userAge > 12 && userAge < 21))
        {
            Console.WriteLine("You get the discount!");
        }
        else
        {
            Console.WriteLine("Your current conditions cannot get discount.");
        }

        Console.WriteLine("\nDone.");
    }
}