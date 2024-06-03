using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCpu;
            int randomInt;
            int scorePlayer = 0;
            int scoreCpu = 0;
            bool f = true;
           
            while (f)
            {
                scorePlayer = 0;
                scoreCpu = 0;
                while (scoreCpu < 2 && scorePlayer < 2)
                {
                    Console.Write("Choose Between Rock,Paper and Scissors:   ");
                    inputPlayer = (Console.ReadLine()).ToUpper();
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            inputCpu = "Rock";
                            Console.WriteLine("Computer Chooses ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!");
                            //    Console.WriteLine(" ");
                            }
                            else if (inputPlayer == "PAPER")
                            {

                                Console.WriteLine("Player Wins!!");
                             //   Console.WriteLine(" ");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer Wins!!");
                              //  Console.WriteLine(" ");
                                scoreCpu++;
                            }
                            Console.WriteLine("Computer : {0} , Player : {1}", scoreCpu, scorePlayer);
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            inputCpu = "Paper";
                           // Console.WriteLine("Computer : {0} , Player : {1}", scoreCpu, scorePlayer);
                            Console.WriteLine("Computer Chooses PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer Wins!!");
                                scoreCpu++;
                                // Console.WriteLine(" ");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Draw!!");
                             //   Console.WriteLine(" ");
                                
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player Wins!!");
                                //  Console.WriteLine(" ");
                                scorePlayer++;
                            }
                            
                            Console.WriteLine("Computer : {0} , Player : {1}", scoreCpu, scorePlayer);
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            inputCpu = "Scissors";
                            //Console.WriteLine("Computer : {0} , Player : {1}", scoreCpu, scorePlayer);
                            Console.WriteLine("Computer Chooses SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player Wins!!");
                                //  Console.WriteLine(" ");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer Wins!!");
                                //  Console.WriteLine(" ");
                                scoreCpu++;

                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Draw!!");
                              //  Console.WriteLine(" ");
                                //scoreCpu++;
                            }
                            Console.WriteLine("Computer : {0} , Player : {1}", scoreCpu, scorePlayer);
                            Console.WriteLine(" ");
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                    if (scorePlayer == 2)
                    {
                        Console.WriteLine("Hurray!!!!!Player Won");
                    }
                    else if (scoreCpu == 2)
                    {
                        Console.WriteLine("Alas!!!!!Computer Won");
                    }

                }
                Console.WriteLine("Do you want to play Again???YES/NO");
                string inp;
                inp = Console.ReadLine().ToUpper();
                if(inp == "YES")
                {
                    f = true;
                }
                else
                {
                    f = false;
                    break;
                }
            }
        }
    }
}