using System;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Team
    {
        string teamName;
        int noOfPlayers;
        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }
        public void AddPlayer(int count)
        {
            this.noOfPlayers += count;
        }
        public bool RemovePlayer(int count)
        {
            this.noOfPlayers -= count;

            if (this.noOfPlayers < 0)
            {
                return false;
            }
            return true;
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
        {
        }
        public void ChangeTeamName(string teamName)
        {
            this.teamName = teamName;
        }

    }
}
