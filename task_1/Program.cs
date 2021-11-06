using System;
using static System.Console;
using System.Globalization;

using System.Text;

namespace task_1
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintTimeStamp("Наживотов Олександр");

      static void PrintTimeStamp(string name)
      {
        Console.OutputEncoding = Encoding.UTF8;
        DateTime localDate = DateTime.Now;
        var culture = new CultureInfo("ru-RU");

        Console.WriteLine("\nДата та час компіляції: {0}", localDate.ToString(culture));
        Console.WriteLine("Автор: {0}", name);
      }
      WriteLine("Enter cost:");
      double accum = 0;
      string num = null;
      while (true)
      {
        num = ReadLine();
        if (String.IsNullOrEmpty(num))
          break;
        accum += Convert.ToDouble(num);
      }

      double accums_drob = Math.Round((accum - Math.Floor(accum)), 2);
      WriteLine($"All summ {Math.Round(accum, 2)}, coins: {accums_drob}");
      if ((accums_drob * 100) % 10 >= 5)
      {
        accum = Math.Round(accum, 1);
        WriteLine($"Paid: {accum}");
      }
      else
      {
        WriteLine($"Paid: {Math.Round(accum, 1)}");
      }
      Console.ReadKey(true);
    }
  }
}
