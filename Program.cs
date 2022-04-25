//BankAccount account1 = new BankAccount('M', 5000.00m, 123, "Mathew", "Desjardins");

//BankAccount account2 = new BankAccount(account1);

BankAccount account3 = new BankAccount('S', 100M, 142, "Joe", "Smith");


//System.Console.WriteLine(account1);
//System.Console.WriteLine(account2);


//System.Console.WriteLine("Account 3 earned : " + account3.MonthlyInterest().ToString("C") + " in interest this month!");
//System.Console.WriteLine(account3);


for(int i = 0; i < 12; i++)
{
    System.Console.WriteLine("\n\n\nMonth " + (i+1));
    System.Console.WriteLine("Account 3 earned : " + account3.MonthlyInterest().ToString("C") + " in interest this month!");
    System.Console.WriteLine(account3);
    System.Console.WriteLine(account3.ToString());
}

