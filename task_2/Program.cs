using System;
using System.Text;
using System.Globalization;

namespace task_2
{
  class Program
  {
    static public int Cheaker(int value)
    {
      if (value <= 0)
      {
        Console.WriteLine($"Setter change {value} on 1");
        return 1;
      }
      return value;

    }
    class Rectangle
    {
      private int _w;
      private int _l;
      private int _h;
      public int W
      {
        get
        {
          return _w;
        }
        private set
        {
          _w = Cheaker(value);
        }
      }
      public int L
      {
        get
        {
          return _l;
        }
        private set
        {
          _l = Cheaker(value);
        }
      }
      public int H
      {
        get
        {
          return _h;
        }
        private set
        {
          _h = Cheaker(value);
        }
      }
      public Rectangle(int w, int l, int h)
      {
        W = w;
        L = l;
        H = h;
      }

      int findVolume()
      {
        return L * W * H;
      }
      int findLateralSurfaceArea()
      {
        return 2 * L * H + 2 * W * H;
      }

      int findSurfaceArea()
      {
        return 2 * L * W + 2 * L * H + 2 * W * H;
      }
    }
    static void Main(string[] args)
    {
      PrintTimeStamp("Наживотов Олександр");

      static void PrintTimeStamp(string name)
      {
        Console.OutputEncoding = Encoding.UTF8;
        DateTime localDate = DateTime.Now;
        var culture = new CultureInfo("ru-RU");

        Console.WriteLine("\nДата та час компіляції: {0}", localDate.ToString(culture));
        Console.WriteLine("Автор: {0}", name);
      }

      Rectangle rect = new Rectangle(5, 2, 4);
      Rectangle rect1 = new Rectangle(-5, 2, 4);
    }
  }
}
