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

            Sweepstakes sweepstakes = new Sweepstakes("State Fair Tickets Give Away!");

            CreatePlayers(sweepstakes);

            sweepstakesQueueManager.InsertSweepstakes(sweepstakes);
            sweepstakesStackManager.InsertSweepstakes(sweepstakes);

            Console.WriteLine("Queue");
            RunSweepstakes(sweepstakesQueueManager);
            Console.WriteLine();
            Console.WriteLine("Stack");
            RunSweepstakes(sweepstakesStackManager);

            Console.ReadLine();
            
        }

        private static void RunSweepstakes(ISweepstakesManager sweepstakesManager)
        {
            Sweepstakes sweepstakes = sweepstakesManager.GetSweepstakes();
            Console.WriteLine("Running sweepstakes for "+ "'"+ sweepstakes.name + "'");

            string winner = sweepstakes.PickWinner();
            Console.WriteLine(winner);
        }

        private static void CreatePlayers(Sweepstakes sweepstakes)
        {
            Contestant contestant = sweepstakes.CreateContestant("Julie", "Dressner", "jmd@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Brian", "D", "bd@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Audrey", "E", "ae@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Naomi", "J", "nj@gmail.comm");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Tonje", "N", "tn@gmail.com");
            sweepstakes.RegisterContestant(contestant);
        }
    }
    
}
