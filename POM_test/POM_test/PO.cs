using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;


namespace POM_test
{

    public class POMPage
    {
        private IPage _page;
        public POMPage(IPage page)
        {
            _page = page;
        }

        public async Task CheckRadioButton()
        {
            //wait _page.GotoAsync(url: "https://www.selenium.dev/selenium/web/web-form.html");
            await _checkedRadioButton.CheckAsync();
        }

        public async Task DefaultRadioButton()
        {
            //await _page.GotoAsync(url: "https://www.selenium.dev/selenium/web/web-form.html");
            await _defaultRadioButton.CheckAsync();
        }

        public async Task CklickSubmitButton() => await _submitButton.ClickAsync();

        public async Task SelectDropdownList(DropdownList option)
        {
            string dropdownToSelect;

            switch (option) 
            {
                case DropdownList.One: dropdownToSelect = "One";
                    break;
                case DropdownList.Two: dropdownToSelect = "Two";
                    break;
                case DropdownList.Three: dropdownToSelect = "Three";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(option), option, null);
            }

        await _page.SelectOptionAsync("body > main > div > form > div > div:nth-child(2) > label:nth-child(1) > select", new SelectOptionValue { Label = dropdownToSelect });
        // public async Task <bool> IsIcnShoppingCardVisible() => await _icnShoppingCard.IsVisibleAsync();
        }
        private ILocator _checkedRadioButton => _page.Locator(selector: "//input[@type=\"radio\"][@id=\"my-radio-1\"]");
        private ILocator _defaultRadioButton => _page.Locator(selector: "//input[@type=\"radio\"][@id=\"my-radio-2\"]");
        private ILocator _submitButton => _page.Locator(selector: "//button[text()=\"Submit\"]");
    } 
    


}