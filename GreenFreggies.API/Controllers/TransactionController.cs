﻿using GreenFreggies.API.Models;
using GreenFreggies.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private TransactionServices _transactionServices;
        public TransactionController(TransactionServices transactionServices)
        {
            _transactionServices=transactionServices;
        }
        [HttpPost("SaveTransaction")]
        public IActionResult SaveTransaction(Transaction transaction)
        {
            return Ok(_transactionServices.SaveTransaction(transaction));
        }

        [HttpPost("DeleteTransaction")]
        public IActionResult DeleteTransaction(int CartId)
        {
            return Ok(_transactionServices.DeleteTransaction(CartId));
        }

        [HttpPost("UpdateTransaction")]
        public IActionResult UpdateTransaction(Transaction transaction)
        {
            return Ok(_transactionServices.UpdateTransaction(transaction));
        }

        [HttpGet("GetTransaction")]
        public IActionResult GetTransaction(int TransactionId)
        {
            return Ok(_transactionServices.GetTransaction(TransactionId));
        }

        [HttpGet("GetAllTransaction")]
        public List<Transaction> GetAllTransaction()
        {
            return _transactionServices.GetAllTransaction();
        }
    }
}
