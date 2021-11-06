using System;
using static System.Console;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


namespace task_6
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
      Write("Enter number: ");

      int num = Convert.ToInt32(ReadLine());
      int copyNum = num;
      string result = "";
      while (true)
      {
        result += num % 2;

        num = num / 2;

        if (num == 0)
          break;
      }
      string num_of_two = "";

      for (int i = 0; i < result.Length; i++)
      {
        num_of_two += result[result.Length - 1 - i];

      }

      WriteLine($"From 10th to 2th:{copyNum} === {num_of_two}");

      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }
  }
}
