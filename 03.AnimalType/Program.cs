﻿namespace _03.AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animals = Console.ReadLine();
            switch (animals)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
