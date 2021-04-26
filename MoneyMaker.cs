using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins: ");
      string totalAsString = Console.ReadLine();
      double totalAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{totalAsDouble} cents is equal to...");
      int gold = 10;
      int silver = 5;

      // calculating gold coins
      double goldCoins = Math.Floor(totalAsDouble / gold);
      double leftOver = totalAsDouble % gold;
      double silverCoins = Math.Floor(leftOver / silver);
      double remainder = leftOver % silver;

      // printing all coins
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");

    }
  }
}
