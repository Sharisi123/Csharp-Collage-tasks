using System;
using System.IO;
using static System.Console;
using System.Globalization;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace task_3
{
  class Program
  {
    static void Main(string[] args)
    {
      string plainText = File.ReadAllText("./index.html");

      string hrefPattern = @"href\s*=\s*(?:[""'](?<1>[^""']*)[""']|(?<1>[^>\s]+))";

      try
      {
        Match regexMatch = Regex.Match(plainText, hrefPattern,
                                       RegexOptions.IgnoreCase | RegexOptions.Compiled,
                                       TimeSpan.FromSeconds(1));
        while (regexMatch.Success)
        {
          Console.WriteLine($"Found href {regexMatch.Groups[1]}");
          regexMatch = regexMatch.NextMatch();
        }
      }
      catch (RegexMatchTimeoutException)
      {
        Console.WriteLine("The matching operation timed out.");
      }

    }
  }
}
