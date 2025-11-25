

using CustomExceptionApp.Domain;

Account acc1 = new Account(1, "Hemang", 1000);

try
{// open
    acc1.Withdraw(2 * 1000);
    //error

    //close()
}

catch (EmersonInsufficientFundsException ex)
{// exepects an object excpetion or subclasess
    Console.ForegroundColor = ConsoleColor.Red;
    // Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}
catch (Exception ex)
{
  
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Executes all the time, not matter exception happened or not");
    PrintInfo(acc1);

    //close(),dispose db connections
}






void PrintInfo(Account acc)
{
    Console.WriteLine("accno is "+acc.AccountNo);
    Console.WriteLine("name is " + acc.Name);
    Console.WriteLine("balance " + acc.Balance);
}