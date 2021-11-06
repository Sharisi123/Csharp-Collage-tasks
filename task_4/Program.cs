using System;
using static System.Console;
using System.Globalization;
using System.Text;

namespace task_4
{
  class Program
  {
    private static void PrintTimeStamp(string name)
    {
      Console.OutputEncoding = Encoding.UTF8;

      DateTime localDate = DateTime.Now;

      var culture = new CultureInfo("ru-RU");
      WriteLine("Дата та час компіляції: {0}", localDate.ToString(culture));
      WriteLine("Автор: {0}", name);
    }

    static void Main(string[] args)
    {
      Write("Amount of bread : ");
      double breadAmount = Convert.ToDouble(ReadLine());

      double originalCost = breadAmount * 8.50;

      double sale = 0.6;

      double saleCost = originalCost * sale;

      Console.WriteLine($"Cost without sale {originalCost}");
      Console.WriteLine($"Sale 60% for yesterday bread");
      Console.WriteLine($"Cost with sale {saleCost}");

      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }
  }
}
