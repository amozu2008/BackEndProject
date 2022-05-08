﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIServices.AccountComponent;
using WebAPIServices.Dto;

namespace WebAPIServices.TransactionComponent
{
    public class TransactionService
    {
        private ResponseDto _reponse;
        public TransactionService()
        {
            _reponse = new ResponseDto();
        }

        public ResponseDto DoTransaction(AccountDto accountDto)
        {
            //var foundAccountDto = _accountService.FindAccountById(id);
            if(accountDto != null)
            {
                accountDto.Balance += accountDto.Customer.InitialCredit;
                accountDto.Transactions = "Credit";
                _reponse.IsSuccess = true;
                _reponse.DisplayMessages = "Account created and Transaction successful";
                _reponse.Result = accountDto;
            }


            return _reponse;
        }
    }
}