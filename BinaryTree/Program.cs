using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                var tree = new BinaryTree(); //creates the Binary Tree in the exercise
                int nodeToCheck = 0;
                bool answerValid = false;

                while (!answerValid)
                {
                    Console.Clear();
                    Console.WriteLine(@"     8    ");
                    Console.WriteLine(@"   /  \   ");
                    Console.WriteLine(@"  3    10 ");
                    Console.WriteLine(@" / \     \ ");
                    Console.WriteLine(@"1   6     14");
                    Console.WriteLine(@"   / \    / ");
                    Console.WriteLine(@"  4   7  13 ");
                    Console.Write("Enter node to check: ");
                    string answer = Console.ReadLine();

                    if (int.TryParse(answer, out nodeToCheck) && tree.Nodes.ContainsKey(nodeToCheck))
                    {
                        answerValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input (Might not be a number or is not in the tree.)");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }

                Node nodeObject = tree.Nodes[nodeToCheck];
                Console.WriteLine($"root: {nodeToCheck} has total of {Node.Total(nodeObject)}"); // Node.Total(nodeObject) gets the total
                Console.WriteLine("Try again? [Y/N]");
                var key = Console.ReadKey();
                exit = key.Key == ConsoleKey.Y ? false : true;

            }
            
            
        }



       
    }

}
