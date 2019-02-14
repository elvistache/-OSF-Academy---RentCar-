using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC
{
    public class Customer : Reservation
    {
        public Customer()
        {
             
        }

        public Customer(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }

        public static int InstanceCount { get; set; }

        public int CustomerID { get; private set; }
        
        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = null;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    fullName = LastName;
                }
                else if (!string.IsNullOrWhiteSpace(LastName))
                    fullName = FirstName;
                else
                    fullName = FirstName + " " + LastName;
                return fullName;
            }
        }

        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public Address HomeAddress { get; set; }
        public Address OfficeAddress { get; set; }


        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FullName))
               isValid = false;
             
            return isValid;
        }

    }
}
