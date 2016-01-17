using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {

        public HttpResponse<ShoppingList> GetAll()
        {
            var getShoppingListUri = ApiUrls.ShoppingItems;
            return new ApiHttpClient().GetRequest<ShoppingList>(getShoppingListUri, AppSettings.SecretKey);
        }

        static void Main(string[] args)
        {
        }
    }
}
