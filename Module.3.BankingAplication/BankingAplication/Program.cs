// See https://aka.ms/new-console-template for more information
using BankingAplication;
using BankingAplication.Customers;

BankAccount account = new BankAccount(new OrdinaryCustomer("Thomas", "Anderson", 10000));
account.ShowInfo();
Console.WriteLine("The total amount of the deposit " + Math.Round(account.Deposit(2000, 3),2)+ "$\n");
Console.WriteLine(account.ShowInfo());

account.Deposit(500,3);
BankAccount account1 = new BankAccount(new OrdinaryCustomer("Mark", "Smith", 5000));

Console.WriteLine("\n" + account1.ShowInfo());
Console.WriteLine(account1.RequestCredit(100, 2));
