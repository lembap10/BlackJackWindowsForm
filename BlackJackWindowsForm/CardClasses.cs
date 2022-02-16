/*
 * Card Classes holds three classes of key items in a game of blackjack
 * The class Card represents a playing Card and is capable of returning an image of the card
 * The BlackJackHand class represents a hand of cards 
 * The SixDeck class represents a shoe of cards in blackjack
 * 
 * Made By : Baptiste Lemercier
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackWindowsForm
{
    /*
     * public class representing a playing card
     * holds an integer representing the rank and an int representing the suit
     * (0-12) = Ace - King
     * (0-3) = Spade, Heart, Clubs, Diamonds
     */
    public class Card
    {
        public int rank;
        public int suit;

        // Return the generic score value of a card (10 for a face) (11 for an ace)
        public int cardValue()
        {
            if (rank == 0)
            {
                return 11;
            }
            else if (rank <= 8)
            {
                return rank + 1;
            }
            else return 10;
        }

        // The CardToImage Function returns the image value of a card
        // Image value is pulled from the Property Folder
        public Image CardToImage()
        {
            switch ((13 * suit) + rank)
            {
                case 0:
                    return BlackJackWindowsForm.Properties.Resources.ace_of_spades2;
                case 1:
                    return BlackJackWindowsForm.Properties.Resources._2_of_spades;
                case 2:
                    return BlackJackWindowsForm.Properties.Resources._3_of_spades;
                case 3:
                    return BlackJackWindowsForm.Properties.Resources._4_of_spades;
                case 4:
                    return BlackJackWindowsForm.Properties.Resources._5_of_spades;
                case 5:
                    return BlackJackWindowsForm.Properties.Resources._6_of_spades;
                case 6:
                    return BlackJackWindowsForm.Properties.Resources._7_of_spades;
                case 7:
                    return BlackJackWindowsForm.Properties.Resources._8_of_spades;
                case 8:
                    return BlackJackWindowsForm.Properties.Resources._9_of_spades;
                case 9:
                    return BlackJackWindowsForm.Properties.Resources._10_of_spades;
                case 10:
                    return BlackJackWindowsForm.Properties.Resources.jack_of_spades2;
                case 11:
                    return BlackJackWindowsForm.Properties.Resources.queen_of_spades2;
                case 12:
                    return BlackJackWindowsForm.Properties.Resources.king_of_spades2;
                case 13:
                    return BlackJackWindowsForm.Properties.Resources.ace_of_hearts;
                case 14:
                    return BlackJackWindowsForm.Properties.Resources._2_of_hearts;
                case 15:
                    return BlackJackWindowsForm.Properties.Resources._3_of_hearts;
                case 16:
                    return BlackJackWindowsForm.Properties.Resources._4_of_hearts;
                case 17:
                    return BlackJackWindowsForm.Properties.Resources._5_of_hearts;
                case 18:
                    return BlackJackWindowsForm.Properties.Resources._6_of_hearts;
                case 19:
                    return BlackJackWindowsForm.Properties.Resources._7_of_hearts;
                case 20:
                    return BlackJackWindowsForm.Properties.Resources._8_of_hearts;
                case 21:
                    return BlackJackWindowsForm.Properties.Resources._9_of_hearts;
                case 22:
                    return BlackJackWindowsForm.Properties.Resources._10_of_hearts;
                case 23:
                    return BlackJackWindowsForm.Properties.Resources.jack_of_hearts;
                case 24:
                    return BlackJackWindowsForm.Properties.Resources.queen_of_hearts;
                case 25:
                    return BlackJackWindowsForm.Properties.Resources.king_of_hearts;
                case 26:
                    return BlackJackWindowsForm.Properties.Resources.ace_of_clubs;
                case 27:
                    return BlackJackWindowsForm.Properties.Resources._2_of_clubs;
                case 28:
                    return BlackJackWindowsForm.Properties.Resources._3_of_clubs;
                case 29:
                    return BlackJackWindowsForm.Properties.Resources._4_of_clubs;
                case 30:
                    return BlackJackWindowsForm.Properties.Resources._5_of_clubs;
                case 31:
                    return BlackJackWindowsForm.Properties.Resources._6_of_clubs;
                case 32:
                    return BlackJackWindowsForm.Properties.Resources._7_of_clubs;
                case 33:
                    return BlackJackWindowsForm.Properties.Resources._8_of_clubs;
                case 34:
                    return BlackJackWindowsForm.Properties.Resources._9_of_clubs;
                case 35:
                    return BlackJackWindowsForm.Properties.Resources._10_of_clubs;
                case 36:
                    return BlackJackWindowsForm.Properties.Resources.jack_of_clubs2;
                case 37:
                    return BlackJackWindowsForm.Properties.Resources.queen_of_clubs2;
                case 38:
                    return BlackJackWindowsForm.Properties.Resources.king_of_clubs2;
                case 39:
                    return BlackJackWindowsForm.Properties.Resources.ace_of_diamonds;
                case 40:
                    return BlackJackWindowsForm.Properties.Resources._2_of_diamonds;
                case 41:
                    return BlackJackWindowsForm.Properties.Resources._3_of_diamonds;
                case 42:
                    return BlackJackWindowsForm.Properties.Resources._4_of_diamonds;
                case 43:
                    return BlackJackWindowsForm.Properties.Resources._5_of_diamonds;
                case 44:
                    return BlackJackWindowsForm.Properties.Resources._6_of_diamonds;
                case 45:
                    return BlackJackWindowsForm.Properties.Resources._7_of_diamonds;
                case 46:
                    return BlackJackWindowsForm.Properties.Resources._8_of_diamonds;
                case 47:
                    return BlackJackWindowsForm.Properties.Resources._9_of_diamonds;
                case 48:
                    return BlackJackWindowsForm.Properties.Resources._10_of_diamonds;
                case 49:
                    return BlackJackWindowsForm.Properties.Resources.jack_of_diamonds2;
                case 50:
                    return BlackJackWindowsForm.Properties.Resources.queen_of_diamonds2;
                case 51:
                    return BlackJackWindowsForm.Properties.Resources.king_of_diamonds2;
                default:
                    return BlackJackWindowsForm.Properties.Resources.black_joker;

            }
        }
    }

    /*
     * public Class representing a player hand
     * keeps track of the highest value possible for that hand
     */
    public class BlackJackHand
    {
        public int handScore;      // keeps track of the score of the hand
        public int numCards;       // keeps track of how many cards are in the hand
        public int isSoft;         // int variable to consider how many 11-valued aces are in the hand
        // Variable to store the first two cards, in case a split occurs
        public Card Card1 = new Card();
        public Card Card2 = new Card ();

        public BlackJackHand()
        {
            handScore = 0;
            numCards = 0;
            isSoft = 0;
        }

        /*
         * Adds a card to the current hand and updates the players hand attributes
         */
        public void addCard(Card card)
        {
            numCards++;
            if (numCards == 1)
            {
                Card1 = card;
            }
            if (numCards == 2)
            {
                Card2 = card;
            }
            if (card.rank == 0)
            {
                handScore += 11;
                isSoft += 1;
            }
            else if (card.rank > 0 && card.rank < 10)
            {
                handScore += (card.rank + 1);
            }
            else if (card.rank < 13)
            {
                handScore += 10;
            }
            else
            {
                handScore -= 100;
            }
            // Handling a soft hand
            while (isSoft > 0 && handScore > 21)
            {
                handScore -= 10;
                isSoft--;
            }
        }
        // Resets all Hand attributes to 0
        public void clearHand()
        {
            handScore = 0;
            numCards = 0;
            isSoft = 0;
        }

        // check if the cards can be split
        public bool canSplit(){
            if (Card1.rank == Card2.rank)
            {
                return true;
            }
            return false;
        }

        public bool isBlackjack()
        {
            if (handScore == 21 && numCards == 2)
            {
                return true;
            }
            return false;
        }
    }

    // class representing six decks shuffled together
    public class sixDeck
    {
        public Card[] shoe;
        public int cardsLeft;
        public bool isDeckAlmostGone;

        // Constructor initializing each of the 312 cards
        public sixDeck()
        {
            this.shoe = new Card[312];
            this.cardsLeft = 312;
            this.isDeckAlmostGone = false;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    int index = 13 * i + j;
                    this.shoe[index] = new Card();
                    this.shoe[index].rank = j;
                    this.shoe[index].suit = (i % 4);
                }
            }
        }

        //Shuffling algorhithm, switch the last card in the deck to a random position in the deck 
        public void shuffleDeck()
        {
            Random random = new Random();
            for (int i = 0; i < 312; i++)
            {
                int rand = random.Next(312 - i);
                Card temp = new Card();
                temp = shoe[311 - i];
                shoe[311 - i] = shoe[rand];
                shoe[rand] = temp;
            }
        }

        // returns the "top" card of the deck and update the remaining total of cards
        public Card dealCard()
        {
            cardsLeft--;
            if (cardsLeft < 40)
            {
                isDeckAlmostGone = true;
            }
            if (cardsLeft == -1)
            {
                isDeckAlmostGone = false;
                shuffleDeck();
                cardsLeft = 311;
            }
            return shoe[cardsLeft];
        }
    }

    /*
     * Class which represents a blackjack game being played
     */
    public class BlackJack
    {
        private sixDeck shoe;
        public BlackJackHand playerHand;
        private BlackJackHand dealerHand;
        public int numPlayerHits;
        public int numDealerHits;

        public BlackJack()
        {
            shoe = new sixDeck();
            shoe.shuffleDeck();
            playerHand = new BlackJackHand();
            dealerHand = new BlackJackHand();
            numPlayerHits = 0;
            numDealerHits = 0;
        }

        public void ResetHands()
        {
            playerHand.clearHand();
            dealerHand.clearHand();
            numPlayerHits = 0;
            numDealerHits = 0;
            // shuffles the deck if it is almost out of cards
            if (shoe.isDeckAlmostGone)
            {
                shoe.shuffleDeck();
                shoe.cardsLeft = 312;
                shoe.isDeckAlmostGone = false;
            }
        }
        
        // Deals a card from the deck to the player's hand
        // Returns a picture of the dealt card
        public Image DealPlayerCard()
        {
            numPlayerHits++;
            Card dealtCard = shoe.dealCard();
            playerHand.addCard(dealtCard);
            return dealtCard.CardToImage();
        }

        // Deals a card from the deck to the dealer's hand
        // Returns a picture of the dealt Card
        public Image DealDealerCard()
        {
            numDealerHits++;
            Card dealtCard = shoe.dealCard();
            dealerHand.addCard(dealtCard);
            return dealtCard.CardToImage();
        }

        /*
         * Returns true if dealer should still hit
         * Uses the rule of hitting until a hard 17 or soft 18
         */
        public bool ShouldDealerHit()
        {
            if (dealerHand.handScore < 17)
            {
                return true;
            }
            else if (dealerHand.isSoft > 0 && dealerHand.handScore == 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * Evaluates the winner of the hand between dealer and player
         * returns an integer based on 
         */
        public int EvaluateWinner()
        {
            int returnVal = 0;  // integer symbolizing the payout value of the player
            // Case 1: Player bust
            if (playerHand.handScore > 21)
            {
                returnVal = -1;
            }
            // Case 2: Dealer bust
            else if (dealerHand.handScore > 21)
            {
                returnVal = 1;
            }
            else if (dealerHand.handScore == playerHand.handScore)
            {
                returnVal = 0;
            }
            else if (dealerHand.handScore < playerHand.handScore)
            {
                returnVal = 1;
            }
            else
            {
                returnVal = -1;
            }
            return returnVal;
        }
        // returns dealer score
        public int DealerScore()
        {
            return dealerHand.handScore;
        }
        // returns the player score
        public int PlayerScore()
        {
            return playerHand.handScore;
        }

        // returns if the player has a blackjack
        public bool isPlayerBlackJack()
        {
            return playerHand.isBlackjack();
        }
        // returns if the dealer has a blackjack
        public bool isDealerBlackJack()
        {
            return dealerHand.isBlackjack();
        }
        public bool canSplit()
        {
            if (playerHand.Card1.cardValue() == playerHand.Card2.cardValue())
            {
                return true;
            }
            else return false;
        }
    }
}
