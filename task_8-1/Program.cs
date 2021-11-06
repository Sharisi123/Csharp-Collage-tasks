using System;
using static System.Console;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace task_8
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

      WriteLine(typeof(int) + "   " + sizeof(int) + "  " + int.MaxValue + "  " + int.MinValue);

      WriteLine(typeof(bool) + " " + sizeof(bool) + "  " + false, true);

      WriteLine(typeof(float) + "  " + sizeof(float) + "  " + float.MaxValue + "  " + float.MinValue);

      WriteLine(typeof(char) + "    " + sizeof(char) + "  " + char.MaxValue + "  " + char.MinValue);

      WriteLine(typeof(long) + "   " + sizeof(long) + "  " + long.MaxValue + "  " + long.MinValue);

      WriteLine(typeof(short) + "   " + sizeof(short) + "  " + short.MaxValue + "  " + short.MinValue);

      WriteLine(typeof(double) + "  " + sizeof(double) + "  " + double.MaxValue + "  " + double.MinValue);

      WriteLine(typeof(byte) + "    " + sizeof(byte) + "  " + byte.MaxValue + "  " + byte.MinValue);

      WriteLine(typeof(sbyte) + "   " + sizeof(sbyte) + "  " + sbyte.MaxValue + "  " + sbyte.MinValue);

      WriteLine(typeof(ulong) + "  " + sizeof(ulong) + "  " + ulong.MaxValue + "  " + ulong.MinValue);

      WriteLine(typeof(uint) + "  " + sizeof(uint) + "  " + uint.MaxValue + "  " + uint.MinValue);

      WriteLine(typeof(ushort) + "  " + sizeof(ushort) + "  " + ushort.MaxValue + "  " + ushort.MinValue);



      PrintTimeStamp("Наживотов Олександр");
      Console.ReadKey(true);
    }
  }
}