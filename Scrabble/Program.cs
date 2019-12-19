using System;
using System.Collections.Generic;

namespace ScrabbleGame.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Scrabble!");
      StartGame();
    }
    private static void StartGame()
    {
      Console.WriteLine("Enter a word and we'll return a Scrabble Score: ");
      int inputCheck;
      string userInput = Console.ReadLine();
      bool validInput = Int32.TryParse(userInput, out inputCheck);
      if(!validInput)
      {
        Console.WriteLine(Scrabble.GetScore(userInput));
        Scrabble.ResetScoreTotal();
        StartGame();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter a word!!!!!\n");
        Console.ResetColor();
        StartGame();
      }
    }
  }
}