using GreenFreggies.API.Data;
using GreenFreggies.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
    public class TransactionRepository : ITransaction
    {
        private VegetablesDbContext _vegetablesDb;
        public TransactionRepository(VegetablesDbContext vegetablesDb)
        {
            _vegetablesDb = vegetablesDb;
        }
        public string DeleteTransaction(int TransactionId)
        {
            string msg = "";
            Transaction deleteTransaction = _vegetablesDb.transactions.Find(TransactionId);//storing the details of the vegetable in the obj 
            if (deleteTransaction != null)
            {
                _vegetablesDb.transactions.Remove(deleteTransaction);
                _vegetablesDb.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Transaction> GetAllTransaction()
        {
            List<Transaction> transactions = _vegetablesDb.transactions.ToList();
            return transactions;
        }

        public Transaction GetTransaction(int TransactionId)
        {
            Transaction transaction = _vegetablesDb.transactions.Find(TransactionId);
            return transaction;
        }

        public string SaveTransaction(Transaction transaction)
        {
            _vegetablesDb.transactions.Add(transaction);
            _vegetablesDb.SaveChanges();
            return "Saved";
        }

        public string UpdateTransaction(Transaction transaction)
        {
            _vegetablesDb.Entry(transaction).State = EntityState.Modified;
            _vegetablesDb.SaveChanges();
            return "Updated";
        }
    }
}
