using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Customer : ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName = ", " + fullName;
                    }
                    fullName = FirstName + fullName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: BBZ";
    }
}
