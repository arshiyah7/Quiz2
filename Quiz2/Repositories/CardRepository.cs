using Quiz2.entities;
using Quiz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Repositories
{
    public class CardRepository : ICardRepository
    {
        public List <Card> Cards = new List<Card> ();

        public void Add(Card card)
        {
            Cards.Add (card);
        }

        public Card Get(string cardnumber)
        {
            return Cards.Find(c => c.CardNumber == cardnumber);
        }
    }
}
