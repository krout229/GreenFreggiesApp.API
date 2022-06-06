using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
   public interface ITransaction
    {
        public string SaveTransaction(Transaction transaction);
        
        public string UpdateTransaction(Transaction transaction);
        public string DeleteTransaction(int TransactionId);
        Transaction GetTransaction(int TransactionId);
        List<Transaction> GetAllTransaction();
    }
}
