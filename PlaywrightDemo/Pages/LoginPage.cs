using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightLearning.Pages
{
    public class LoginPage
    {
        private IPage _page;
        private readonly ILocator _linkLogin;
        private readonly ILocator _txtUserName;
        private readonly ILocator _txtPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _btnLogOff;
        public LoginPage(IPage page) 
        {
            _page = page;

            _linkLogin =_page.Locator(selector: "text=Login");
            _txtUserName = _page.Locator(selector: "#UserName");
            _txtPassword = _page.Locator(selector: "#Password");
            _btnLogin = _page.Locator(selector: "text=Log in");
            _btnLogOff = _page.Locator(selector: "text='Log off'");
        }

        public async Task ClickLogin() => await _linkLogin.ClickAsync();

        public async Task Login(string userName, string password) 
        {
            await _txtUserName.FillAsync(userName);
            await _txtPassword.FillAsync(password);
            await _btnLogin.ClickAsync();
        }

        public async Task <bool> IsBtnLogOffExist() => await _btnLogOff.IsVisibleAsync();

    }
}