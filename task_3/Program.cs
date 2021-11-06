using System;
using static System.Console;
using System.Text;
using System.Globalization;

namespace task_3
{
  class Program
  {
    private const double RADIAN = 6371.01;
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

      double lvivLat = ConvertToRadians(49.8383);
      double lvivLng = ConvertToRadians(24.0232);

      double kharkivLat = ConvertToRadians(30.5238);
      double kharkivLng = ConvertToRadians(36.2527);

      double kievLng = ConvertToRadians(30.5238);
      double kievLat = ConvertToRadians(50.4547);

      double odessaLat = ConvertToRadians(46.4775);
      double odessaLng = ConvertToRadians(30.7326);

      double lviv_Odessa = range(lvivLng, odessaLng, lvivLng, odessaLat);

      double kiev_Odessa = range(kievLng, odessaLng, kievLat, odessaLat);

      double lviv_Kiev = range(lvivLng, kievLng, lvivLng, kievLat);

      double kharkiv_Odessa = range(kharkivLng, odessaLng, kharkivLat, odessaLat);

      double kharkiv_Kiev = range(kharkivLng, kievLng, kharkivLat, kievLat);

      double surface = geron(lviv_Odessa, lviv_Kiev, kiev_Odessa) + geron(kharkiv_Kiev, kharkiv_Odessa, kiev_Odessa);

      WriteLine($"area is: {Math.Round(surface, 2)} square km");

      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }

    private static double range(double long1, double long2, double lot1, double lot2)
    {
      return RADIAN * Math.Acos(Math.Sin(long1) * Math.Sin(long2) + Math.Cos(long1) * Math.Cos(long2) * Math.Cos(lot1 - lot2));
    }

    public static double ConvertToRadians(double a)
    {
      return (Math.PI / 180) * a;
    }

    private static double geron(double range1, double range2, double range3)
    {
      double halfP = (range1 + range2 + range3) / 2;
      return Math.Sqrt(halfP * (halfP - range1) * (halfP - range2) * (halfP - range3));
    }
  }
}
