using System;
using static System.Console;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


namespace task_7
{
  class Program
  {

    static void PrintTimeStamp(string name)
    {
      Console.OutputEncoding = Encoding.UTF8;
      DateTime localDate = DateTime.Now;
      var culture = new CultureInfo("ru-RU");

      WriteLine("\nДата та час компіляції: {0}", localDate.ToString(culture));
      WriteLine("Автор: {0}", name);
    }
    static void Main(string[] args)
    {
      Write("How much cubes do you use per month:  ");

      int howCub = Convert.ToInt32(ReadLine());
      double allSum = 20;
      if (howCub <= 30)
      {
        allSum += howCub * 11.77;
      }
      else if (howCub <= 50 && howCub > 30)
      {
        allSum += 30 * 11.77 + (howCub - 30) * 13.22;
      }
      else if (howCub <= 60 && howCub > 50)
      {
        allSum += 30 * 11.77 + 20 * 13.22 + (howCub - 50) * 15.06;
      }
      else if (howCub > 60)
      {
        allSum += 30 * 11.77 + 20 * 13.22 + 10 * 15.06 + (howCub - 60) * 18.89;
      }


      WriteLine($"Amount to pay: {Math.Round(allSum, 2)}");

      PrintTimeStamp("Наживотов Олександр");

      Console.ReadKey(true);
    }
  }
}
