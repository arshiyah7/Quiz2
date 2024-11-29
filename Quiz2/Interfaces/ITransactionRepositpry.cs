using Quiz2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Quiz2.Interfaces
{
    public interface ITransactionRepositpry
    {
        public void Add(Transsactions transaction);
        public List<Transsactions> GetTransactions(string cardnumber);

    }
}
