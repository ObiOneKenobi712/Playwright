using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace POMProject1.Pages
{
    public class SideBar
    {
        private readonly ILocator _icnOptions;
        private readonly ILocator _btnLogout;
        private readonly ILocator _btnAllItems;
        private readonly ILocator _btnAbout;
        private readonly ILocator _btnResetAppState;
        private readonly string _targetUrl;

        private IPage _page;
        public SideBar(IPage page)
        {
            _page = page;

            _icnOptions = _page.Locator(selector: "#react-burger-menu-btn");
            _btnLogout = _page.Locator(selector: "#logout_sidebar_link");
            _btnAllItems = _page.Locator(selector: "#inventory_sidebar_link");
            _btnAbout = _page.Locator(selector: "#about_sidebar_link");
            _btnResetAppState = _page.Locator(selector: "#reset_sidebar_link");
            _targetUrl = "https://saucelabs.com/";

        }

        public async Task ChceckBtnAllItems() 
        { 
            await _icnOptions.ClickAsync();
            await _btnAllItems.ClickAsync();
            await _btnAllItems.ClickAsync();
        }
        public async Task ChceckBtnResetAppState()
        {
            await _icnOptions.ClickAsync();
            await _btnResetAppState.IsEnabledAsync();
            await _btnResetAppState.ClickAsync();
        }
        public async Task ChceckBtnAbout()
        {
            await _icnOptions.ClickAsync();
            await _btnAbout.IsEnabledAsync();
            await _btnAbout.ClickAsync();
        }

        public async Task IsCurrentUrlDifferentBtnAbout()
        {
            await _page.WaitForURLAsync(_targetUrl);
        }
    }
}
