using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIServices.DomainModel;
using WebAPIServices.Dto;

namespace WebAPIServices.CustomerComponent
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly IMapper _mapper;
        public static List<Customer> CustomerDB = new List<Customer>
        {
            new Customer{CustomerId = 1,Name = "Jude",Surname = "Kc",InitialCredit = 0},
            new Customer{CustomerId = 2,Name = "Olivia",Surname = "Tim",InitialCredit = 0},
            new Customer{CustomerId = 3,Name = "Michael",Surname = "Kelechi",InitialCredit = 0}
        };

        public CustomerRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public CustomerDto AddCustomer(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        public CustomerDto FindCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetAllCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
