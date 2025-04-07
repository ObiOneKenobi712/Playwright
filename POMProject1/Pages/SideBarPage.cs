using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using static System.Net.Mime.MediaTypeNames;

namespace POMProject1.Pages
{
    public class SideBar
    {
      
        private readonly ILocator _btnLogout;
        private readonly ILocator _btnAllItems;
        private readonly ILocator _btnAbout;
        private readonly ILocator _btnResetAppState;
        private readonly string _targetUrl;

        private IPage _page;
        public SideBar(IPage page)
        {
            _page = page;
        }

        public async Task ChceckBtnAllItems() 
        { 
            await ICNOptions.ClickAsync();
            await btnAllItems.ClickAsync();
            await btnAllItems.ClickAsync();
        }
        public async Task ChceckBtnResetAppState()
        {
            await ICNOptions.ClickAsync();
            await btnResetAppState.IsEnabledAsync();
            await btnResetAppState.ClickAsync();
        }
        public async Task ChceckBtnAbout()
        {
            await ICNOptions.ClickAsync();
            await btnAbout.IsEnabledAsync();
            await btnAbout.ClickAsync();
        }

        public async Task IsCurrentUrlDifferentBtnAbout()
        {
            await _page.WaitForURLAsync(_targetUrl);
        }

        private ILocator ICNOptions => _page.Locator(selector: "#react-burger-menu-btn");
        private ILocator btnLogout => _page.Locator(selector: "#logout_sidebar_link");
        private ILocator btnAllItems => _page.Locator(selector: "#inventory_sidebar_link");
        private ILocator btnAbout => _page.Locator(selector: "#about_sidebar_link");
        private ILocator btnResetAppState => _page.Locator(selector: "#reset_sidebar_link");

    }
}
