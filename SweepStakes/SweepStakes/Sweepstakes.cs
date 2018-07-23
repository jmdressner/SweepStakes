using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public string name;
        public Random random;
        public int count;
       

        public Sweepstakes(string name)
        {
            this.name = name;
            this.random = new Random();
            this.count = 0;
        }

        public Contestant CreateContestant(string firstName, string lastName, string email)
        {
            count++;
            Contestant contestant = new Contestant(firstName, lastName, email, count);
            return contestant;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public string PickWinner()
        {
            int winner = random.Next(1, count);
            foreach (KeyValuePair<int, Contestant> person in contestants)
            {
                if (winner == person.Key)
                Console.WriteLine(person.Value.firstName + " " + person.Value.lastName);
            }

            return "Is the winner!";
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> person in contestants)
            {
                    Console.WriteLine(person.Value.registrationNumber + " - " + person.Value.firstName + " " + person.Value.lastName + "   " + person.Value.email);
            }
        }

        public void CreatePlayers(Sweepstakes sweepstakes)
        {
            Console.WriteLine("The contestants are:");
            Contestant contestant = sweepstakes.CreateContestant("Julie", "D.", "jd@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Brian", "D.", "bd@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Audrey", "E.", "ae@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Naomi", "J.", "nj@gmail.comm");
            sweepstakes.RegisterContestant(contestant);
            contestant = sweepstakes.CreateContestant("Tonje", "N.", "tn@gmail.com");
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
            Console.WriteLine();
        }

        public void RunSweepstakes(ISweepstakesManager sweepstakesManager)
        {
            Sweepstakes sweepstakes = sweepstakesManager.GetSweepstakes();
            string winner = sweepstakes.PickWinner();
            Console.WriteLine(winner);
        }
    }
}
