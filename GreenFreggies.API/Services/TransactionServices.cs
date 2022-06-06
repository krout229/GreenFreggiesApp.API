using GreenFreggies.API.Models;
using GreenFreggies.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Services
{
    public class TransactionServices
    {
        private ITransaction _transaction;
        public TransactionServices(ITransaction transaction)
        {
           _transaction=transaction;
        }
        public string SaveTransaction(Transaction transaction)
        {
            return _transaction.SaveTransaction(transaction);
        }
          
        public string DeleteTransaction(int TransactionId)
        {
            return _transaction.DeleteTransaction(TransactionId);
        }
        public string UpdateTransaction(Transaction transaction)
        {
            return _transaction.UpdateTransaction(transaction);
        }
        public Transaction GetTransaction(int TransactionId)
        {
            return _transaction.GetTransaction(TransactionId);
        }
        public List<Transaction> GetAllTransaction()
        {
            return _transaction.GetAllTransaction();
        }
    }

    
}
