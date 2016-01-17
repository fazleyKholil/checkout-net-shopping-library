using Checkout.ApiServices.Customers.ResponseModels;
using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.Shopping.RequestModels;
using Checkout.ApiServices.Shopping.ResponseModels;
using Checkout.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping
{
    public class ShoppingService
    {
        public HttpResponse<ShoppingList> GetAll()
        {
            var getShoppingListUri = ApiUrls.ShoppingItems;
            return new ApiHttpClient().GetRequest<ShoppingList>(getShoppingListUri, AppSettings.SecretKey);
        }

        public HttpResponse<ShoppingListCategorised> GetShoppingListByCategory(string type)
        {
            var getShoppingListByTypeUri = ApiUrls.ShoppingItems;
            getShoppingListByTypeUri = UrlHelper.AddParameterToUrl(getShoppingListByTypeUri, "type", type);
            return new ApiHttpClient().GetRequest<ShoppingListCategorised>(getShoppingListByTypeUri, AppSettings.SecretKey);
        }

        public HttpResponse<Item> GetItemByName(ItemDto itemCreate)
        {
            var getShoppingItemByNameUri = ApiUrls.ShoppingItems;
            getShoppingItemByNameUri = UrlHelper.AddParameterToUrl(getShoppingItemByNameUri, "type", itemCreate.Type);
            getShoppingItemByNameUri = UrlHelper.AddParameterToUrl(getShoppingItemByNameUri, "name", itemCreate.name);
            return new ApiHttpClient().GetRequest<Item>(getShoppingItemByNameUri, AppSettings.SecretKey);
        }

        public HttpResponse<Item> GetItemById(ItemDto itemCreate)
        {
            var getShoppingItemByNameUri = string.Format(ApiUrls.ShoppingItemWithId, itemCreate.Id);
            getShoppingItemByNameUri = UrlHelper.AddParameterToUrl(getShoppingItemByNameUri, "type", itemCreate.Type);
            return new ApiHttpClient().GetRequest<Item>(getShoppingItemByNameUri, AppSettings.SecretKey);
        }

        public HttpResponse<ShoppingListCategorised> CreateItem(ItemCreate requestModel)
        {
            var getShoppingItemByNameUri = ApiUrls.ShoppingItems;
            getShoppingItemByNameUri = UrlHelper.AddParameterToUrl(getShoppingItemByNameUri, "type", requestModel.Type);
            BaseItem[] itemCreate = new BaseItem[1]; 
            itemCreate[0] = requestModel.Item;
            return new ApiHttpClient().PostRequest<ShoppingListCategorised>(getShoppingItemByNameUri, AppSettings.SecretKey, itemCreate);
        }


        public HttpResponse<OkResponse> DeleteItem(ItemDto requestModel)
        {
            var deleteItemUri = string.Format(ApiUrls.ShoppingItemWithId, requestModel.Id);
            deleteItemUri = UrlHelper.AddParameterToUrl(deleteItemUri, "type", requestModel.Type);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteItemUri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> UpdateItem(ItemDto requestModel)
        {
            var updateItemUri = string.Format(ApiUrls.Customer, requestModel.Id);
            updateItemUri = UrlHelper.AddParameterToUrl(updateItemUri, "type", requestModel.Type);
            return new ApiHttpClient().PutRequest<OkResponse>(updateItemUri, AppSettings.SecretKey, requestModel);
        }

    }
}
