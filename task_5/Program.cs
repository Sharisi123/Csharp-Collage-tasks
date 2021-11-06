using System;
using static System.Console;
using System.Globalization;
using System.Text;

namespace task_5
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
      DateTime birthDate = new DateTime(2004, 04, 15);

      DateTime today = DateTime.Today;

      Clear();

      WriteLine($"Days {today.Subtract(birthDate)} gone");

      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }


  }
}