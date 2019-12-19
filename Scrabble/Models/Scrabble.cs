using System;
using System.Collections.Generic;

namespace ScrabbleGame.Models
{
  public class Scrabble
  {
    public static Dictionary<string, int> _scoreDict = new Dictionary<string, int>() {{"A,E,I,O,U,L,N,R,S,T", 1}, {"D,G", 2}, {"B,C,M,P", 3}, {"F,H,V,W,Y", 4}, {"K", 5}, {"J,X", 8}, {"Q,Z", 10}};
    public static int ScoreTotal;

    // Constructor
    public Scrabble()
    {
      ScoreTotal = 0;
    }
    public static int GetScore(string userInput)
    {
      char[] inputArray = userInput.ToUpper().ToCharArray();
      foreach (KeyValuePair<string, int> pair in _scoreDict)
      {
        for(int i = 0; i < inputArray.Length; i++)
        {
          if(pair.Key.Contains(inputArray[i]))
          {
            ScoreTotal += pair.Value;
          }
        }
      }
      return ScoreTotal; 
    }
    public static void ResetScoreTotal()
    {
      ScoreTotal = 0;
    }
  }
}