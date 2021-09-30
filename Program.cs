using System;
using System.Collections.Generic;

namespace ACOD3
{
  class Program
  {
    static void Main(string[] args)
    {
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

      foreach (var card in deck)
      {
        System.Console.WriteLine(card);
      }
    }
  }
}
