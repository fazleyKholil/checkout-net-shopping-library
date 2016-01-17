using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping.ResponseModels
{
    class ShoppingList
    {
        public Dictionary<string, List<Item>> Items { get; set; }
    }
}
