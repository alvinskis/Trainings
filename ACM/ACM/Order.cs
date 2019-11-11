using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Order : ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public string Log() => $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: BBZ";

        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
