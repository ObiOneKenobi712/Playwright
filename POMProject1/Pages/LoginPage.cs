using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;


namespace POMProject1.Pages
{
    public class LoginPage
    {

        private readonly ILocator _txtUserName;
        private readonly ILocator _txtPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _icnShoppingCard;
        private readonly ILocator _icnOptions;
        private readonly ILocator _btnLogout;

        private IPage _page;
        public LoginPage(IPage page)
        {
            _page = page;

            _txtUserName = _page.Locator(selector: "#user-name");
            _txtPassword = _page.Locator(selector: "#password");
            _btnLogin = _page.Locator(selector: "#login-button");
            _icnShoppingCard = _page.Locator(selector: ".shopping_cart_link");
            _icnOptions = _page.Locator(selector: "#react-burger-menu-btn");
            _btnLogout = _page.Locator(selector: "#logout_sidebar_link");
        }

        public async Task Login(string userName, string password) 
        {
            await _txtUserName.FillAsync(userName);
            await _txtPassword.FillAsync(password);
            await _btnLogin.ClickAsync();

        }
        public async Task <bool> IsIcnShoppingCardVisible() => await _icnShoppingCard.IsVisibleAsync();
        public async Task LogOut()
        {
            await _icnOptions.ClickAsync();
            await _btnLogout.ClickAsync();
        }
        public async Task <bool> IsIcnLoginVisible() => await _btnLogin.IsVisibleAsync();
    }

}