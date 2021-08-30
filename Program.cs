using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
   Console.Clear();
            Console.WriteLine("Hey there buddy, what's your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
            
            bool playing = true;
            while(playing){
Console.WriteLine("Would you care to play a game? (y/n)");


                var choice = Console.ReadKey().KeyChar;
                if(choice == 'n'){
                    playing = false;
                }
                else{

                Console.Clear();
      Console.WriteLine("Pick your weapon; Rock, Paper or Scissors?");
      Console.Write("Player Choice: ");
      string playerChoice = Console.ReadLine();
      Console.WriteLine("You picked " +  playerChoice + " therefore, you win!");
                }


            
            }
        }
    }
}
