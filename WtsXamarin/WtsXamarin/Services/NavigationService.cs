using System;
using System.Collections.Generic;
using System.Text;
using WtsXamarin.Views;
using WtsXamarin.Views.Navigation;

namespace WtsXamarin.Services
{
    public static class NavigationService
    {
        public static IEnumerable<MasterDetailPageMenuItem> NavigationItems = new[]
        {
            new MasterDetailPageMenuItem { Id = 0, Title = "Blank", TargetType = typeof(BlankPage)},
            new MasterDetailPageMenuItem { Id = 1, Title = "WebView", TargetType = typeof(WebViewPage)},
            new MasterDetailPageMenuItem { Id = 2, Title = "ListView", TargetType = typeof(ListViewPage) },
        };    
    }
}
