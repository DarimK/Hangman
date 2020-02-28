using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        /*
         *                                         Created by: Darim Khan
         *    
         *                                               -Hangman-
         *    
         *                                              How to play:
         *            For the first feature, the user will act as the moderator and choose the words. 
         *               Then the friends must try to find out that word by guessing each letter. 
         *          Each incorrect letter a part of the body appears, until it all appears and they lose. 
         *                         If they get the word before he is hanged then they win. 
         * For the second feature, one player thinks of a word, phrase, or sentence, and the other(s) tries to guess it. 
         *           They do this by suggesting letters or numbers, within a certain number of guesses. 
         *       These guesses are vital because if you take too many then the man will be hanged, similarly.
         * */


            // game start page

        title_screen:
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "theme.wav";
            player.PlayLooping();
            Console.ForegroundColor = ConsoleColor.Red;
        Console.SetWindowSize(100, 15);

            // hangman screen

        Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------██░-██--▄▄▄-------███▄----█---▄████--███▄-▄███▓-▄▄▄-------███▄----█----------------");
            Console.WriteLine("---------------▓██░-██▒▒████▄-----██-▀█---█--██▒-▀█▒▓██▒▀█▀-██▒▒████▄-----██-▀█---█----------------");
            Console.WriteLine("---------------▒██▀▀██░▒██--▀█▄--▓██--▀█-██▒▒██░▄▄▄░▓██----▓██░▒██--▀█▄--▓██--▀█-██▒---------------");
            Console.WriteLine("---------------░▓█-░██-░██▄▄▄▄██-▓██▒--▐▌██▒░▓█--██▓▒██----▒██-░██▄▄▄▄██-▓██▒--▐▌██▒---------------");
            Console.WriteLine("---------------░▓█▒░██▓-▓█---▓██▒▒██░---▓██░░▒▓███▀▒▒██▒---░██▒-▓█---▓██▒▒██░---▓██░---------------");
            Console.WriteLine("----------------▒-░░▒░▒-▒▒---▓▒█░░-▒░---▒-▒--░▒---▒-░-▒░---░--░-▒▒---▓▒█░░-▒░---▒-▒----------------");
            Console.WriteLine("----------------▒-░▒░-░--▒---▒▒-░░-░░---░-▒░--░---░-░--░------░--▒---▒▒-░░-░░---░-▒░---------------");
            Console.WriteLine("----------------░--░░-░--░---▒------░---░-░-░-░---░-░------░-----░---▒------░---░-░----------------");
            Console.WriteLine("----------------░--░--░------░--░---------░-------░--------░---------░--░---------░----------------");
            Console.WriteLine("-----------------------------------------Made-By-Darim-Khan----------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                        Press Enter To Begin                                       ");
            Console.ReadLine();

            // user chooses which hangman to play (user made or computer generated) or to exit

            game_chooser:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input;
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            Boolean comp = false;
            Boolean user = false;
            string word = "potato";
            Console.WriteLine();
            Console.WriteLine("  Would you like to:");
            Console.WriteLine("   1. Use computer generated words.");
            Console.WriteLine("   2. Create and play with user made words.");
            Console.WriteLine("   3. Exit game.");
            Console.WriteLine("   (input the number)");
            input = Convert.ToString(Console.ReadLine());

            // runs through user option

            if (input == "1")
            {

            // user chooses which topic to play (if computer generated is chosen) or to go back

            topic_chooser:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("  Choose a topic:");
                Console.WriteLine("   1. Food.");
                Console.WriteLine("   2. Science.");
                Console.WriteLine("   3. Countries.");
                Console.WriteLine("   4. Sentences (hard).");
                Console.WriteLine("   5. Go back.");
                Console.WriteLine("   (input the number)");
                input = Convert.ToString(Console.ReadLine());
                string[] computer = new string[5];

                // runs through user option and sets onto a string to be used later (for the hangman guessing)

                if (input == "1")
                {
                    // foods
                    computer[0] = "potato";
                    computer[1] = "tomato";
                    computer[2] = "rice";
                    computer[3] = "burger";
                    computer[4] = "pasta";
                    comp = true;
                    word = computer[random];
                }
                else if (input == "2")
                {
                    // school subjects
                    computer[0] = "chemistry";
                    computer[1] = "physics";
                    computer[2] = "biology";
                    computer[3] = "astronomy";
                    computer[4] = "anthropology";
                    comp = true;
                    word = computer[random];
                }
                else if (input == "3")
                {
                    // countries
                    computer[0] = "canada";
                    computer[1] = "united states of america";
                    computer[2] = "russia";
                    computer[3] = "france";
                    computer[4] = "germany";
                    comp = true;
                    word = computer[random];
                }
                else if (input == "4")
                {
                    // sentences
                    computer[0] = "hello this program is nice";
                    computer[1] = "this sentence is pointless";
                    computer[2] = "wyh deos tihs setencne heva so muhc eorrsr";
                    computer[3] = "school may be fun";
                    computer[4] = "this is a very long sentence to test how good you are at hangman";
                    comp = true;
                    word = computer[random];
                }
                else if (input == "5")
                {
                    // go back
                    comp = false;
                    goto game_chooser;
                }

                    // goes again if incorrect is entered

                else
                {
                    Console.WriteLine("  Incorrect input. Press enter to try again.");
                    Console.ReadLine();
                    goto topic_chooser;
                }
            }

            // if user made words is chosen

            else if (input == "2")
            {
                user = true; 
                goto game;
            }

            // if user wants to exit game

            else if (input == "3")
            {
                goto end_screen;
            }

            // goes again if incorrect is entered

            else
            {
                Console.WriteLine("  Incorrect input. Press enter to try again.");
                Console.ReadLine();
                goto game_chooser;
            }

            // begins the game with what user chose

            game:
            Console.SetWindowSize(99, 35);
            Console.ForegroundColor = ConsoleColor.Yellow;

            // games variables made

            char guess;
            char checker;
            Boolean sohaib = false;
            int incorrect = 0;
            int guess_number = 0;
            Boolean head = false;
            Boolean body = false;
            Boolean arm1 = false;
            Boolean arm2 = false;
            Boolean leg1 = false;
            Boolean leg2 = false;
            Boolean lose = false;
            Boolean win = false;
            int corrects = 0;
            Console.Clear();

            // determines if user chose user made or computer generated words

            if (user == true)
            {
                // asks user to input a word/sentence
                Console.WriteLine("  Input the word/sentence.");
                input = Convert.ToString(Console.ReadLine());
                input = input.ToLower();
            }
            else if (comp == true)
            {
                // sets the random topic choice to the string (which will be applied to the char array)
                input = word;
            }

            // char array with guessing word is made

            char[] name = input.ToCharArray();
            char[] blanks = new char[name.Length];
            char[] guesses = new char[1000];
            Boolean[] darim = new Boolean[name.Length];
            
            // creates blanks

            for (int i = 0; i < blanks.Length; i++)
            {
                blanks[i] = '_';
            }

            // checks to see if any body parts should be placed from wrong guesses

            hangman:
            if (incorrect == 1) { head = true; }
            if (incorrect == 2) { body = true; }
            if (incorrect == 3) { arm1 = true; head = false; }
            if (incorrect == 4) { arm2 = true; arm1 = false; }
            if (incorrect == 5) { leg1 = true; }
            if (incorrect == 6) { leg2 = true; leg1 = false; }
            if (incorrect == 7) { lose = true; }
            if (lose == true) { for (int i = 0; i < name.Length; i++) { blanks[i] = name[i]; } }

            // prints out the hangman module

            Console.Clear();
            Console.WriteLine("        ____________");
            Console.WriteLine("        |          |");
            if (head == true)
            {
                Console.WriteLine("        |         (.)");
            }
            if (arm1 == true)
            {
                Console.WriteLine("        |       __(.)");
            }
            if (arm2 == true)
            {
                Console.WriteLine("        |       __(.)__");
            }
            if (body == true)
            {
                Console.WriteLine("        |          |");
                Console.WriteLine("        |          -");
            }
            if (leg1 == true)
            {
                Console.WriteLine("        |         |");
            }
            if (leg2 == true)
            {
                Console.WriteLine("        |         | |");
            }
            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("  ______|______");

            // prints out the blanks with what words have been guessed already

            Console.WriteLine();
            for (int i = 0; i < blanks.Length; i++)
            {
                Console.Write(blanks[i] + " ");
            }

            // after hangman printed determines whether the user has won or lost yet

            if (win == true)
            {
                // if user wins:
                System.Media.SoundPlayer cool = new System.Media.SoundPlayer();
                cool.SoundLocation = "win.wav";
                cool.Play();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("  Good job you won.");
                corrects = 0;
                Console.WriteLine("  Press enter to title screen.");
                Console.ReadLine();
                goto title_screen;
            }

            if (lose == true)
            {
                // if user loses:
                System.Media.SoundPlayer suck = new System.Media.SoundPlayer();
                suck.SoundLocation = "hang.wav";
                suck.Play();
                Console.WriteLine("  Was the word.");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  You lose. Press enter to return to title screen.");
                Console.ReadLine();
                Console.Clear();
                incorrect = 0;
                goto title_screen;
            }

            // user guesses letters here

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  Guess a character:");

            sohaibious:
                input = Convert.ToString(Console.ReadLine());
                input = input.ToLower();

            // checks if user entered something other than a character

                if (!char.TryParse(input, out guess))
                {
                    Console.WriteLine("   Put in a single character.");
                    goto sohaibious;
                }

                guesses[guess_number] = guess;

            // checks if user entered a character that has already been put in

                for (int i = 0; i < name.Length; i++)
                {
                    if (i == guess_number)
                    {
                        i++;
                    }
                    if (guess == guesses[i])
                    {
                        // goes back if entered character matches one that has already been entered
                        Console.WriteLine("  You have already entered this character. Input a different one.");
                        guesses[i] = guesses[i + 1];
                        if (guess_number > 1)
                        {
                            guess_number--;
                        }
                        goto sohaibious;
                    }
                }

                guess_number++;

            // checks if entered letter matches any letter in the word

                for (int i = 0; i < name.Length; i++)
                {
                    checker = Convert.ToChar(name[i]);
                    if (guess == checker)
                    {
                        darim[i] = true;
                        blanks[i] = guess;
                        sohaib = true;
                    }
                }

            // goes through to output if letter matched a letter in the word or not (if a letter was guessed or not)

                if (sohaib == true)
                {
                    // if it was matching one or many
                    sohaib = false;
                    for (int i = 0; i < darim.Length; i++)
                    {
                        if (darim[i] == true)
                        {
                            corrects++;
                        }
                    }
                    if (corrects == darim.Length)
                    {
                        win = true;
                        for (int ii = 0; ii < name.Length; ii++) { blanks[ii] = name[ii]; }
                    }
                    corrects = 0;
                    goto hangman;
                }
                else
                {
                    // if there was no match
                    Console.WriteLine("  " + input + " was not one of the characters.");
                    incorrect++;
                    Console.WriteLine("  Press enter to try again.");
                    Console.ReadLine();
                    goto hangman;
                }

            // prints out exit screen if user chooses to exit

            end_screen:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetWindowSize(99, 15);

                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------██░-██--▄▄▄-------███▄----█---▄████--███▄-▄███▓-▄▄▄-------███▄----█----------------");
                Console.WriteLine("---------------▓██░-██▒▒████▄-----██-▀█---█--██▒-▀█▒▓██▒▀█▀-██▒▒████▄-----██-▀█---█----------------");
                Console.WriteLine("---------------▒██▀▀██░▒██--▀█▄--▓██--▀█-██▒▒██░▄▄▄░▓██----▓██░▒██--▀█▄--▓██--▀█-██▒---------------");
                Console.WriteLine("---------------░▓█-░██-░██▄▄▄▄██-▓██▒--▐▌██▒░▓█--██▓▒██----▒██-░██▄▄▄▄██-▓██▒--▐▌██▒---------------");
                Console.WriteLine("---------------░▓█▒░██▓-▓█---▓██▒▒██░---▓██░░▒▓███▀▒▒██▒---░██▒-▓█---▓██▒▒██░---▓██░---------------");
                Console.WriteLine("----------------▒-░░▒░▒-▒▒---▓▒█░░-▒░---▒-▒--░▒---▒-░-▒░---░--░-▒▒---▓▒█░░-▒░---▒-▒----------------");
                Console.WriteLine("----------------▒-░▒░-░--▒---▒▒-░░-░░---░-▒░--░---░-░--░------░--▒---▒▒-░░-░░---░-▒░---------------");
                Console.WriteLine("----------------░--░░-░--░---▒------░---░-░-░-░---░-░------░-----░---▒------░---░-░----------------");
                Console.WriteLine("----------------░--░--░------░--░---------░-------░--------░---------░--░---------░----------------");
                Console.WriteLine("------------------------------------------Made-By-Darim-Khan---------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                         Press Enter To Exit                                       ");

                Console.ReadLine();
        }
    }
}
