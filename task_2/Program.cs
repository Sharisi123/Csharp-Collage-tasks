using System;
using static System.Console;
using System.Globalization;
using System.Text;

namespace task_2
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
      Write("Print pressure: ");
      int pressure = Convert.ToInt32(ReadLine());

      Write("Print temperature: ");
      double t = Convert.ToInt32(ReadLine());
      t += 273;

      Write("Print capacity: ");
      double v = Convert.ToInt32(ReadLine());
      v *= 0.001;

      const double R = 8.314;
      double n = (pressure * v) / (R * t);

      WriteLine($"Moles is: {n}");
      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }
  }
}
