using  System;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace RollDice
{
    public class Players

    {

        public static int P1R1;
        public static int P2R1;
        public static int P3R1;

        public static int P1R2;
        public static int P2R2;
        public static int P3R2;

        public static int P1R3;
        public static int P2R3;
        public static int P3R3;

        public static int P1R4;
        public static int P2R4;
        public static int P3R4;

        public static int P1R5;
        public static int P2R5;
        public static int P3R5;

        

        static void Main(string[] args)
        {



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player 1 enter your name:");
            string Player_1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player 2 enter your name:");
            string Player_2 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player 3 enter your name:");
            string Player_3 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Names of three players are:\n{Player_1}\n{Player_2}\n{Player_3}\n\n");



            List<int> Listt = new List<int>();




            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Dice Rolls:\n");


            ///round 1   
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRound 1\n");
            for (int i = 0; i < 3; i++)
            {
                Random rn = new Random();
                int numbers1= rn.Next(1,7);
                


                if (i==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Player_1}"+ ":"+ numbers1);
                    Listt.Add(numbers1);

                }
                else if(i==1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{Player_2}" + ":" + numbers1);
                    Listt.Add(numbers1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Player_3}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
            }



            ///round 2  
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRound 2\n");
            for (int i = 0; i < 3; i++)
            {
                Random rn = new Random();
                int numbers1 = rn.Next(1, 7);



                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Player_1}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{Player_2}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Player_3}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
            }



            ///round 3 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRound 3\n");
            for (int i = 0; i < 3; i++)
            {
                Random rn = new Random();
                int numbers1 = rn.Next(1, 7);



                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Player_1}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Player_2}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Player_3}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
            }



            ///round 4 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRound 4\n");
            for (int i = 0; i < 3; i++)
            {
                Random rn = new Random();
                int numbers1 = rn.Next(1, 7);



                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Player_1}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{Player_2}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Player_3}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
            }



            ///round 5 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRound 5\n");
            for (int i = 0; i < 3; i++)
            {
                Random rn = new Random();
                int numbers1 = rn.Next(1, 7);



                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Player_1}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{Player_2}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Player_3}" + ":" + numbers1);
                    Listt.Add(numbers1);

                }



            }


           
            Console.WriteLine("\n");


            P1R1 = Listt[0];
            P2R1 = Listt[1];
            P3R1 = Listt[2];

            P1R2 = Listt[3];
            P2R2 = Listt[4];
            P3R2 = Listt[5];

            P1R3 = Listt[6];
            P2R3 = Listt[7];
            P3R3 = Listt[8];

            P1R4 = Listt[9];
            P2R4 = Listt[10];
            P3R4 = Listt[11];

            P1R5 = Listt[12];
            P2R5 = Listt[13];
            P3R5 = Listt[14];


            int Player_1_total = P1R1 + P1R2 + P1R3 + P1R4 + P1R5;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Player_1} total points are : " + Player_1_total );

            int Player_2_total= P2R1 + P2R2 + P2R3 + P2R4 + P2R5 ;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Player_2} total points are : " + Player_2_total);

            int Player_3_total= P3R1 + P3R2 + P3R3 + P3R4 + P3R5;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Player_3} total points are : " + Player_3_total);


            Console.WriteLine("\n");


            if ( Player_1_total > Player_2_total && Player_1_total > Player_3_total)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Player_1} has won the game with the highest points");
            }

            else if(Player_2_total> Player_1_total && Player_2_total > Player_3_total)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{Player_2} has won the game with the highest points");
            
            }

            else if(Player_3_total> Player_1_total && Player_3_total > Player_2_total)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Player_3} has won the game with the highest points.");


            }

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The game has tied. Relaunch to play again...");
            }


            Console.ForegroundColor = ConsoleColor.White;
        }


    }


}


