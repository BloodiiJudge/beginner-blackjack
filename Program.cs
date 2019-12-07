using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerBlackjack
{
    class Basics
    {
        //Holds our current state.
        public int currentState = 0;

        //Determines the number of players.
        protected int numPlayers;

        //Collects player input.
        protected string playInput;

        //The number dealt to the players and the dealer.
        protected int[] playersNumber;
        protected int dealerNumber;

        public void Start()
        {
            string players;

            Console.Write("Number of players: ");
            players = Console.ReadLine();
            if (Int32.TryParse(players, out numPlayers))
            {
                numPlayers = Convert.ToInt32(players);
                playersNumber = new int[numPlayers];
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid number.");
                Start();
            }
        }

        public void Deal()
        {
            for(int player = 0; player == numPlayers; player++)
            {
                playersNumber[player] = 
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Basic Blackjack class.
            Basics basic = new Basics();

            switch (basic.currentState)
            {
                case 0:
                    basic.Start();
                    break;
            }
        }
    }
}


