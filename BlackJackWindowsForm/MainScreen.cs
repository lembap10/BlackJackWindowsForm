namespace BlackJackWindowsForm
{
    public partial class MainScreen : Form
    {
        /*
         * Declaring useful variables to use in the interface and the actual game class
         */
        int playerBalance = 1000;
        int curBet = 5;
        string dialog = "Welcome, Please Enter Betting Amount. ";
        BlackJack game = new BlackJack ();
        private Image FaceDownCard;

        public MainScreen()
        {
            InitializeComponent();
            
            // Diabling Buttons to not be clicked yet
            HitButton.Enabled = false;
            StayButton.Enabled = false;
            DoubleButton.Enabled = false;

            // Allow to set the bet
            BetComfirmButton.Enabled = true;
            BetSlider.Enabled = true;
            FaceDownCard = BlackJackWindowsForm.Properties.Resources.card_back_red;
        }

        public void addDialog(string text)
        {
            LargeDialog.Text += text;
        }

        public void changeDialog (string text)
        {
            LargeDialog.Text = text;
        }

        // BetSlider value is changed
        private void BetSlider_ValueChanged(object sender, EventArgs e)
        {
            curBet = BetSlider.Value;
            CurBetLabel.Text = curBet.ToString() + " $";
        }

        // Updates the player count
        public void UpdatePlayerCount()
        {
            PlayerScoreLabel.Text = game.PlayerScore().ToString();
        }

        // Updates the dealer count
        public void UpdateDealerCount()
        {
            DealerScoreLabel.Text = game.DealerScore().ToString();
        }
        // checks what buttons to enable and whether the game should be ended
        public void EvaluateInitialCards()
        {
            if (game.isDealerBlackJack() && game.isPlayerBlackJack())
            {
                changeDialog("Tie, Both players have a blackjack");
                PlayerPayOut(0);
                ResetHands();
            }
            else if (game.isPlayerBlackJack())
            {
                changeDialog("Player wins with a blacjack");
                PlayerPayOut(1.5);
                ResetHands();
            }
            else if (game.isDealerBlackJack())
            {
                changeDialog("Player loses as dealer holds a blackjack");
                PlayerPayOut(-1);
                ResetHands();
            }
            else if (game.canSplit())
            {
                addDialog("\n  Split is available");
            }
        }
        // Bet is Comfirmed, which starts the game.
        private void BetComfirmButton_Click(object sender, EventArgs e)
        {
            // First verify that the bet is affordable
            if (curBet > playerBalance)
            {
                changeDialog("You must select a bet less than or equal to your current balance." +
                    "\n Your balance is currently " + playerBalance.ToString() + "$");
                return;
            }
            curBet =  BetSlider.Value;
            
            // Erase Previous Cards
            PlayerCard1.Image = null;
            PlayerCard2.Image = null;
            PlayerCard3.Image = null;
            PlayerCard4.Image = null;
            PlayerCard5.Image = null;
            PlayerCard6.Image = null;
            PlayerCard7.Image = null;
            DealerCard1.Image = null;
            DealerCard2.Image = null;
            DealerCard3.Image = null;
            DealerCard4.Image = null;
            DealerCard5.Image = null;
            DealerCard6.Image = null;
            DealerCard7.Image = null;

            // Reset dealer count image to 0
            UpdateDealerCount();

            // Dealing out each initial card
            FaceDownCard = game.DealDealerCard();
            DealerCard1.Image = BlackJackWindowsForm.Properties.Resources.card_back_red;
            DealerCard1.BringToFront();
            PlayerCard1.Image = game.DealPlayerCard();
            PlayerCard1.BringToFront();
            DealerCard2.Image = game.DealDealerCard();
            DealerCard2.BringToFront();
            PlayerCard2.Image = game.DealPlayerCard();
            PlayerCard2.BringToFront();

            // Disable Bet adjustment tool
            BetComfirmButton.Enabled = false;
            BetSlider.Enabled = false;

            // Update Player Score
            UpdatePlayerCount();
            

            // Enabling the buttons for specific game
            HitButton.Enabled = true;
            StayButton.Enabled = true;
            DoubleButton.Enabled = true;
            changeDialog("Please select your next action: \n  Hit: receive one more card \n  Stay: let the dealer play out");
            EvaluateInitialCards();
            
        }
        // Function to payout the player based on the provided multiplier
        // negative value shows a loss and a positive value shows a win, 0 is a tie
        public void PlayerPayOut(double multiplier)
        {
            playerBalance += (int) (curBet * multiplier);
            BalanceLabel.Text = playerBalance.ToString();
            if (playerBalance <= 0){
                changeDialog("No more money, game over");
            }
        }
        // Function to clear the current hands
        public void ResetHands()
        {
            game.ResetHands();
            HitButton.Enabled = false;
            StayButton.Enabled = false;
            DoubleButton.Enabled = false;

            // Allow to set the bet
            BetComfirmButton.Enabled = true;
            BetSlider.Enabled = true;
        }

        // Dealing out cards, include the visual representation of the new cards
        private void HitButton_Click(object sender, EventArgs e)
        {
            Image dealtCard = game.DealPlayerCard();
            PlayerScoreLabel.Text = game.PlayerScore().ToString();
            switch (game.numPlayerHits)
            {
                case 3:
                    PlayerCard3.Image = dealtCard;
                    PlayerCard3.BringToFront();
                    break;
                case 4:
                    PlayerCard4.Image= dealtCard;
                    PlayerCard4.BringToFront();
                    break;
                case 5:
                    PlayerCard5.Image = dealtCard;
                    PlayerCard5.BringToFront();
                    break;
                case 6:
                    PlayerCard6.Image = dealtCard;
                    PlayerCard6.BringToFront();
                    break;
                case 7:
                    PlayerCard7.Image = dealtCard;
                    PlayerCard7.BringToFront();
                    break;
                default:
                    pictureBox4.Image = dealtCard;
                    break;
            }
            if (game.numPlayerHits == 3)
            {
                DoubleButton.Enabled = false;
            }
            if (game.PlayerScore() >= 21)
            {
                FinishHands();
            }
        }
        private void StayButton_Click(object sender, EventArgs e)
        {
            FinishHands();
        }
        public void FinishHands()
        {
            // Evaluate Dealer Hand
                // Reveal FaceDown card value
            DealerCard1.Image = FaceDownCard;
                // Deal out Remaining cards if needed
                // Adding the card to its appropriate spot
            while (game.ShouldDealerHit())
            {
                Image dealtCard = game.DealDealerCard();
                switch (game.numDealerHits)
                {
                    case 3:
                        DealerCard3.Image = dealtCard;
                        DealerCard3.BringToFront();
                        break;
                    case 4:
                        DealerCard4.Image = dealtCard;
                        DealerCard4.BringToFront();
                        break;
                    case 5:
                        DealerCard5.Image = dealtCard;
                        DealerCard5.BringToFront();
                        break;
                    case 6:
                        DealerCard6.Image = dealtCard;
                        DealerCard6.BringToFront();
                        break;
                    case 7:
                        DealerCard7.Image = dealtCard;
                        DealerCard7.BringToFront();
                        break;
                    default:
                        pictureBox4.Image = dealtCard;
                        break;
                }
            }
            UpdateDealerCount();
            // Find winner 
                // Win ratio values indicate winner
                // (0 - tie, 1 - playerWin, -1 - playerLose
            double winRatio = (double) game.EvaluateWinner();
            PlayerPayOut(winRatio);

            if (winRatio == 0)
            {
                changeDialog("Player and Dealer Tie");
            }
            else if (winRatio == 1)
            {
                changeDialog("Player Wins \n" + curBet.ToString() + "$ won.");
            }
            else if (winRatio == -1)
            {
                changeDialog("Dealer Wins \n" + curBet.ToString() + "$ lost.");
            }
            // resetting cards
            ResetHands();
        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {
            curBet *= 2;
            PlayerCard3.Image = game.DealPlayerCard();
            PlayerCard3.BringToFront();
            PlayerScoreLabel.Text = game.PlayerScore().ToString();
            FinishHands();
        }

    }
}
   