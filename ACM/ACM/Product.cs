using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Product : ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            } 
        }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: BBZ";
    }
}
