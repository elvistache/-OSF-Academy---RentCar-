using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerID)
        {
            Customer customer = new Customer(customerID);

            if (customerID == 1)
            {
                customer.Email = "elvis.tache@outlook.com";
                customer.FirstName = "Elvis";
                customer.LastName = "Tache";

            }

            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }


        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
