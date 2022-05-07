using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIServices.CustomerComponent;
using WebAPIServices.Dto;

namespace WebAPIServices.AccountComponent
{
    public class AccountService : AccountRepository
    {
        private ResponseDto _reponse;
        private CustomerService _customerService;
        //private TransactionService _transactionService;
        public AccountService(IMapper mapper, CustomerService customerService) : base(mapper)
        {
            _reponse = new ResponseDto();
            _customerService = customerService;
           // _transactionService = transactionService;
        }

        public ResponseDto RegisterUser(int customerId, decimal initialCredit)
        {
            var foundCustomerDto = _customerService.FindCustomerById(customerId);

            if (foundCustomerDto != null && initialCredit == 0)
            {
                foundCustomerDto.InitialCredit = initialCredit;
               // var responseDto = CheckUser(customerId);
           
                    var accountDto = new AccountDto
                    {
                        Balance = 0,
                        Customer = foundCustomerDto,
                    };
                    var acDto = this.CreateAccount(accountDto);
                    _reponse.IsSuccess = true;
                    _reponse.DisplayMessages = "Customer Account created successfully";
                    _reponse.Result = acDto;
            }
            //else if (foundCustomerDto != null && initialCredit > 0)
            //{
            //    foundCustomerDto.InitialCredit = initialCredit;
            //    //var responseDto = CheckUser(customerId);
             
            //        var accountDto = new AccountDto
            //        {

            //            Customer = foundCustomerDto,
            //        };

            //        var acDto = this.CreateAccount(accountDto);
            //        var transDto = new TransactionsDto
            //        {
            //            Account = acDto,
            //            Amount = acDto.Customer.InitialCredit,
            //            TransactionDate = DateTime.Now,
            //            TransType = TransactionType.Credit

            //        };
            //        var response = _transactionService.DoTransaction(transDto);

            //        _reponse.IsSuccess = response.IsSuccess;
            //        _reponse.DisplayMessages = response.DisplayMessages;
            //        _reponse.Result = response.Result;
            //    }
            //}
            else
            {
                _reponse.IsSuccess = false;
                _reponse.DisplayMessages = "Invalid customer Id";

            }

            return _reponse;
        }

        //public ResponseDto FindAccountByCustomerID(int customerId)
        //{
        //    var foundCustomer = AccountDB.Find(a => a.Customer.CustomerId == customerId);
        //    if (foundCustomer != null)
        //    {
        //        _reponse.IsSuccess = true;
        //        _reponse.DisplayMessages = "Account found with customer id";
        //        _reponse.Result = foundCustomer;
        //    }
        //    else
        //    {
        //        _reponse.IsSuccess = false;
        //        _reponse.DisplayMessages = "Account not found";

        //    }

        //    return _reponse;
        //}
    }
}
