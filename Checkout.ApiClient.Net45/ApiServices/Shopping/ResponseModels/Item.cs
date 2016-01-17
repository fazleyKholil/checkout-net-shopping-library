using Checkout.ApiServices.Shopping.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.ResponseModels
{ 
    public class Item : BaseItem
    {
        public bool LiveMode { get; set; }
        public string Created { get; set; }
    }
}
