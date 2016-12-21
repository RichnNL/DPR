using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StateApplication
{
    class Deck
    {
        Random random;
        List<Card> cards;
        List<int> selected;
        public Deck()
        {
            random = new Random();
            selected = new List<int>();
            cards = new List<Card>();
            intiateDesk();
        }
        private void intiateDesk()
        {
            cards.Clear();
            Card ace_club = new Card(Properties.Resources.ace_of_clubs, 14);
            cards.Add(ace_club);
            Card ace_diamond = new Card(Properties.Resources.ace_of_diamonds, 14);
            cards.Add(ace_diamond);
            Card ace_heart = new Card(Properties.Resources.ace_of_hearts, 14);
            cards.Add(ace_heart);
            Card ace_spade = new Card(Properties.Resources.ace_of_spades, 14);
            cards.Add(ace_spade);
            Card jack_club = new Card(Properties.Resources.jack_of_clubs, 11);
            cards.Add(jack_club);
            Card jack_diamond = new Card(Properties.Resources.jack_of_diamonds, 11);
            cards.Add(jack_diamond);
            Card jack_heart = new Card(Properties.Resources.jack_of_hearts, 11);
            cards.Add(jack_heart);
            Card jack_spade = new Card(Properties.Resources.jack_of_spades, 11);
            cards.Add(jack_spade);
            Card king_club = new Card(Properties.Resources.king_of_clubs, 13);
            cards.Add(king_club);
            Card king_diamond = new Card(Properties.Resources.king_of_diamonds, 13);
            cards.Add(king_diamond);
            Card king_heart = new Card(Properties.Resources.king_of_hearts, 13);
            cards.Add(king_heart);
            Card king_spade = new Card(Properties.Resources.king_of_spades, 13);
            cards.Add(king_spade);
            Card queen_club = new Card(Properties.Resources.queen_of_clubs, 12);
            cards.Add(queen_club);
            Card queen_diamonds = new Card(Properties.Resources.queen_of_diamonds, 12);
            cards.Add(queen_diamonds);
            Card queen_hearts = new Card(Properties.Resources.queen_of_hearts, 12);
            cards.Add(queen_hearts);
            Card queen_spades = new Card(Properties.Resources.queen_of_spades, 12);
            cards.Add(queen_spades);
            Card _10_club = new Card(Properties.Resources._10_of_clubs, 10);
            cards.Add(_10_club);
            Card _10_diamond = new Card(Properties.Resources._10_of_diamonds, 10);
            cards.Add(_10_diamond);
            Card _10_heart = new Card(Properties.Resources._10_of_hearts, 10);
            cards.Add(_10_heart);
            Card _10_spades = new Card(Properties.Resources._10_of_spades, 10);
            cards.Add(_10_spades);
            Card _2_club = new Card(Properties.Resources._2_of_clubs, 2);
            cards.Add(_2_club);
            Card _2_diamond = new Card(Properties.Resources._2_of_diamonds, 2);
            cards.Add(_2_diamond);
            Card _2_heart = new Card(Properties.Resources._2_of_hearts, 2);
            cards.Add(_2_heart);
            Card _2_spade = new Card(Properties.Resources._2_of_spades, 2);
            cards.Add(_2_spade);
            Card _3_club = new Card(Properties.Resources._3_of_clubs, 3);
            cards.Add(_3_club);
            Card _3_diamond = new Card(Properties.Resources._3_of_diamonds, 3);
            cards.Add(_3_diamond);
            Card _3_heart = new Card(Properties.Resources._3_of_hearts, 3);
            cards.Add(_3_heart);
            Card _3_spades = new Card(Properties.Resources._3_of_spades, 3);
            cards.Add(_3_spades);
            Card _4_club = new Card(Properties.Resources._4_of_clubs, 4);
            cards.Add(_4_club);
            Card _4_diamond = new Card(Properties.Resources._4_of_diamonds, 4);
            cards.Add(_4_diamond);
            Card _4_hearts = new Card(Properties.Resources._4_of_hearts, 4);
            cards.Add(_4_hearts);
            Card _4_spades = new Card(Properties.Resources._4_of_spades, 4);
            cards.Add(_4_spades);
            Card _5_club = new Card(Properties.Resources._5_of_clubs, 5);
            cards.Add(_5_club);
            Card _5_diamond = new Card(Properties.Resources._5_of_diamonds, 5);
            cards.Add(_5_diamond);
            Card _5_heart = new Card(Properties.Resources._5_of_hearts, 5);
            cards.Add(_5_heart);
            Card _5_spade = new Card(Properties.Resources._5_of_spades, 5);
            cards.Add(_5_spade);
            Card _6_club = new Card(Properties.Resources._6_of_clubs, 6);
            cards.Add(_6_club);
            Card _6_diamond = new Card(Properties.Resources._6_of_diamonds, 6);
            cards.Add(_6_diamond);
            Card _6_heart = new Card(Properties.Resources._6_of_hearts, 6);
            cards.Add(_6_heart);
            Card _6_spade = new Card(Properties.Resources._6_of_spades, 6);
            cards.Add(_6_spade);
            Card _7_spade = new Card(Properties.Resources._7_of_spades, 7);
            cards.Add(_6_spade);
            Card _7_diamond = new Card(Properties.Resources._7_of_diamonds, 7);
            cards.Add(_7_diamond);
            Card _7_heart = new Card(Properties.Resources._7_of_hearts, 7);
            cards.Add(_7_heart);
            Card _7_club = new Card(Properties.Resources._7_of_clubs, 7);
            cards.Add(_7_club);
            Card _8_club = new Card(Properties.Resources._8_of_clubs, 8);
            cards.Add(_8_club);
            Card _8_diamond = new Card(Properties.Resources._8_of_diamonds, 8);
            cards.Add(_8_diamond);
            Card _8_heart = new Card(Properties.Resources._8_of_hearts ,8);
            cards.Add(_8_heart);
            Card _8_spades = new Card(Properties.Resources._8_of_spades, 8);
            cards.Add(_8_spades);
            Card _9_clubs = new Card(Properties.Resources._9_of_clubs, 9);
            cards.Add(_9_clubs);
            Card _9_diamomd = new Card(Properties.Resources._9_of_diamonds, 9);
            cards.Add(_9_diamomd);
            Card _9_heart = new Card(Properties.Resources._9_of_hearts, 9);
            cards.Add(_9_heart);
            Card _9_spades = new Card(Properties.Resources._9_of_spades, 9);
            cards.Add(_9_spades);









        }
        public void shuffle()
        {
            selected.Clear();
        }
        public Card pullCard()
        {
            int i = random.Next(0, 53);
            while (alreadySelected(i))
            {
                i = random.Next(0, 53);
            }
            return cards[i];
        }
        private bool alreadySelected(int i)
        {
            foreach(int num in selected)
            {
                if(num == i)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
