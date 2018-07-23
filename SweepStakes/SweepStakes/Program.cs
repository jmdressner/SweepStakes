using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Program
    {
        static void Main(string[] args)
        {
                           
            SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
            SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();

            Console.WriteLine("Welcome to Sweepstakes!");
            Console.WriteLine();
            Sweepstakes sweepstakes = new Sweepstakes("State Fair Tickets!");
            Console.WriteLine("Today's Sweepstake Give Away is: " + "'" + sweepstakes.name + "'");
            Console.WriteLine();

            sweepstakes.CreatePlayers(sweepstakes);

            sweepstakesQueueManager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("From the Queue");
            sweepstakes.RunSweepstakes(sweepstakesQueueManager);
            Console.WriteLine();

            sweepstakesStackManager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("From the Stack");
            sweepstakes.RunSweepstakes(sweepstakesStackManager);

            Console.ReadLine();
            
        }        
    }
}
