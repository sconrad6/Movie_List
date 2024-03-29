﻿using System;

namespace Movie_List
{
    class MovieMaster
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie log!");
            string userChoice;
            do
            {
                Menu();
                UserChoice();
                Console.WriteLine("Would you like to continue? Y/N");
                userChoice = Console.ReadLine().ToLower();

            } while (userChoice == "y");
            Console.WriteLine("Goodbye!");
        }

        public static void Menu()
        {
            Console.WriteLine("Please enter a movie category (name or number): \n" +
                "1. \"Animated\"\n" +
                "2. \"Horror\"\n" +
                "3. \"Drama\"\n" +
                "4. \"Sci-Fi\"\n");
        }

        public static void UserChoice()
        {
            string userChoice;
            do
            {
                userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "animated":
                    case "1":
                        MovieManager.DisplayAnimated();
                        return;
                    case "horror":
                    case "2":
                        MovieManager.DisplayHorror();
                        return;
                    case "drama":
                    case "3":
                        MovieManager.DisplayDrama();
                        return;
                    case "sci-fi":
                    case "4":
                        MovieManager.DisplaySciFi();
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (MovieValidator.Validator(userChoice));
        }
    }
}
