using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIServices.AccountComponent;
using WebAPIServices.Dto;

namespace WebAPIServices.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountAPIController : ControllerBase
    {
        private AccountService _service;
        private IMapper _mapper;
        public AccountAPIController(AccountService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost()]
        public IActionResult RegisterUsers([FromBody] CustomerDto customerDto)
        {
            var response = _service.RegisterUser(customerDto.CustomerId, customerDto.InitialCredit);

            if (response.IsSuccess)
            {
                return Ok(response);
            }
            else
            {
                return StatusCode(500, response);
            }

        }
        [HttpGet]
        public IActionResult GetAccount()
        {
            var allAcct = _service.GetAllAccount();
            return Ok(allAcct);
        }
    }
}
