using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace POMProject1.Pages
{
    public class ShoppingCart 
    {

        private IPage _page;

        private readonly ILocator _backPackItem;

        public ShoppingCart(IPage page) 
        { 
            _page = page;

            //playwright.Selectors.SetTestIdAttribute("data-test");
            //_backPackItem = _page.GetByTestId("inventory-item-name", new PageGetByTextOptions { Has }"Sauce Labs Backpack";

            _backPackItem = _page.Locator(selector: "[data-test='inventory-item-name']", new PageLocatorOptions { HasTextString = "Sauce Labs Backpack" });



        }


    }
}
