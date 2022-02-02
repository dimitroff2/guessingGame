using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
{


    //using a for loop to give user 4 chances to guess the number program will end after four
         for (int i = 4; i > 0; i--) 
             { 
                 // compares the guess to the secret number to see if its correct using an if statement.
                 
                 int SecretNumber = new Random().Next(0, 100);            
    
                 
                 

              string Guess = "Guess the Secret Number";
            Console.WriteLine(Guess);
            int num = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Guess" + num);
            if(SecretNumber == num)
            {
                Console.WriteLine("YOU WIN!");
                Environment.Exit(1);
            }
            else
            {
                if (num > SecretNumber )
                {
                    Console.WriteLine($"Number is too High {num}");
                }
                else
                {
                    Console.WriteLine($"Number is too Low {num}");
                }
                Console.WriteLine($"You're Wrong Tries Left {i -1} "  );

                
                
            }
            }


            
            

                           

                                                    

            
            
        }}}
    
    






