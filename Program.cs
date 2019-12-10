//Resources:
//https://codereview.stackexchange.com/questions/60314/console-blackjack-game
//12/10/19

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerBlackjack
{
    public enum Suit
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Suit suit;
        public Face face;
        public int value;
    }

    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            
        }

        public void Start()
        {
            cards = new List<Card>();

            for (int i = 0; i < Enum.GetNames(typeof(Suit)).Length; i++)
            {
                for (int j = 0; j <= Enum.GetNames(typeof(Face)).Length; j++)
                {
                    cards.Add(new Card() { suit = (Suit)i, face = (Face)j });

                    if(j <= 8)
                    {
                        cards[cards.Count - 1].value = j + 1;
                    }
                    else
                    {
                        cards[cards.Count - 1].value = 10;
                    }
                }
            }
        }
    }
    
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


