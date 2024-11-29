using Quiz2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Interfaces
{
    public interface ICardRepository
    {

        public void Add(Card card); 
        public Card Get(string cardnumber);
    }
}
