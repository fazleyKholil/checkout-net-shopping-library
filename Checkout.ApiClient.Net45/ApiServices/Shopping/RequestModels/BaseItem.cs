using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.RequestModels
{
    class BaseItem
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        private DateTime datePurchased;
        public DateTime DatePurchased
        {
            get { return datePurchased; }
            set { datePurchased = new DateTime(); }
        }
    }
}
