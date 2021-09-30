using System;
using System.Collections.Generic;
using System.Linq;

namespace ACOD3
{
  class Program
  {
    static public void printDeck(List<string> deck) 
    {
      foreach (var card in deck)
        {
          System.Console.WriteLine(card);
        }
    }

    static void Main(string[] args)
    {
      // Initialize variables
      var deck = new List<string>();
      var suits = new string[] {"♠️", "♥️", "♦️", "♣️"};
      var ranks = new string[] {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};

      foreach (var suit in suits)
      {
        foreach (var rank in ranks)
        {
          deck.Add($"{suit}{rank}");
        }
      }

      printDeck(deck);

      // Shuffle Deck
      var deckCount = deck.Count();
      var randomNumber = new Random();
      for (var rightIndex = deckCount - 1; rightIndex > 0; rightIndex--)
      {
        var leftIndex = randomNumber.Next(rightIndex - 1);
        var leftCard = deck[rightIndex];
        var rightCard = deck[leftIndex];

        deck[rightIndex] = rightCard;
        deck[leftIndex]= leftCard;
      }

      printDeck(deck);
    }
  }
}
