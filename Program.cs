//Jessie Lamzon
//10/17/22
//GitHubChallenge / redo all mini challenges
//data validation user input and play again
// Peer Review: Jeremy Lapham. Works great and just how 
// it's supposed to but one thing is data validation if I enter a 
// number as my name itll still run instead of stoping or looping back 
// to tell me to put in a number



Console.Clear();

string playAgain = "";
string playAgainLower = "";

Console.WriteLine("Hello, let's get to know your name.");

//loops until user exits by typing "n"
while (playAgainLower != "n")
{
    //ask user for name and reply back with user name
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("Whats up " + name + "!");

    //checks if user wants to play again and loop until valid entry is input
    while (playAgainLower != "n")
    {
        Console.WriteLine("Play again? type y or n");
        playAgain = Console.ReadLine();
        playAgainLower = playAgain.ToLower();

        if (playAgainLower == "n")
        {
            Console.WriteLine("Thanks for playing!");
        }
        else if (playAgainLower == "y")
        {
            break;
        }

    }


}