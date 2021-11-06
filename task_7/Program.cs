using System;
using static System.Console;
using System.Globalization;
using System.Text;

namespace task_7
{
  class Program
  {
    public static void PrintTimeStamp(string name)
    {
      Console.OutputEncoding = Encoding.UTF8;

      DateTime localDate = DateTime.Now;

      var culture = new CultureInfo("ru-RU");
      Console.WriteLine("Дата та час компіляції: {0}", localDate.ToString(culture));
      Console.WriteLine("Автор: {0}", name);
    }

    static void Main(string[] args)
    {
      WriteLine("Enter x1: (from 1 to 8)");
      int x1 = Convert.ToInt32(ReadLine());
      WriteLine("Enter x1: (from 1 to 8)");
      int x2 = Convert.ToInt32(ReadLine());
      WriteLine("Enter x1: (from 1 to 8)");
      int y1 = Convert.ToInt32(ReadLine());
      WriteLine("Enter x1: (from 1 to 8)");
      int y2 = Convert.ToInt32(ReadLine());

      WriteLine($"{(x1 + y1) % 2 == 0 && (x2 + y2) % 2 == 0}");
      PrintTimeStamp("Наживотов Олександр");
    }
  }
}
