using System;
using System.Text;
using System.Globalization;

namespace task_1
{
  class Program
  {
    class BankAccount
    {
      public static int id = 0;

      private int Balance { get; set; }
      private string Currency { get; set; }
      public BankAccount(int balance = 0, string currency = "uan")
      {
        id++;
        Balance = balance;
        Currency = currency;
      }

      public void Deposit(int amount)
      {
        if (Currency == "uan" & amount > 50000 | Currency == "usd" & amount > 2000 | Currency == "eu" & amount > 2000)
          Console.WriteLine("We will notify a tax office");

        Balance += amount;
        Console.WriteLine($"Depositing {amount}, current balance is {Balance} \n");
      }

      public void Withdraw(int amount)
      {
        if (amount > Balance)
        {
          Console.WriteLine($"Not enough money, your current balance is: {Balance} \n");
          return;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawing {amount}, current balance is {Balance} \n");
      }

      public void ShowInfo()
      {
        Console.WriteLine($"Number of balance is: {id} \nCurrent balance is: {Balance} {Currency} \n");
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

      BankAccount account = new BankAccount();
      account.Deposit(300);
      account.Withdraw(301);
      account.ShowInfo();
    }
  }
}
