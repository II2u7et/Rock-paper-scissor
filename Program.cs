using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII_Q3
{
    class Program
    {

        static void Main(string[] args)
        {
            Rock rock = new Rock( 10, 'r');
            Paper paper = new Paper(10, 'p');
            Scissor scissor = new Scissor(10, 's');
            

            Console.WriteLine("Welcome to R-P-S game ( press anykey to continue)");
            Console.WriteLine("Or press 'Esc' to exit");
            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                /*
                Random rnd = new Random();
                int computer = rnd.Next(1, 3); */
                char against;
                

                Console.WriteLine("Make a choice for opponent");
                Console.WriteLine("r - Rock");
                Console.WriteLine("p - Paper");
                Console.WriteLine("s - Scissor");
                string num = Console.ReadLine();
                against = char.Parse(num);
                /*
                if (computer.Equals(1))
                {
                    against = 'r';
                }
                else if (computer.Equals(2))
                {
                    against = 'p';
                }
                else
                {
                    against = 's';
                }
                */
                Console.WriteLine("Make a choice");
                Console.WriteLine("r - Rock");
                Console.WriteLine("p - Paper");
                Console.WriteLine("s - Scissor");

                Console.WriteLine("Your choice");
                char choice = char.ToLower(char.Parse(Console.ReadLine()));

                Console.Clear();

                
                while ((choice != 'r') && (choice != 's') && (choice != 'p'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong option. Re-enter your choice!");
                    Console.ResetColor();
                    Console.WriteLine("Make a choice");
                    Console.WriteLine("r - Rock");
                    Console.WriteLine("p - Paper");
                    Console.WriteLine("s - Scissor");
                    Console.WriteLine("Your choice");
                    choice = char.ToLower(char.Parse(Console.ReadLine()));
                    Console.Clear();
                } 
                

                Console.WriteLine("You choose: " + returnN(choice));
                Console.WriteLine("Computer: " + returnN(against)); 
                Console.WriteLine("\n Result: ");


                if (against.Equals(choice) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\t Draw =.=");
                    Console.ResetColor();
                }
                else
                {
                    
                    switch (choice)
                    { 
                        case 'r':
                            {
                                if (against == 's')
                                {
                                    result(rock.fight(scissor));
                                }
                                else
                                {
                                    result(rock.fight(paper));
                                }
                                break;
                            }
                        case 'p':
                            {
                                if (against == 'r')
                                {
                                    result(paper.fight(rock));
                                }
                                else
                                {
                                    result(paper.fight(scissor));
                                }
                                break;
                            }
                        case 's':
                            {
                                if (against == 'p')
                                {
                                    result(scissor.fight(paper));
                                }
                                else
                                {
                                    result(scissor.fight(rock));
                                }
                                break;
                            }
                    }
                }

                Console.WriteLine("\n Continue?? or press 'Esc' to exit: ");
                key = Console.ReadKey(true);
                Console.Clear();
            }
        }
        static void result(Boolean input)
        {
            if (input == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t You win ^.^ ");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t  You Lose :P");
                Console.ResetColor();
            }
        }

        static string returnN(char input)
        {
            if (input == 'r') { return " ROCK"; }
            else if (input == 'p') { return " PAPPER"; }
            else { return "SCISSOR"; }
        }
    }
}
