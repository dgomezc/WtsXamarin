using System.Collections.ObjectModel;
using WtsXamarin.Helpers;
using WtsXamarin.Views;
using WtsXamarin.Views.Navigation;

namespace WtsXamarin.ViewModels.Navigation
{
    public class MasterDetailPageMasterViewModel : Observable
    {
        public ObservableCollection<MasterDetailPageMenuItem> MenuItems { get; set; }

        public MasterDetailPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MasterDetailPageMenuItem>(new[]
            {
                new MasterDetailPageMenuItem { Id = 0, Title = "Blank", TargetType = typeof(BlankPage) },
                new MasterDetailPageMenuItem { Id = 0, Title = "WebView", TargetType = typeof(WebViewPage) },
                new MasterDetailPageMenuItem { Id = 0, Title = "ListView", TargetType = typeof(ListViewPage) },
            });
        }
    }
}
