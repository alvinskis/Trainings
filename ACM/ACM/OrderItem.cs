using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public bool Validate()
        {
            bool isValid = true;
            if (Quantity <= 0 || ProductId <= 0 || PurchasePrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
    }
}
