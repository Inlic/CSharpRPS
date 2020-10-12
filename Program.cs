using System;
using System.Threading;
using CSharpRPS.Controllers;

namespace CSharpRPS
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine(@"
______           _     ______                       _____      _                        
| ___ \         | |    | ___ \                     /  ___|    (_)                       
| |_/ /___   ___| | __ | |_/ /_ _ _ __   ___ _ __  \ `--.  ___ _ ___ ___  ___  _ __ ___ 
|    // _ \ / __| |/ / |  __/ _` | '_ \ / _ \ '__|  `--. \/ __| / __/ __|/ _ \| '__/ __|
| |\ \ (_) | (__|   <  | | | (_| | |_) |  __/ |    /\__/ / (__| \__ \__ \ (_) | |  \__ \
\_| \_\___/ \___|_|\_\ \_|  \__,_| .__/ \___|_|    \____/ \___|_|___/___/\___/|_|  |___/
                                 | |                                                    
                                 |_|                                                    
            ");
      Console.WriteLine("Choose Your Input (Rock, Paper, Scissors)");
      var choice = Console.ReadLine();
      GameController gc;
      gc = new GameController(choice);
      gc.Run();

    }
  }
}
