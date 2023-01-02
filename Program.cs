// See https://aka.ms/new-console-template for more information

using Service;

Console.WriteLine("Hello Customer!");
AccountService ac = new AccountServiceImpl();
ac.AddNewAccount(1,"MAD",2001);
ac.AddNewAccount(2,"MAD",3000);
ac.AddNewAccount(3,"USD",-1000);
ac.AddNewAccount(4,"MAD",-8960);

List<Account> listAccounts = ac.GetAllAccounts();
foreach (Account a in listAccounts) {
            Console.WriteLine(a);
        }
Console.WriteLine("=====================");
List<Account> DebitedAccounts = ac.GetDebitedAccounts();
foreach (Account acc in DebitedAccounts) {
            Console.WriteLine(acc);
        }
Console.WriteLine("=====================");

Console.WriteLine(ac.GetBalanceAVG());