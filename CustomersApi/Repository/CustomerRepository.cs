using CustomersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersApi.Repository
{
    public class CustomerRepository 
    { 
        //Returning all customers from the database
        public IEnumerable<Customer> FindAll()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Jonathan Ricks", Address = "123 Alexandra Rd", Telephone = "384746353" });
            customers.Add(new Customer() { Name = "Katrina Bells", Address = "2234 George Street", Telephone = "334345454" });
            customers.Add(new Customer() { Name = "James Bond", Address = "Franc Ave", Telephone = "457598678" });
            return customers;
        }


        //Filtering through customers

        public IEnumerable <Customer> GetById(int customerId)
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() {CustomerId = 1, Name = "Jonathan Ricks", Address = "123 Alexandra Rd", Telephone = "384746353" });
            customers.Add(new Customer() {CustomerId = 2, Name = "Katrina Bells", Address = "2234 George Street", Telephone = "334345454" });
            customers.Add(new Customer() {CustomerId = 3, Name = "James Bond", Address = "Franc Ave", Telephone = "457598678" });

            var c = from customer in customers
                    where customer.CustomerId == customerId
                    select customer;

          
            return c;
        }
    }

}