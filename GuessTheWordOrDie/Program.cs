// Game generates random number between 0 and 100

Random randomNumGen = new Random();
int randNum = randomNumGen.Next(101);

// Game asks user for name
Console.WriteLine("What is your name?");
string playerName = Console.ReadLine();

// Name is saved permanently along with score (create algorith combining guesses with word length)

// Game greets user by a name, asking if they're willing to put their life on the line in a battle of wits
Console.WriteLine("Hello, " + playerName + ", are you willing to risk your life in a battle of wits?");

// Offer choices yes or no
Console.WriteLine("[1] Yes");
Console.WriteLine("[2] No");
string reply = Console.ReadLine();

// if no, Game calls user stupid and cowardly
if (reply =="2")
{
    Console.WriteLine(playerName + ", you are stupid and cowardly");
    // Game lists all the winners who are smarter than user, calling user by name, promising to add their name to list of cowards
}
// if yes, Game warns how many have died playing
else if (reply =="1")
{
    // Game explains the rules
    Console.WriteLine("I'm thinking of a number between 0 and 100.");
    // As what level of difficulty player would like to determine how many guesses
    Console.WriteLine("You have ten guesses.");
    Console.WriteLine("You look pretty stupid, so I'll give you hints when you're wrong.");
    // Console.WriteLine("You may now begin (that means type a number and press Enter, dummy).");

    // user gets ten attempts to guess a number between 0 and 100 
    int guesses = 10;
    for(int i=0; i <= guesses; i++)
    {
        if (guesses > 0)
        {
            Console.WriteLine("You have " + guesses + " guesses left.");
            Console.WriteLine("Pick a number.");
            int numGuess = int.Parse(Console.ReadLine());

            // check to see if it is a number

            // if user is correct, game ends
            if (numGuess == randNum) // should I use ===?
            {
                Console.WriteLine("You won!");
                // leaderboard displays
                break;
            }
            else if (numGuess != randNum) // if user is incorrect game tells user
            {
                guesses--;

                // take temperature
                int guessTemp = 0;
                if (numGuess > randNum)
                {
                    guessTemp = numGuess - randNum;
                }
                else 
                {
                    guessTemp = randNum - numGuess;
                }

                // game also tells user
                // whether their guess was too high or too low

                if (numGuess > randNum)
                {
                    Console.WriteLine("Nope. Your guess was too high ");
                }
                else if (numGuess < randNum)
                {
                    Console.WriteLine("Nope. Your guess was too low ");
                }
                
                // whether guess was hot, warm, cool, or cold
                // temperature of each guess is saved
                // after first guess, user told whether they're getting cooler or warmer

                if (guessTemp <= 10)
                {
                    Console.WriteLine("and your guess was really hot");
                }
                else if (guessTemp >10 && guessTemp <= 50)
                {
                    Console.WriteLine("and your guess was rather warm");
                }
                else if (guessTemp >50 && guessTemp <= 90)
                {
                    Console.WriteLine("and your guess was kinda cool");
                }
                else if (guessTemp >90)
                {
                    Console.WriteLine("and your guess was cold AF");
                }  

                Console.WriteLine("You have " + guesses + " guesses left. Try again, stupid.");
                    
            }
        }
        else // If user loses, game ends
        {
            Console.WriteLine("You are as dumb as you look. You lose. Good day!");
            break;
            // leaderboard displays
        }

    }
}
else
{
    Console.WriteLine("Come on, " + playerName + ", your choices were 'Yes' or 'No'. Why don't you try something easier like the swingset?");
}    

    
        
        

    


    