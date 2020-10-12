using System;

namespace CSharpRPS.Controllers
{
  class GameController
  {
    public string PlayerChoice { get; private set; }
    public bool Playing { get; set; }

    public string CompChoice { get; private set; }

    public string input { get; private set; }

    public bool Prompt { get; set; }

    public void Run()
    {
      while (Playing)
      {
        GetUserInput();
      }
    }
    private void GetUserInput()
    {
      if (PlayerChoice != null && Prompt == false)
      {
        Prompt = true;
      }
      else
      {
        System.Console.WriteLine("\nRock, Paper, Scissors or quit?");
        PlayerChoice = Console.ReadLine().ToLower();
        Console.Clear();
      }
      switch (PlayerChoice.ToLower())
      {
        case "quit":
          Playing = false;
          Console.WriteLine("\nGame Ended");
          break;
        case "rock":
        case "paper":
        case "scissors":
          Play();
          break;
        default:
          Console.WriteLine("\nInvalid Command");
          break;
      }
    }

    private void Play()
    {
      Random rnd = new Random();
      int CompNum = rnd.Next(3);
      switch (CompNum)
      {
        case 0:
          CompChoice = "rock";
          break;
        case 1:
          CompChoice = "scissors";
          break;
        case 2:
          CompChoice = "paper";
          break;
      }
      Console.WriteLine($"\nPlayer choice is: {PlayerChoice} and Computer choice is: {CompChoice}");
      if (PlayerChoice == CompChoice)
      {
        Console.WriteLine("\nTie");
        Prompt = true;
      }
      else if ((PlayerChoice == "paper" && CompChoice == "rock") || (PlayerChoice == "scissors" && CompChoice == "paper") || (PlayerChoice == "rock" && CompChoice == "scissors"))
      {
        Console.WriteLine("\nYou Win");
        Prompt = true;
      }
      else
      {
        Console.WriteLine("\nYou Lose");
        Prompt = true;
      }
    }



    public GameController(string choice)
    {
      PlayerChoice = choice;
      Playing = true;
    }
  }
}
