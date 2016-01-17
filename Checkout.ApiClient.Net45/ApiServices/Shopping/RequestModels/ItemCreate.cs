using Checkout.ApiServices.Shopping.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.RequestModels
{
   public class ItemCreate 
    {
        public Item Item { get; set; }
        public string Type{get;set;}
    }
}
