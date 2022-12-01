// Created by: Timothy Manwell
// Created on: Nov 2022
//
// This program check if your are eligible for student pricing
using System;

class Program
{
    public static void Main(string[] args)
    {
        int age; 
        string day = null;

        Console.WriteLine("Are you eligible for student pricing?");
        Console.WriteLine("\nAnswer the following questions to find out.");
        Console.Write("\nHow old are you? ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nIs it Tuesday or Thursday (Answer with 'Yes' or 'No')? ");
        day = Console.ReadLine();

        if ((age > 12 && age < 25) || (day == "Yes" || day != "No"))
        {
            Console.WriteLine("\nYou're eligible for student pricing.");
        }
        else
        {
            Console.WriteLine("\nYou're not eligible for student pricing.");
        }
    }
}