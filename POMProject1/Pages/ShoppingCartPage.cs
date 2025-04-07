using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;


namespace POMProject1.Pages
{
    public class ShoppingCartPage
    {

        private IPage _page;


        public ShoppingCartPage(IPage page)
        {
            _page = page;

            //playwright.Selectors.SetTestIdAttribute("data-test");
            //_backPackItem = _page.GetByTestId("inventory-item-name", new PageGetByTextOptions { Has }"Sauce Labs Backpack";
        }

        public async Task IfItemAddedToShoppingCart()
        {
            await backPackItem.ClickAsync();
            await icnAddToCart.ClickAsync();
            await icnShoppingCart.ClickAsync();
            bool backPackItemVisibleInTheShoppingCart = await backPackItemInShoppingCart.IsVisibleAsync();
            Assert.True(backPackItemVisibleInTheShoppingCart, "Backpack is added to the Shopping Cart");

        }


        private ILocator backPackItem => _page.Locator(selector: "[data-test='inventory-item-name']", new PageLocatorOptions { HasTextString = "Sauce Labs Backpack" });
        private ILocator icnShoppingCart => _page.Locator(selector: "a.shopping_cart_link[data-test='shopping-cart-link']");
        private ILocator backPackItemInShoppingCart => _page.Locator(selector: "div.inventory_item_name[data-test='inventory-item-name']");
        private ILocator icnAddToCart => _page.Locator(selector: "button[data-test='add-to-cart']");
    }
}
