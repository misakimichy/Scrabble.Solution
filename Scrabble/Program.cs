using System;
using System.Collections.Generic;

namespace ScrabbleGame.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine(Scrabble.GetScore("hello world"));
      // Scrabble.ResetScoreTotal();
    }
  }
}