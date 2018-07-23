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
                    Console.WriteLine(person.Key + " - " + person.Value);
            }
        }
    }
}
