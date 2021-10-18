using System;

Main();


void Main()
{
    int roundNumber = 0;
    int playerScore = 0;
    int computerScore = 0;

    while (roundNumber < 3)
    {
        int myThrow = ThrowQuestion(playerScore, computerScore);
        int compThrow = ComputerResponse();
        if (myThrow == 1 && compThrow == 2)
        {
            playerScore += 1;
        }
        else if (myThrow == 1 && compThrow == 3)
        {
            computerScore += 1;
        }
        else if (myThrow == 2 && compThrow == 1)
        {
            playerScore += 1;
        }
        else if (myThrow == 2 && compThrow == 3) 
        {
            computerScore += 1;
        }
        else if (myThrow == 3 && compThrow == 1) 
        {
            computerScore += 1;
        }
        else if (myThrow == 3 && compThrow == 2) 
        {
            playerScore += 1;
        }
        else
        {
            continue;
        }
        roundNumber += 1;
    }

    Console.WriteLine();
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
    Console.WriteLine("---------------------------");
    Console.WriteLine();

    if (playerScore > computerScore)
    {
        System.Console.WriteLine("Congrats. You win!");
    }
    else
    {
        System.Console.WriteLine("Sorry, loser!");
    }
}

int ThrowQuestion(int playerScore, int computerScore)
{
    Console.WriteLine();
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
    Console.WriteLine("---------------------------");
    Console.WriteLine();
    Console.WriteLine(@"What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");
    string answer = Console.ReadLine();

    while (answer != "1" && answer != "2" && answer != "3")
    {
        Console.WriteLine(@"What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");
        answer = Console.ReadLine();
    }

    if (answer == "1")
    {
        Console.Write("You: Rock \n");
        return 1;
    }
    else if (answer == "2")
    {
        Console.Write("You: Paper \n");
        return 2;
    }
    else
    {
        Console.Write("You: Scissors \n");
        return 3;
    }
}

int ComputerResponse()
{
    Random rnd = new Random();
    int rando = rnd.Next(1, 3);
    if (rando == 1)
    {
        Console.WriteLine("Computer: Rock \n");
        return 1;
    }
    else if (rando == 2)
    {
        Console.WriteLine("Computer: Paper \n");
        return 2;
    }
    else
    {
        Console.WriteLine("Computer: Scissors \n");
        return 3;
    }
}
