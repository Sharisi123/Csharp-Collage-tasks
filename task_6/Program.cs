using System;
using static System.Console;
using System.Globalization;
using System.Text;

namespace task_6
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
      uint r, g, b = 0;

      WriteLine("Enter RGB-color: (from 0 to 256)");
      var code = ReadLine();

      uint number = uint.Parse(code, NumberStyles.AllowHexSpecifier);

      r = number >> 16;

      g = number << 16 >> 24;

      b = number << 24 >> 24;

      WriteLine($"Red: {r}");

      WriteLine($"GREEN: {g}");

      WriteLine($"BLUE: {b}");

      PrintTimeStamp("Наживотов Олександр");

      Console.ReadKey(true);
    }
  }
}
