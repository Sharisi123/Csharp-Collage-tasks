using System;
using static System.Console;
using System.Globalization;
using System.Text;

namespace task_1
{
  class Program
  {

    public static void PrintTimeStamp(string name)
    {
      Console.OutputEncoding = Encoding.UTF8;

      DateTime localDate = DateTime.Now;

      var culture = new CultureInfo("ru-RU");
      WriteLine("Дата та час компіляції: {0}", localDate.ToString(culture));
      WriteLine("Автор: {0}", name);
    }

    static void Main(string[] args)
    {
      const double rubB = 0.35;
      const double euroB = 30.5;
      const double dollarB = 26.35;

      const double rubS = 0.38;
      const double euroS = 31.1;
      const double dollarS = 26.75;

      Write("Enter value of hrivnas: ");
      int num = Convert.ToInt32(ReadLine());

      double rubBuyCount = num / rubB;
      double euroBuyCount = num / euroB;
      double dollarsBuyCount = num / dollarB;

      double rubSaleCount = num / rubS;
      double euroSaleCount = num / euroS;
      double dollarSaleCount = num / dollarS;

      WriteLine("On this money, you can buy: ");
      WriteLine($"{Math.Round(rubBuyCount, 2)} rubles");
      WriteLine($"{Math.Round(euroBuyCount, 2)} euros");
      WriteLine($"{Math.Round(dollarsBuyCount, 2)} dollars");

      WriteLine($"You need to sell rubles, euros, dollars to get {num} hryvnias");
      WriteLine($"{Math.Round(rubSaleCount, 2)} rubles");
      WriteLine($"{Math.Round(euroSaleCount, 2)} euros");
      WriteLine($"{Math.Round(dollarSaleCount, 2)} dollars");

      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }
  }
}
