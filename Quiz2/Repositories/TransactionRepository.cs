using Quiz2.entities;
using Quiz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Quiz2.Repositories
{
    public class TransactionRepository : ITransactionRepositpry
    {
       
        public List<Transsactions> transactions = new List<Transsactions>();
        public void Add(Transsactions transaction)
        {
           transactions.Add(transaction);
        }

        public List<Transsactions> GetTransactions(string cardnumber)
        {
           return transactions.FindAll(t => t.SourceCardNumber == cardnumber || t.DestinationCardNumber == cardnumber);
        }
    }
}
