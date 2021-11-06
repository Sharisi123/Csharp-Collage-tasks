using System;
using static System.Console;
using System.Globalization;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConsoleApp2
{

  public static class StringExtension
  {
    public static string ExtraSymbol(this string stringToClean)
    {

      return string.Join(" ", stringToClean.Split(new[]
      { ' ', '.', ',', '!', '?', '”', '&', '#', '%', '(', '<', ')', '$','>','*','+', '-', '/', ':', '@', '~', '{', '}', '|', '_'},
          StringSplitOptions.RemoveEmptyEntries));
    }

  }

  class Program
  {
    public static void PrintTimeStamp(string name)
    {
      Console.OutputEncoding = Encoding.UTF8;
      DateTime localDate = DateTime.Now;
      var culture = new CultureInfo("ru-RU");

      Console.WriteLine("\nДата та час компіляції: {0}", localDate.ToString(culture));
      Console.WriteLine("Автор: {0}", name);
    }

    static void Main(string[] args)
    {
      Write("Enter text: ");

      string input = Console.ReadLine();

      string output = input.ToLower();

      output = Regex.Replace(output, @"[\d-]", string.Empty);

      output = output.ExtraSymbol();

      WriteLine(output);

      PrintTimeStamp("Наживотов Олександр");

      Console.ReadKey(true);
    }

  }

}
