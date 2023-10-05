
BankAccount myAccount = new BankAccount();

myAccount.Deposit(2000);
Console.WriteLine($"Account balance is : {myAccount.Balance}");

myAccount.Withdraw(1500);
Console.WriteLine($"Account balance is : {myAccount.Balance}");

BankAccount bankAccount = new BankAccount("Nathaniel");

bankAccount.Deposit(2000);
Console.WriteLine($"Account balance of {bankAccount.Name} is: {bankAccount.Balance}");
bankAccount.Withdraw(1500);
Console.WriteLine($"Account balance of {bankAccount.Name} is: {bankAccount.Balance}");
