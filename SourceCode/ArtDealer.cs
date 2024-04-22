// This Program was developed using C# in Visual Studio 2022
// CS4500: Homework 4 Deck Draw Program
// Teammates are Nicholas/Brett/James/Jeremy/Matthew
// Lead Coder: Matthew Brown
// 4/10/24
// This Program will allow user to select 4 cards, the program will compare them to different patterns.
// There are 6 patterns and the program goes to the next pattern after two seperate hands where all four cards match the current pattern.
// Central Data Structures are Lists and arrays. The program writes to cardsDealt.txt and LastWon.txt in the DrawData folder.
// This Program used MicroSoft's Tutorial on C# Picture viewer apps,StackOverflow.com,and learn.microsoft.com/en-us/dotnet/api.

/* Credits:
 * learn.microsoft.com/en-us/dotnet/api
 * https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-windows-forms-picture-viewer-layout?view=vs-2022
 * https://stackoverflow.com/questions/1225857/write-string-to-text-file-and-ensure-it-always-overwrites-the-existing-content
 * https://stackoverflow.com/questions/6441583/is-there-a-simple-way-that-i-can-sort-characters-in-a-string-in-alphabetical-ord
 * https://stackoverflow.com/questions/71707808/how-to-add-a-wav-file-to-windows-form-application-in-visual-studio
 * https://freesound.org/s/376318/
 * https://stackoverflow.com/questions/1225857/write-string-to-text-file-and-ensure-it-always-overwrites-the-existing-content
 * https://stackoverflow.com/questions/13505248/how-to-make-autoscroll-multiline-textbox-in-winforms
 * https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.appendtext?view=windowsdesktop-8.0
 * https://stackoverflow.com/questions/13318561/adding-new-line-of-data-to-textbox
 * https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
 */

/* 
 * ==================================
 * HOW TO COMPILE, BUILD, AND EXECUTE
 * ==================================
 *  Launch Visual Studio and open the solution file (.sln) of the project.
 
 **  Build the Solution **
    -- In Visual Studio, go to the menu and select Build > Build Solution.

 ** Configure Debugging Options **
    -- Click F5 on the keyboard or go to Debug > Start Debugging 
    -- This Should Also Run the Project and Compile

 ** Documentation **
    -- Consult the Projects other Documentation for more in-depth details about the project
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckDrawHW1
{
    public partial class ArtDealer : Form
    {
        // Get Title
        string title = "Deck Draw Program";

        // Get path to write data
        string pathDealt = @"DrawData/CardsDealt.txt";
        string pathWon = @"DrawData/LastWon.txt";


        // Get date-only portion of date, without its time. From .net API
        string date = System.DateTime.Now.Date.ToString("d");

        // variables to track user-picked rank and suit of cards
        // set to first options of dropdowns be default
        int userRankCard1 = 2;
        string userSuitCard1 = "_of_hearts";
        int userRankCard2 = 2;
        string userSuitCard2 = "_of_hearts";
        int userRankCard3 = 2;
        string userSuitCard3 = "_of_hearts";
        int userRankCard4 = 2;
        string userSuitCard4 = "_of_hearts";

        // array of locations of cards chosen by user in the deck
        int[] drawIndexes = new int[4];

        // generates a deck of cards
        List<(string, int)> deck = GenerateDeck();

        //Booleans that tell if cards have matched the current pattern in 
        bool[] cardMatch = new bool[4];

        //Number denoting the current pattern we are on
        int lastWon;

        //Number of cards the art dealer has selected in this round
        int cardsSelected = 0;

        //Number of times the current pattern has been won
        int patternWonCount = 0;

        //List for the cards combinations that have already been picked for this pattern
        List<string> pickedPatterns = new List<string>();

        //Variable to determine if the user has finished all 6 patterns
        private bool finishedPatterns = false;

        // Purpose: Initializes application (automatically made by .NET framework)
        public ArtDealer()
        {
            InitializeComponent();
        }

        // Purpose: On Program Start (initial form load), prepares program for user
        // Author: Nicholas Hieb
        // Editors: James Struble, Brett McBride, Matthew Brown
        private void ArtDealer_Load(object sender, EventArgs e)
        {
            //Hides stop and reset buttons on initial start of program
            StopButton.Visible = false;
            ResetButton.Visible = false;
            DrawButton.Visible = false;
            SelectButton1.Visible = true;
            SelectButton2.Visible = false;
            SelectButton3.Visible = false;
            SelectButton4.Visible = false;
            labelCard1.Visible = false;
            labelCard2.Visible = false;
            labelCard3.Visible = false;
            labelCard4.Visible = false;

            //Displays welcome message
            string message = "Purpose of Program: The user will select 4 cards and the Art Dealer will determine if selected cards match secret patterns.";
            MessageBox.Show(message,title);


            // Create File if it does not exist for card history Credit goes to matthew and win API
            if (!File.Exists(pathDealt))
            {
                // Create a file to write to
                StreamWriter sw = File.CreateText(pathDealt);
                sw.Close();
            }
            using (StreamWriter sw = File.AppendText(pathDealt))
            {
                sw.WriteLine(date);
                sw.Close();
            }

            // Create File if it does not exist for last won number Credit goes to matthew and win API
            if (!File.Exists(pathWon))
            {
                // Create a file to write to
                //Credit: https://stackoverflow.com/questions/1225857/write-string-to-text-file-and-ensure-it-always-overwrites-the-existing-content
                File.WriteAllText(pathWon, "0");
            }
            StreamReader sr = new StreamReader(pathWon);
            lastWon = Int32.Parse(sr.ReadLine()); //Get lastWon from the file
            sr.Close();
            if(lastWon < 0 || lastWon > 6) //If someone edited the file trying to break the program
            {
                MessageBox.Show("Please do not edit LastWon.txt. Reseting to first pattern!", "Stop Cheating");
                File.WriteAllText(pathWon, "0");
            }

            //Updates history box with previous sessions choices
            updateHistoryBox();

            //Sets all dropdown menu values to same value, 2 of hearts
            rankBoxCard1.SelectedIndex = 0;
            suitBoxCard1.SelectedIndex = 0;
            rankBoxCard2.SelectedIndex = 0;
            rankBoxCard2.Visible = false;
            suitBoxCard2.SelectedIndex = 0;
            suitBoxCard2.Visible = false;
            rankBoxCard3.SelectedIndex = 0;
            rankBoxCard3.Visible = false;
            suitBoxCard3.SelectedIndex = 0;
            suitBoxCard3.Visible = false;
            rankBoxCard4.SelectedIndex = 0;
            rankBoxCard4.Visible = false;
            suitBoxCard4.SelectedIndex = 0;
            suitBoxCard4.Visible = false;

            //Initialize the cardsMatch bool array to false for all card
            for(int i = 0; i < 3; i++)
            {
                cardMatch[i] = false;
            }

            //Clears card images
            clearCardImages();

            //Shows the pick a card message
            PickACardMesage.Visible = true;

            //If we finished the last pattern
            if (lastWon == 6)
            {
                finishedPatterns = true;
                displayCongrats();
            }
        }
        //Purpose: Logic for the select button for card 1 is clicked. Makes the drowpdows for card 2 appear,
        //         drop downs for card 1 disappear and updates card 1 image on the screen.
        //Author: Brett McBride
        private void SelectButton1_Click(object sender, EventArgs e)
        {
            if (rankBoxCard1.SelectedIndex == 0 && suitBoxCard1.SelectedIndex == 0)
            {
                updateCardImage(card1, userRankCard1, userSuitCard1, 0);
            }
            suitBoxCard2.Visible = true;
            rankBoxCard2.Visible = true;
            suitBoxCard1.Visible = false;
            rankBoxCard1.Visible = false;
            SelectButton1.Visible = false;
            SelectButton2.Visible = true;
        }
        //Purpose: Logic for the select button for card 2 is clicked. Makes the drowpdows for card 3 appear,
        //         drop downs for card 2 disappear and updates card 2 image on the screen. If the selected
        //         card is the same as card 1 the user will be prompted to pick again.
        //Author: Brett McBride
        private void SelectButton2_Click(object sender, EventArgs e)
        {
            bool sameCards = verifyUniqueCards(drawIndexes, 2);
            //If the cards are unique
            if (!sameCards)
            {
                //Update card image
                if (rankBoxCard2.SelectedIndex == 0 && suitBoxCard2.SelectedIndex == 0)
                {
                    updateCardImage(card2, userRankCard2, userSuitCard2, 1);
                }
                suitBoxCard3.Visible = true;
                rankBoxCard3.Visible = true;
                suitBoxCard2.Visible = false;
                rankBoxCard2.Visible = false;
                SelectButton2.Visible = false;
                SelectButton3.Visible = true;
            }
            else
            {
                string message = "You have multiple of the same card picked.\nPlease choose 4 different cards.";
                MessageBox.Show(message, title);
            }

        }
        //Purpose: Logic for the select button for card 3 is clicked. Makes the drowpdows for card 4 appear,
        //         drop downs for card 3 disappear and updates card 3 image on the screen. If the selected
        //         card is the same as the previous cards the user will be prompted to pick again.
        //Author: Brett McBride
        private void SelectButton3_Click(object sender, EventArgs e)
        {
            bool sameCards = verifyUniqueCards(drawIndexes, 3);
            //If the cards are unique
            if (!sameCards)
            {
                //Update card image
                if (rankBoxCard3.SelectedIndex == 0 && suitBoxCard3.SelectedIndex == 0)
                {
                    updateCardImage(card3, userRankCard3, userSuitCard3, 2);
                }
                suitBoxCard4.Visible = true;
                rankBoxCard4.Visible = true;
                suitBoxCard3.Visible = false;
                rankBoxCard3.Visible = false;
                SelectButton3.Visible = false;
                SelectButton4.Visible = true;
            }
            else
            {
                string message = "You have multiple of the same card picked.\nPlease choose 4 different cards.";
                MessageBox.Show(message, title);
            }

        }

        //Purpose: Logic for the select button for card 4 is clicked. Makes the draw button visible, the
        //         drop downs for card 4 disappear and updates card 4 image on the screen. If the selected
        //         card is the same as the previous cards the user will be prompted to pick again.
        //Author: Brett McBride
        private void SelectButton4_Click(object sender, EventArgs e)
        {
            bool sameCards = verifyUniqueCards(drawIndexes, 4);
            //If the cards are unique
            if (!sameCards)
            {
                //Update card image
                if (rankBoxCard4.SelectedIndex == 0 && suitBoxCard4.SelectedIndex == 0)
                {
                    updateCardImage(card4, userRankCard4, userSuitCard4, 3);
                }
                suitBoxCard4.Visible = false;
                rankBoxCard4.Visible = false;
                SelectButton4.Visible = false;
                DrawButton.Visible = true;
            }
            else
            {
                string message = "You have multiple of the same card picked.\nPlease choose 4 different cards.";
                MessageBox.Show(message, title);
            }

        }
        // Purpose: On Draw Click, confirms user selection. Appends card draw CardsDealt.txt
        // Author: Nicholas Hieb
        // Editors: James Struble, Brett McBride, Matthew Brown
        private void DrawButton_Click(object sender, EventArgs e)
        {
            
            StopButton.Visible = true;

            string[] suits = new string[4]; //Suit of current cards selected
            string[] ranks = new string[4]; //Rank of current cards selected
            string[] cards = new string[4]; //Combined print object of rank and suit

            for (int i = 0; i < 4; i++) //Copy what ranks and suits are of the four cards
            {
                suits[i] = shortName(deck[drawIndexes[i]].Item1.ToString()); 
                ranks[i] = actualRank(deck[drawIndexes[i]].Item2);
                cards[i] = ranks[i] + suits[i]; //Build the print object to be put in history
            }


            //Credit: https://stackoverflow.com/questions/6441583/is-there-a-simple-way-that-i-can-sort-characters-in-a-string-in-alphabetical-ord
            string builder = cards[0] + cards[1] + cards[2] + cards[3]; //Build a string of the cards drawn
            char[] builderArrary = builder.ToCharArray(); //Convert it to a character array
            Array.Sort(builderArrary); //Sort the character array 
            string sortedCards = new string(builderArrary); //make it a string
           
            if(pickedPatterns.Contains(sortedCards)) //If the user has already picked that combination of cards
            {
                DrawButton.Visible = false;
                ResetButton.Visible = true;

                string message = "You have already picked this pattern once! Your patterns must have four different cards than one of your previous draws!\n";
                MessageBox.Show(message, title);

            } else { //IF the user picked a unique pattern this draw
                pickedPatterns.Add(sortedCards);
                checkPattern(ranks, suits); //Check the current picks against the current pattern

                //Add asterics to the chosen cards and make the green border visible
                for (int i = 0; i < 4; i++)
                {
                    if (cardMatch[i]) //if the card has matched the current pattern
                    {
                        cards[i] = "*" + cards[i] + "*";
                        switch (i) //Make the green border for the current card visible
                        {
                            case 0:
                                labelCard1.Visible = true;
                                break;
                            case 1:
                                labelCard2.Visible = true;
                                break;
                            case 2:
                                labelCard3.Visible = true;
                                break;
                            case 3:
                                labelCard4.Visible = true;
                                break;
                        }
                        cardsSelected++; //Increment the number of cards selected by the dealer
                    }
                }

                // Open the file to read from
                using (StreamWriter sw = File.AppendText(pathDealt))
                {
                    // Write Draw Data to file
                    sw.WriteLine(cards[0] + ','
                          + cards[1] + ','
                          + cards[2] + ','
                          + cards[3]);
                    sw.Close();
                }
                //Updates history box with new selections
                updateHistoryBox();

                //Replaces draw button with reset button
                DrawButton.Visible = false;
                ResetButton.Visible = true;

                if(cardsSelected >= 4) //If the four cards the user selected match the parttern
                {
                    patternWonCount++; //Increment the amount of times the pattern has been matched
                    if(patternWonCount >= 2) //If the user has guessed the pattern two times
                    {
                        using (StreamWriter sw = File.AppendText(pathDealt))
                        {
                            sw.WriteLine("USER WON PATTERN " + (lastWon + 1));
                            sw.Close();
                        }
                        updateHistoryBox();

                        lastWon++; //Increment the lastWon to be updated in txt file pointed at by pathWon
                        pickedPatterns.Clear(); //Empty the picked arrays

                        //Credit for how to add Sound: https://stackoverflow.com/questions/71707808/how-to-add-a-wav-file-to-windows-form-application-in-visual-studio
                        //Attribution: TaDa!.wav by jimhancock -- https://freesound.org/s/376318/ -- License: Creative Commons 0
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.tada);
                        player.Play();

                        if (lastWon == 6)
                        {
                            finishedPatterns = true;
                            displayCongrats();
                        } else
                        {
                            MessageBox.Show("Congratulation you have completed this pattern! There is another secret pattern to crack!", "Pattern Solved");
                        }
                        //Credit: https://stackoverflow.com/questions/1225857/write-string-to-text-file-and-ensure-it-always-overwrites-the-existing-content
                        File.WriteAllText(pathWon, lastWon.ToString()); //Replace contents of the file with lastWon
                        patternWonCount = 0;
                    }
                }
                cardsSelected = 0;
            }
            
        }

        // Purpose: On Stop Click, exit application
        // Author: Nicholas Hieb
        private void StopButton_Click(object sender, EventArgs e)
        {
            // Configure message box
            string message = "Thank You For Playing";
            // Show message box
            System.Windows.Forms.MessageBox.Show(message,title);
            Application.Exit();
        }

        // Purpose: Generate Deck of Tuple sorted cards
        // Return: Tuple list representing deck of cards
        // Author: Nicholas Hieb
        // Editors: James Struble
        static List<(string,int)> GenerateDeck()
        {
            string[] suits = { "_of_clubs", "_of_diamonds", "_of_hearts", "_of_spades" };
            int[] ranks = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            List<int> rank = new List<int>(ranks);
            List<string> suit = new List<string>(suits);
            List<(string, int)> deck = CombineLists(suits, ranks);
            //Returns a deck of 52 cards as a list
            return deck;
        }
        // Paramters: Takes in array of strings representing card suits, array of ints representing card ranks
        // Purpose: Combine suits and ranks arrays into tuple deck list
        // Return: deck as tuple list (string suit, int rank) made up of suits and ranks arrays
        // Credit: @StackOverflow method for combining lists
        // Author: Nicholas Hieb
        static List<(string, int)> CombineLists(string[] suits, int[] ranks)
        {
            var deck = new List<(string, int)>();
            for( int i = 0; i < suits.Length; i++ )
            {
                for( int j = 0; j < ranks.Length; j++)
                {
                    deck.Add((suits[i], ranks[j]));
                }
            }
            //Returns a list consisting of a deck of 52 cards after combining lists of ranks and suits
            return deck;
        }
        // Parameters: Takes in card suit as a string
        // Purpose: Get first letter of the suit
        // Return: Returns string of first character of each suit name
        // Author: Nicholas Hieb
        // Editors: Brett McBride
        string shortName(string name)
        {
            string shortSuit = name.ToUpper();
            shortSuit = shortSuit.Substring(4, 1);
            return shortSuit;
        }
        // Parameters: Takes in card rank as an int
        // Purpose: Get the rank of the card and convert it to a letter if face card
        // Return: Returns card rank as a string
        // Author: Nicholas Hieb
        string actualRank(int rank)
        {
            string rankSuit = rank.ToString();
            if( rank > 10 )
            {
                //Converts number rank to first letter of face rank
                switch( rank )
                {
                    case 11:
                        rankSuit = "J";
                        break;
                    case 12:
                        rankSuit = "Q";
                        break;
                    case 13:
                        rankSuit = "K";
                        break;
                    case 14:
                        rankSuit = "A";
                        break;
                }
            }
            return rankSuit;
        }
        // Parameters: Takes card suit text from dropdown menu as string
        // Purpose: Translates suit dropdown menu option into card image file formatted string
        // Returns: String of suit formatted into card image file suit
        // Author: Nicholas Hieb
        private string suitBox_Translator(string text)
        {
            string translatedSuit;
            switch (text)
            {
                case "Hearts":
                    translatedSuit = "_of_hearts";
                    break;
                case "Diamonds":
                    translatedSuit = "_of_diamonds";
                    break;
                case "Clubs":
                    translatedSuit = "_of_clubs";
                    break;
                default:
                    translatedSuit = "_of_spades";
                    break;
            }
            return translatedSuit;
        }
        // Paramters: Takes card rank text from dropdown menu as string
        // Translates rank dropdown menu option into file formatted int
        // Return: Returns int of suit formatted into card image file suit
        // Author: Nicholas Hieb
        private int rankBox_Translator(string text)
        {
            int translatedRank;
            switch (text)
            {
                case "Jack":
                    translatedRank = 11;
                    break;
                case "Queen":
                    translatedRank = 12;
                    break;
                case "King":
                    translatedRank = 13;
                    break;
                case "Ace":
                    translatedRank = 14;
                    break;
                default:
                    //https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint16?view=net-8.0
                    translatedRank = Convert.ToInt16(text);
                    break;
            }
            return translatedRank;
        }
        // Parameters: Takes deck of card as a tuple list (string suit, int rank),
        //             rank of user selected card as int, suit of user selected card as string
        // Purpose: Searches deck list for a card that matches user input rank and suit
        // Return: int value of location of selected card from deck
        // Author: Nicholas Hieb
        // Editors: James Struble
        private int searchDeck(List<(string, int)> deck, int rank, string suit)
        {
            int index = 0;
            for (int i = 0; i < deck.Count; i++)
            {
                if (rank == deck[i].Item2 && suit == deck[i].Item1)
                {
                    index = i;
                    break;
                }
            }
            //Returns int value of location of selected card from deck
            return index;
        }
        // Parameters: Takes in array of user selected cards as integers, representing location in deck list
        // Purpose: Verifies that each card selected is at a different location in deck list
        // Return: Boolean value representing if any integer matches
        // Author: Nicholas Hieb
        // Editors: James Struble
        private bool verifyUniqueCards(int[] indexes,int entry)
        {
            for (int j = 0; j < entry - 1; j++)
            {
                if (indexes[entry - 1] == indexes[j])
                {
                    return true;
                }
            }
            //Returns false if all cards are unique
            return false;
        }
        // Purpose: Clears current contents of history box and adds content from text file
        // Author: Nicholas Hieb
        // Editors: James Struble, Matthew Brown
        private void updateHistoryBox()
        {
            //Credit: https://stackoverflow.com/questions/13505248/how-to-make-autoscroll-multiline-textbox-in-winforms
            textBox1.Text = string.Empty;
            StreamReader sr = new StreamReader(pathDealt);
            string line = sr.ReadLine();
            while (line != null)
            {
                //Credit: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.appendtext?view=windowsdesktop-8.0
                textBox1.AppendText(line);
                //CreditL https://stackoverflow.com/questions/13318561/adding-new-line-of-data-to-textbox
                textBox1.AppendText(Environment.NewLine);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        // Parameters: Takes in card image location in program as Winforms PictureBox,
        //             rank as an integer, suit as a string (both card image file formatted)
        //             and integer representing locaion of card changed in user selected card array (drawIndexes)
        // Purposes: Updates card images with user-selected cards
        // Author: Nicholas Hieb
        // Editors: James Struble
        private void updateCardImage(PictureBox card, int userRank, string userSuit, int cardNumber)
        {
            int cardIndex = searchDeck(deck, userRank, userSuit);
            drawIndexes[cardNumber] = cardIndex;
            Console.WriteLine(cardIndex);
            card.Load(@"PlayingCards/" + deck[cardIndex].Item2 + deck[cardIndex].Item1 + ".png");
            //Hides pick a card message when user selects a card
            PickACardMesage.Visible = false;
        }

        // Purpose: Clears card images
        // Author: Nicholas Hieb
        private void clearCardImages()
        {
            card1.Image = null;
            card2.Image = null;
            card3.Image = null;
            card4.Image = null;
        }


        // Purpose: On user selection of first card's rank display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void rankBoxCard1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard1 = rankBox_Translator(rankBoxCard1.Text);
            updateCardImage(card1, userRankCard1, userSuitCard1, 0);
        }
        // Purpose: On user selection of first card's suit display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void suitBoxCard1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard1 = suitBox_Translator(suitBoxCard1.Text);
            updateCardImage(card1, userRankCard1, userSuitCard1, 0);
        }

        // Purpose: On user selection of second card's rank display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void rankBoxCard2_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard2 = rankBox_Translator(rankBoxCard2.Text);
            updateCardImage(card2, userRankCard2, userSuitCard2, 1);
        }

        // Purpose: On user selection of second card's suit display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void suitBoxCard2_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard2 = suitBox_Translator(suitBoxCard2.Text);
            updateCardImage(card2, userRankCard2, userSuitCard2, 1);
        }

        // Purpose: On user selection of third card's rank display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void rankBoxCard3_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard3 = rankBox_Translator(rankBoxCard3.Text);
            updateCardImage(card3, userRankCard3, userSuitCard3, 2);
        }

        // Purpose: On user selection of third card's suit display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void suitBoxCard3_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard3 = suitBox_Translator(suitBoxCard3.Text);
            updateCardImage(card3, userRankCard3, userSuitCard3, 2);
        }

        // Purpose: On user selection of fourth card's rank display dropdown menu, update tracking variable and update associated card image box
        // Author: Nicholas Hieb
        private void rankBoxCard4_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard4 = rankBox_Translator(rankBoxCard4.Text);
            updateCardImage(card4, userRankCard4, userSuitCard4, 3);
        }

        // Purpose: On user selection of fourth card's suit display dropdown menu, update tracking variable and update associatedcard image box
        // Author: Nicholas Hieb
        private void suitBoxCard4_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard4 = suitBox_Translator(suitBoxCard4.Text);
            updateCardImage(card4, userRankCard4, userSuitCard4, 3);
        }

        // Purpose:  On reset button click clears card images
        // Author: Nicholas Hieb
        // Editor: Matthew Brown
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //If we are on the last pattern reset back to pattern 1
            if(finishedPatterns)
            {
                resetPatterns();
            }
            ResetButton.Visible = false;
            DrawButton.Visible = false;
            SelectButton1.Visible = true;
            rankBoxCard1.SelectedIndex = 0;
            rankBoxCard1.Visible = true;
            suitBoxCard1.SelectedIndex = 0;
            suitBoxCard1.Visible = true;
            rankBoxCard2.SelectedIndex = 0;
            rankBoxCard2.Visible = false;
            suitBoxCard2.SelectedIndex = 0;
            suitBoxCard2.Visible = false;
            rankBoxCard3.SelectedIndex = 0;
            rankBoxCard3.Visible = false;
            suitBoxCard3.SelectedIndex = 0;
            suitBoxCard3.Visible = false;
            rankBoxCard4.SelectedIndex = 0;
            rankBoxCard4.Visible = false;
            suitBoxCard4.SelectedIndex = 0;
            suitBoxCard4.Visible = false;
            labelCard1.Visible = false;
            labelCard2.Visible = false;
            labelCard3.Visible = false;
            labelCard4.Visible = false;

            clearCardImages();
        }

        //Purpose: Function that determines which pattern to check drawn cards against.
        //         lastWon variable indicates what the current pattern is
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void checkPattern(string[] ranks, string[] suits)
        {
            switch (lastWon) //this is pulled from LastWon.txt and is a integer between 0 and 5
            {
                case 0: //Check if the Suits are all red
                    patternAllRed(ranks, suits);
                    break;
                case 1: //All CLubs Pattern
                    patternAllClubs(ranks, suits);
                    break;
                case 2: //All Face Cards Pattern
                    patternFaceCards(ranks, suits);
                    break;
                case 3: //All cards 2 <-> 9
                    patternSingleDigits(ranks, suits);
                    break;
                case 4: //Prime Numbers 2, 3, 5, 7
                    patternAnyPrime(ranks, suits);
                    break;
                case 5: //Pick the highest rank cards
                    patternHighestRank(ranks, suits);
                    break;
                default:
                    using (StreamWriter sw = File.AppendText(pathWon))
                    {
                        MessageBox.Show("Please do not edit LastWon.txt. Reseting to first pattern!", "Stop Cheating");
                        File.WriteAllText(pathWon, "0");
                    }
                    break;
            }
        }

        //Purpose: checks for the pattern if the user selected any heart or diamond
        //         Raises flags in cardMatch[i] to indicate which cards in position 0 -> 4 match the pattern
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void patternAllRed(string[] ranks, string[] suits)
        {
            for(int i = 0; i < 4; i++) //For all 4 cards
            {
                if (suits[i] == "D" || suits[i] == "H") //If the card is a heart or diamond
                {
                    cardMatch[i] = true;
                } else
                {
                    cardMatch[i] = false;
                }
            }

        }

        //Purpose: checks for the pattern if the user selected any club
        //         Raises flags in cardMatch[i] to indicate which cards in position 0 -> 4 match the pattern
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void patternAllClubs(string[] ranks, string[] suits)
        {
            for (int i = 0; i < 4; i++)  //For all 4 cards
            {
                if (suits[i] == "C") //If the cards is a club
                {
                    cardMatch[i] = true;
                } else
                {
                    cardMatch[i] = false;
                }
            }
        }

        //Purpose: checks for the pattern if the user selected any face cards
        //         Raises flags in cardMatch[i] to indicate which cards in position 0 -> 4 match the pattern
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void patternFaceCards(string[] ranks, string[] suits)
        {
            for (int i = 0; i < 4; i++) //For all 4 cards
            {
                if (ranks[i] == "J" || ranks[i] == "Q" || ranks[i] == "K") //If the card is a face card
                {
                    cardMatch[i] = true;
                }
                else
                {
                    cardMatch[i] = false;
                }
            }
        }

        //Purpose: checks for the pattern if the user selected any cards between 2 and 9
        //         Raises flags in cardMatch[i] to indicate which cards in position 0 -> 4 match the pattern
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void patternSingleDigits(string[] ranks, string[] suits)
        {
            for (int i = 0; i < 4; i++) //For all 4 cards
            {
                try
                {
                    //Credit: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
                    int test = Int32.Parse(ranks[i]); //Convert the string to a number so we can compare its values
                    if (test >= 2 && test <= 9) //If the number is single digit
                    {
                        cardMatch[i] = true;

                    }
                    else //Should just be for 10
                    {
                        cardMatch[i] = false;
                    }
                }
                catch //Catching all the face cards here
                {
                    cardMatch[i] = false;
                }
            }
        }

        //Purpose: checks for the pattern if the user selected any cards that are prime
        //         Raises flags in cardMatch[i] to indicate which cards in position 0 -> 4 match the pattern
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void patternAnyPrime(string[] ranks, string[] suits)
        {
            for (int i = 0; i < 4; i++) //For all 4 cards
            {
                if (ranks[i] == "2" || ranks[i] == "3" || ranks[i] == "5" || ranks[i] == "7") //If the card is prime
                {
                    cardMatch[i] = true;
                }
                else
                {
                    cardMatch[i] = false;
                }
            }
        }

        //Purpose: This pattern selects all cards from the highest rank present (if it is KD KH JD JH it would select the two kings)
        //         Raises flags in cardMatch[i] to indicate which cards in position 0 -> 4 match the pattern
        //Passed: Passed arrays for the values of the ranks and suits of the selected cards
        //Author: Matthew Brown
        private void patternHighestRank(string[] ranks, string[] suits)
        {
            int[] rankHolder = new int[4]; //Integer array to hold the converted ranks so we can compare their size
            int currentMaxRank = 0; //Keep track of the highest rank card seen
            for (int i = 0; i < 4; i++) //For all 4 cards
            {
                switch (ranks[i])
                {
                    case "J": //Jack
                        rankHolder[i] = 11;
                        break;
                    case "Q": //Queen
                        rankHolder[i] = 12;
                        break;
                    case "K": //King
                        rankHolder[i] = 13;
                        break;
                    case "A": //Ace
                        rankHolder[i] = 14;
                        break;
                    default:
                        try
                        {
                            rankHolder[i] = Int32.Parse(ranks[i]); //THe rest are numbers convert them to ints
                        }
                        catch //We should never hit this input should be only numbers
                        {
                            rankHolder[i] = 2;
                        }
                        break;
                }
                if(currentMaxRank < rankHolder[i]) //If the rank we are looking at now is bigger than the previous card
                {
                    currentMaxRank = rankHolder[i];
                }
            }
            for (int i = 0;i < 4;i++) //For all 4 cards
            {
                if (rankHolder[i] == currentMaxRank) //Pick all the cards that are the same as the highest rank seen
                {
                    cardMatch[i] = true;
                } else
                {
                    cardMatch[i] = false;
                }
            }
        }

        //Purpose: This function displays the congrats image and hides cards and makes the reset button visible
        //Author: Matthew Brown
        private void displayCongrats()
        {
            PickACardMesage.Visible = false; //Need this so pickacard message isn't visible in front of the image
            Congrats.Visible = true; //Make congrats image visible
            ResetButton.Visible = true; ///Makes reset button visible
            clearCardImages();
            MessageBox.Show("Congratulation you have completed all the Patterns! You have climbed the highest mountain relish your victory!", "Fin");
        }

        //Purpose: This function resets the pattern back to pattern one.
        //Author: Matthew Brown
        private void resetPatterns()
        {
            Congrats.Visible = false; //Make the congrats image invisible
            File.WriteAllText(pathWon, "0"); //Reset the txt file
            lastWon = 0; //Go back to pattern 1
            finishedPatterns = false; //Set this to false so the congrats image doesn't appear on next reset click
            MessageBox.Show("Your game has been reset to pattern 1 good luck!", title);
        }

    }
}
