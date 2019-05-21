using System;

namespace OptimalStrategyOfAGame_FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optimal Strategy of a game!");
            Console.WriteLine("---------------------------");

            try{
                int[] array = InputProcessor.GetArrayFromInput();
                Console.WriteLine("Amount won by Winner is "+InputProcessor.PrintWinAmount(array));
            }
            catch (Exception exception) {
                Console.WriteLine("Main: Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
