public class BankAccount
{
    private int accountNumber;
    private char type;
    private decimal balance;

    public string FirstName { get; set; }
    public string LastName { get; set; }
  //TODO
    public BankAccount(char type, decimal intialDeposit, int accountNumber, string firstName, string lastName)
    {
        type = type.ToString().ToUpper()[0];

        if(type == 'S' && intialDeposit >= 5.00m)
        {
            this.accountNumber = accountNumber;
            this.balance = intialDeposit;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.type = type;
        }
        else if(type == 'M' && intialDeposit >= 1000.00m)
        {
            this.accountNumber = accountNumber;
            this.balance = intialDeposit;   
            this.FirstName = firstName;
            this.LastName = lastName;
            this.type = type;
        }
        else
        {
            this.accountNumber = accountNumber;
            this.balance = intialDeposit;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.type = 'C';
        }

        
    }
  //TODO
    public BankAccount(BankAccount obj)
    {
            this.accountNumber = obj.accountNumber;
            this.balance = obj.balance;
            this.FirstName = obj.FirstName;
            this.LastName = obj.LastName;
            this.type = obj.type;
    }

    public int GetAccountNumber()
    {
        return this.accountNumber;
    }

    public decimal GetAccountBalance()
    {
        return this.balance;
    }
  //TODO
    public string GetAccountTypeAsAString()
    {
        //string accountType = "";

        /*
        switch(type)
        {
            case 'C':
            accountType = "Checking Account";
            break;

            case 'M':
            accountType = "Money-Market Account";
            break;

            case 'S':
            accountType = "Savings Account";
            break;

        }
        */
        if(type == 'C')
        {
            //accountType = "Checking Account";
            return "Checking Account";

        }
        else if(type == 'M')
        {
           // accountType = "Money-Market Account";
           return "Money-Market Account";
        
        }
        else
        {
            //accountType = "Savings Account";
             return "Savings Account";
        }
      
      //return accountType;
    }
  //TODO
    public bool Deposit(decimal amount)
    {
       if(amount <= 0)
       {
           return false;
       }
       else
       {
           //balance = balance + amount;
           balance += amount;
           return true;
       }
    }
    //TODO
    public bool Withdrawal(decimal amount)
    {
       if(amount <= 0)
       {
           return false;
       }
       else
       {
            switch(type)
            {
                case 'C':

                    if(amount > balance)
                    {
                        return false;
                    }
                    else
                    {
                        balance -= amount;
                        return true;
                    }

                break;

                case 'M':
                    
                    if(amount > balance || amount > 250 || (balance - amount) < 1000m)
                    {
                        return false;
                    }
                    else
                    {
                        balance -= amount;
                        return true;
                    }
               
                break;

                case 'S':

                    if(amount > balance || amount > 500 || (balance - amount) < 5m)
                    {
                        return false;
                    }
                    else
                    {
                        balance -= amount;
                        return true;
                    }

                break;

            }
       }

       return false;
    }

    //TODO
    public decimal MonthlyInterest()
    {
        decimal interest = 0.0m;

        switch(type)
        {
            case 'C':
            interest = balance * .005m;
            break;

            case 'M':
            interest = balance * .08m;
            break;

            case 'S':
            interest = balance * .024m;
            break;

        }
        
        balance = balance + interest;
        //balance += interest;

        return interest;
    }
    //TODO
    public override bool Equals(object obj)
    {
        BankAccount otherObject = (BankAccount)obj;

        return otherObject.type == this.type && otherObject.balance == this.balance && otherObject.accountNumber == this.accountNumber;
    }

    //TODO   
    public bool Equals(BankAccount obj)
    {
        return obj.type == this.type && obj.balance == this.balance && obj.accountNumber == this.accountNumber;
        
        /*
        if(obj.type == this.type && obj.balance == this.balance && obj.accountNumber == this.accountNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
        */
    }

    public override string ToString()
    {
        string msg = "";

        msg += "\nName: " + FirstName + " " + LastName;
        msg += $"\nAccount Number: {accountNumber}";
        msg += $"\nAccount type: {GetAccountTypeAsAString()}";
        msg += $"\nCurrent Balance: {balance.ToString("C")}";

        if(type == 'C')
        {
            msg += $"\nCurrent Monthly Interest Rate: .5%";
        }
        else if(type == 'S')
        {
            msg += $"\nCurrent Monthly Interest Rate: 2.4%";
        }
        else if(type == 'M')
        {
            msg += $"\nCurrent Monthly Interest Rate: 8.0%";
        }

        /*
            Name: Mathew Desjardins
            Account Number: 1
            Account Type: Money Market Account
            Current Balance: $25.90
            Current Monthly Interest Rate: 8.00%
        */
        return msg;
    }

}