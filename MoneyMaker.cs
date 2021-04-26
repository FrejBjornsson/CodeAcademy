/*
Money Maker
You have three types of coins:

A bronze coin is worth 1 cent
A silver coin is worth 5 cents
A gold coin is worth 10 cents
What is the minimum number of coins that equals 98 cents?

It’s a hard question to answer in your head, but it’s a fun problem to solve with programming. In this project you’ll use C# to build a Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value.

For example, 16 cents could be:

16 bronze coins,
3 silver coins and 1 bronze coin, or
1 gold coin, 1 silver coin, 1 bronze coin
*/


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
