using CustomersApi.Model;
using CustomersApi.Repository;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CustomersApi.Controllers
{
    public class CustomersController : ApiController
    {
     
        private readonly CustomerRepository _repository = new CustomerRepository();

        //get all customers
         [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _repository.FindAll();
            
        }

        //get customer by Id
        [HttpGet]
        public IEnumerable<Customer>  FindCustomer(int id)
        {
            return _repository.GetById(id);
            
        }
    }
}
