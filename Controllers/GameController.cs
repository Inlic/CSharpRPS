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
      Prompt = false;
      while (Playing)
      {
        GetUserInput();
      }
    }
    private void GetUserInput()
    {
      if (PlayerChoice != null && Prompt == false)
      {
        input = PlayerChoice.ToLower();
        Prompt = true;
      }
      else
      {
        System.Console.WriteLine("Rock, Paper, Scissors or quit?");
        input = Console.ReadLine().ToLower();
      }
      switch (input)
      {
        case "quit":
          Playing = false;
          Console.WriteLine("Game Ended");
          break;
        case "rock":
        case "paper":
        case "scissors":
          Play();
          break;
        default:
          Console.WriteLine("Invalid Command");
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
      Console.WriteLine($"Player choice is: {PlayerChoice} and Computer choice is: {CompChoice}");
      if (PlayerChoice == CompChoice)
      {
        Console.WriteLine("Tie");
      }
      else if ((PlayerChoice == "paper" && CompChoice == "rock") || (PlayerChoice == "scissors" && CompChoice == "paper") || (PlayerChoice == "rock" && CompChoice == "scissors"))
      {
        Console.WriteLine("You Win");
      }
      else
      {
        Console.WriteLine("You Lose");
      }
    }



    public GameController(string choice)
    {
      PlayerChoice = choice;
      Playing = true;
    }
  }
}
