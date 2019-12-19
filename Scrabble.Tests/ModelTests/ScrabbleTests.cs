using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleGame.Models;
using System.Collections.Generic;

namespace ScrabbleGame.Tests
{
    [TestClass]
    public class ScrabbleTester
    {
        [TestMethod]
        public void ScrabbleInstance_InstanceOfScrabble_ScoreTotal()
        {
            Scrabble instanceOfScrabble = new Scrabble();
            Assert.AreEqual(typeof(Scrabble), instanceOfScrabble.GetType());          
        }
        [TestMethod]
        public void ScrabbleTester_ReturnScore_int()
        {
            int resultWord = Scrabble.GetScore("Hello");
            Assert.AreEqual(8, resultWord);          
        }
        [TestMethod]
        public void ScrabbleTester_ReturnScoreForSentence_int()
        {
            Scrabble.ResetScoreTotal();
            int resultSentence = Scrabble.GetScore("Hello world");
            Assert.AreEqual(17, resultSentence);          
        }
    }
}