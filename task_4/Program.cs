using System;
using static System.Console;
using System.Globalization;
using System.Text;
using System.Linq;

namespace task_4
{
  class Number
  {
    private int number;
    private string numbersWithAmbit;
    private string count;
    private string twoness;

    private int[] redNum = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 36 };
    private int[] numbers = new int[38] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 00 };
    public Number()
    {
      Random rand = new Random();
      int j = rand.Next(39);
      number = numbers[j];
      if (redNum.Contains(number))
      {
        count = "Червоне";
      }
      else if (number == 0 || number == 00)
      {
        count = "";
      }
      else
      {
        count = "Чорне";
      }

      if (number <= 18 && (number != 0 || number != 00))
      {
        numbersWithAmbit = "Від 1 до 18";
      }
      else if (number == 0 || number == 00)
      {
        numbersWithAmbit = "";
      }
      else
      {
        numbersWithAmbit = "Від 19 до 36";
      }

      if (number % 2 == 0)
      {
        twoness = "Парне";
      }
      else if (number == 0 || number == 00)
      {
        twoness = "";
      }
      else
      {
        twoness = "Непарне";
      }

    }

    public string GetColor()
    {
      return count;
    }

    public string GetTwoness()
    {
      return twoness;
    }

    public int GetNumber()
    {
      return number;
    }


    public string GetNumbersWithAmbit()
    {
      return numbersWithAmbit;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Number num = new Number();
      if (num.GetNumber() == 0 || num.GetNumber() == 00)
      {
        WriteLine("On roulette: {0}\n", num.GetNumber());

        WriteLine("- {0}", num.GetNumber());
      }
      else
      {
        WriteLine("On roulette: {0}\n", num.GetNumber());
        WriteLine("- {0}", num.GetNumber());
        WriteLine("- {0}", num.GetColor());
        WriteLine("- {0}", num.GetTwoness());
        WriteLine("- {0}", num.GetNumbersWithAmbit());
      }
      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }
    public static void PrintTimeStamp(string name)
    {
      Console.OutputEncoding = Encoding.UTF8;
      DateTime localDate = DateTime.Now;
      var culture = new CultureInfo("ru-RU");

      WriteLine("\nДата та час компіляції: {0}", localDate.ToString(culture));
      WriteLine("Автор: {0}", name);
    }
  }
}
