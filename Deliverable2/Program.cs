// See https://aka.ms/new-console-template for more information
using System;
using static System.Formats.Asn1.AsnWriter;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        bool Valid = false;
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string Name = Console.ReadLine();
        Console.WriteLine("Welcome " + Name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        while (!Valid)
        {
            string Input = Console.ReadLine();
            if (Input.ToLower() == "no")
            {
                Console.WriteLine("You are a coward " + Name);
                Valid = true;
            }
            else if (Input.ToLower() == "yes")
            {
                Valid = true;
                {
                    int Score = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Heads or tails?");
                        Random rnd = new Random();
                        bool Choice = false;
                        int Face = rnd.Next(0, 2);
                        while (!Choice)
                        {
                            Input = Console.ReadLine();
                            if (Input.ToLower() == "tails")
                            {
                                Choice = true;
                                if (Face == 0)
                                {
                                    Console.WriteLine("Correct!");
                                    Score++;
                                }
                                else
                                    Console.WriteLine("Wrong!");
                            }
                            else if (Input.ToLower() == "heads")
                            {
                                Choice = true;
                                if (Face == 1)
                                {
                                    Console.WriteLine("Correct!");
                                    Score++;
                                }
                                else
                                    Console.WriteLine("Wrong!");
                            }
                            else
                            {
                                Console.WriteLine("Please enter 'Heads' or 'Tails'");
                                Choice = false;
                            }
                        }
                    }
                    Console.WriteLine("Thank you " + Name + ". You got a score of " + Score + "!");
                }
            }
            else
            {
                Console.WriteLine("Please enter, 'Yes' or 'No'");

            }
        }
    }
}