using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            bool flag2 = true;

            int counter = 3;

            Console.WriteLine($"Greetings traveler! What's your name?");

            string characterName = Console.ReadLine();

            Console.WriteLine($"Hi, {characterName}! Are you ready to get the treasures guarded by the sphinx? (type y or n):");
            
            while (flag)
            {
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    Console.WriteLine($"Greate! Then follow me.");

                    flag = false;

                }
                else if (answer == "n")
                {
                    Console.WriteLine($"How dare you spend my time? *Takes out a knife and kills you.* The end.");

                    Console.ReadLine();

                    return;
                }
                else
                {
                    Console.WriteLine($"Are you fucking deaf ? I asked: \"Are you ready to get the treasures guarded by the sphinx ?\"(type y or n):");
                }

            }

            Console.WriteLine($"After some time, Mahmoud brought you to the Sphinx. You see a huge figure.");

            Console.WriteLine($"\nI'm the Sphinx! If you want to get my treasures, then answer my riddle, otherwise I will kill you! You will have 3 attempts to answer correctly. \nThat's my question: \n\n\"What kind of creature walks on four legs in the morning, two in the afternoon and three in the evening?\"");

            while (flag2 && counter > 0)
            {
                counter--;

                string answer2 = Console.ReadLine().ToLower();

                if (answer2 == "human")
                {
                    Console.WriteLine($"You are smart {characterName}. You can take my treasures. *Sphinx flies away.* The end.");

                    Console.ReadLine();

                    return;
                }
                else if (counter > 0)
                {

                    Console.WriteLine($"Try again, you have {counter} attempts left");

                }
            }

            Console.WriteLine($"You will not receive my treasures, HUMAN! *Sphinx bites off your head.*");

            Console.ReadLine();

        }
    }
}
