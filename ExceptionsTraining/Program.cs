using ExceptionsTraining.Entities;
using System.Globalization;
using System;
using ExceptionsTraining.Entities.Exceptions;

try
{
Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, initialBalance, withdrawLimit);

Console.Write("\nEnter amount for withdraw: ");
acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine($"New balance: {acc.Balance}");
}
catch (DomainException e)
{

	Console.WriteLine($"Error in your operation: {e.Message}"); ;
}

