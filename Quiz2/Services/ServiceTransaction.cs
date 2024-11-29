using Microsoft.Identity.Client;
using Quiz2.entities;
using Quiz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Services
{
    public class ServiceTransaction : IService
    {
        private readonly ICardRepository cardRepository;
        private readonly ITransactionRepositpry transactionRepositpry;
        public ServiceTransaction(ICardRepository cardRepository , ITransactionRepositpry transactionRepositpry)
        {
            this.transactionRepositpry = transactionRepositpry;
            this.cardRepository = cardRepository;
        }
        public string Transfer(string sourceCard, string destinationCard, float amount, string password)
        {
           if(string.IsNullOrEmpty(sourceCard) || string.IsNullOrEmpty(destinationCard) || amount <= 0)
            {
                return "source card number or destination card number is empty or amount is 0";
            }
           var sourcecard = cardRepository.Get(sourceCard);
            var destinationcard = cardRepository.Get(destinationCard);

            if(sourcecard == null || !sourcecard.IsActive || destinationcard == null)
            {
                return "card is not active or card number is not entered";
            }
            if(sourcecard.Balance < amount)
            {
                return "amount is not enough";
            }
            sourcecard.Balance -= amount;
            destinationcard.Balance += amount;

            var transactions = new Transsactions
            {
               SourceCardNumber = sourceCard,
               DestinationCardNumber = destinationCard,
               Amount = amount,
               TransactionDate = DateTime.Now,
               isSuccessful = true,

            };
            transactionRepositpry.Add(transactions);
            return "SUCCESS";

        }
    }
}
