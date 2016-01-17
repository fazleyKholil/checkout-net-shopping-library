using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.Shopping.RequestModels;
using Checkout.ApiServices.Shopping.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.Helpers;

namespace Checkout.ApiServices.Shopping
{
    public class ShoppingClient
    {
        //public void addItemToShoppingList()
        //{

        //    var shoppingListCreateRequest = new ItemDto()
        //    {
        //        Id=1,
        //        name="pepsi",
        //        price=15.00,
        //        quantity=2,
        //        Type="drinks"// category of items to be added
        //    };

        //    try
        //    {
        //        // Create APIClient instance with your secret key
        //        APIClient ckoAPIClient = new APIClient("sk_test_32b9cb39-1cd6-4f86-b750-7069a133667d", Checkout.Helpers.Environment.Sandbox);

        //        // Submit your request and receive an apiResponse
        //        HttpResponse<Item> apiResponse = ckoAPIClient.ShoppingService.CreateItem(shoppingListCreateRequest);

        //        if (!apiResponse.HasError)
        //        {
        //            // Access the response object retrieved from the api
        //            var item = apiResponse.Model;
        //        }
        //        else
        //        {
        //            // Api has returned an error object. You can access the details in the error property of the apiResponse.
        //            // apiResponse.error
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        //... Handle exception
        //    }
        //}

        public void getShoppingList()
        {
            try
            {
                // Create APIClient instance with your secret key
                APIClient ckoAPIClient = new APIClient("sk_test_32b9cb39-1cd6-4f86-b750-7069a133667d", Checkout.Helpers.Environment.Sandbox);

                // Submit your request and receive an apiResponse
                HttpResponse<ShoppingList> apiResponse = ckoAPIClient.ShoppingService.GetAll();

                if (!apiResponse.HasError)
                {
                    // Access the response object retrieved from the api
                    var item = apiResponse.Model;
                }
                else
                {
                    // Api has returned an error object. You can access the details in the error property of the apiResponse.
                    // apiResponse.error
                }
            }
            catch (Exception e)
            {
                //... Handle exception
            }
        }
    }
}
