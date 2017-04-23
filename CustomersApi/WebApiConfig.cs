using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CustomersApi
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Route to return customers 
            config.Routes.MapHttpRoute(

                name: "AllCustomers",
                routeTemplate: "customers",
                defaults: new { controller = "Customers", action = "GetAll" }
                );


            //Route to return customerfiltered by Id
            config.Routes.MapHttpRoute(

                name: "FilterCustomers",
                routeTemplate: "customers/{id}",
                defaults: new { controller = "Customers", action = "FindCustomer" }
                );

        }
    }
}