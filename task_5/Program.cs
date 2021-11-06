using System;
using static System.Console;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp5
{
  class Program
  {
    public struct Note
    {
      public string note;

      public int octave;

      public float frequence;
    };

    public static string letters = "ABCDEFG";


    public static List<Note> Notes = new List<Note>()
     {
            new Note { note = "A", octave = 4, frequence = 440.00f },

            new Note { note = "B", octave = 4, frequence = 493.88f },

            new Note { note = "C", octave = 4, frequence = 261.63f },

            new Note { note = "D", octave = 4, frequence = 293.66f },

            new Note { note = "E", octave = 4, frequence = 329.63f },

            new Note { note = "F", octave = 4, frequence = 349.23f },

            new Note { note = "G", octave = 4, frequence = 392.00f }

        };

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
      PrintTimeStamp("Наживотов Олександр");

      bool samtibool = true;

      while (samtibool)
      {
        int.TryParse(Console.ReadLine(), out int n);
        switch (n)
        {
          case 1:
            Notesbl();

            FirstVariation();
            samtibool = false;

            break;

          case 2:
            Notesbl();
            SecondVariation();
            samtibool = false;
            break;

          default:
            WriteLine("Incorrect input! Enter number '1' or '2':");

            break;
        }
      }
      Console.ReadKey(true);
    }

    static void FirstVariation()
    {
      WriteLine("\nEnter note: ");
      string note = Console.ReadLine();
      WriteLine(FindChastota(note));
    }

    static void SecondVariation()
    {
      WriteLine("\nEnter note altitude: ");
      float.TryParse(Console.ReadLine(), out float freq);
      WriteLine(GetNote(freq));

    }

    static float FindChastota(string str)
    {
      var freq = 0f;

      foreach (var note in Notes)
      {
        freq = note.note == str.Substring(0, 1) && note.octave == int.Parse((str.Substring(1, 1))) ? note.frequence : freq;
      }

      return freq;
    }

    static string GetNote(float freq)
    {
      string Str = "";

      foreach (var note in Notes)
      {
        Str = freq == note.frequence ? note.note + note.octave : Str;
      }

      return Str;
    }

    static void Notesbl()
    {
      for (int octave = 1; octave <= 8; octave++)
      {
        for (int letter = 0; letter < 7; letter++)
        {
          float freq4 = 0;
          string bukvaC = letters.Substring(letter, 1);
          foreach (var note in Notes)
          {
            freq4 = bukvaC == note.note && note.octave == 4 ? note.frequence : freq4;
          }

          float freq = freq4 / (float)Math.Pow(2, 4 - octave);

          Notes.Add(new Note { note = bukvaC, octave = octave, frequence = freq });
        }
      }
    }

  }
}
