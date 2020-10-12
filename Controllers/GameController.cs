using System;

namespace CSharpRPS.Controllers
{
  class GameController
  {
    public string PlayerChoice { get; private set; }
    public bool Playing { get; set; }

    public void Run()
    {
      while (Playing)
      {
        GetUserInput();
      }
    }
    private void GetUserInput()
    {
      System.Console.WriteLine("Rock, Paper, Scissors or quit?");
      var input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "quit":
          Playing = false;
          Console.WriteLine("Game Ended");
          break;
        case "rock":
        case "paper":
        case "scissors":
          Console.WriteLine("You chose a thing.");
          break;
        default:
          Console.WriteLine("Invalid Command");
          break;
      }
    }

    public GameController(string choice)
    {
      PlayerChoice = choice;
      Playing = true;
    }
  }
}
