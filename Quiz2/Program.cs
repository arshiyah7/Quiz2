
using Quiz2.Interfaces;
using Quiz2.Repositories;
using Quiz2.Services;

ICardRepository cardrep = new CardRepository();
ITransactionRepositpry tranrep = new TransactionRepository();

IService servicerep = new ServiceTransaction(cardrep, tranrep);

cardrep.Add(new Quiz2.entities.Card
{
    CardNumber = "1234567912345678",
    HoldersName = "ali",
    Balance = 200,
    IsActive = true,
    Password = "pass",

});
while (true)
{
    Console.WriteLine("please enter your choice");
    Console.WriteLine("1)transfer");
    Console.WriteLine("2)exite");
    string ch = Console.ReadLine();
    switch (ch)
    {
        case "1":

            Console.WriteLine("source card number");
            string source = Console.ReadLine();
            Console.WriteLine("destination number");
            string dis = Console.ReadLine();
            Console.WriteLine("insert an amount");
             float amount = float.Parse(Console.ReadLine());
            Console.WriteLine("insert password");
            string pass = Console.ReadLine();

            break;
    }
}



