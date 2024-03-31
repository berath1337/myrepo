//There should be a menu with three options:
//Play
//The user picks rock paper or scissors option
//The application picks rock paper scissors on random
//The user pick and the application pick are shown on the screen
//The application shows the winner
//The application saves 1 score to the user or the computer in the background
//When the user hits enter it returns to the main menu
//Stats
//It shows how many wins the user and how many wins the computer has
//It shows the percentage of the wins and losses of the user
//When the user hits enter it returns to the main menu
//Exit
//It closes the application


using System.Security.Cryptography;

double drawScore = 0;
double computerScore = 0;
double playerScore = 0;
string choice;
string selectedOption;
bool gameRunning = true;
string input;


string[] options = { "rock", "paper", "scissors" };
Random rnd = new Random();
int index = rnd.Next(0, options.Length);
selectedOption = options[index];


void mainMenu()
{
    Console.WriteLine("====WELCOME TO THE ROCK PAPER SCISSORS GAME====");
    Console.WriteLine("1.Play\n2.Stats\n3.Exit");
    input = Console.ReadLine();
}




//Game Logic
while (gameRunning)
{
    mainMenu();
    
    if (input.ToLower() == "play" || input == "1")
    {
        
        Console.WriteLine("Pick either rock, paper or scissors by typing its name.");
        choice = Console.ReadLine();

        if (choice.ToLower() == "rock" && selectedOption == "rock")
        {
            draw();
        }
        if (choice.ToLower() == "rock" && selectedOption == "paper")
        {
            computerWin();
        }
        if (choice.ToLower() == "rock" && selectedOption == "scissors")
        {
            playerWin();
        }
        if (choice.ToLower() == "paper" && selectedOption == "rock")
        {
            playerWin();
        }
        if (choice.ToLower() == "paper" && selectedOption == "paper")
        {
            draw();
        }
        if (choice.ToLower() == "paper" && selectedOption == "scissors")
        {
            computerWin();
        }
        if (choice.ToLower() == "scissors" && selectedOption == "rock")
        {
            computerWin();
        }
        if (choice.ToLower() == "scissors" && selectedOption == "paper")
        {
            playerWin();
        }
        if (choice.ToLower() == "scissors" && selectedOption == "scissors")
        {
            draw();
        }
        else
        {
            Console.WriteLine("Invalid input, you are redirected to main menu");

        }

    }
    else if (input.ToLower() == "2" || input.ToLower() == "stats")
    {
        showStats(); 
        
    }
    else if (input.ToLower() == "3" || input.ToLower() == "exit") { gameRunning = false; }
    else
    {
        Console.WriteLine("Please pick one of the three options");
    }
}
void playerWin()
{

    Console.WriteLine($"Player picked {choice}, Computer picked {selectedOption} It's a win for the player!");
    playerScore += 1;
    enterKey();
}
void computerWin()
{
    Console.WriteLine($"Player picked {choice}, Computer picked {selectedOption} It's a win for the computer!");
    computerScore += 1;
    enterKey();
}

void draw()
{
    Console.WriteLine($"Player picked {choice}, Computer picked {selectedOption} It's a draw!");
    drawScore += 1;
    enterKey();
}
void showStats()
{
    Console.WriteLine($"Game statistics:\nPlayer's Score:{playerScore}\nComputer's Score:{computerScore}\nDraw:{drawScore}");
    double totalGames = playerScore + computerScore + drawScore;
    double playerWinPercentage = totalGames == 0 ? 0 : (playerScore / totalGames) * 100;
    double computerWinPercentage = totalGames == 0 ? 0 : (computerScore / totalGames) * 100;
    double drawPercentage = totalGames == 0 ? 0 : (drawScore / totalGames) * 100;

    Console.WriteLine($"Player's Win Percentage: {playerWinPercentage}%");
    Console.WriteLine($"Computer's Win Percentage: {computerWinPercentage}%");
    Console.WriteLine($"Draw Percentage: {drawPercentage}%");

    enterKey();
}

 void enterKey()
{
    Console.WriteLine("Press Enter to go back to main menu");

    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {
        Console.WriteLine("Please press Enter to go back to main menu...");
    }


}