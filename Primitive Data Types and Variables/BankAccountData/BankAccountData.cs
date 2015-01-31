/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Piotr";
        string middleName = "Ilich";
        string lastName = "Tchaikovsky";
        decimal balance = 456564.99m;
        string bankName = "Asset Bank";
        string iban = "CH93 0076 2011 6238 5295 7";
        long firstCreditCardNumber = 45654564878745;
        long secondCreditCardNumber = 65154876864646;
        long thirdCreditCardNumber = 64454454587864;
        Console.WriteLine("Account holder name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Account balance: {0} CHF", balance);
        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit Cards Numbers:\n1.{0}\n2.{1}\n3.{2}", firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
    }
}

