using System.Collections.ObjectModel;
using WtsXamarin.Helpers;
using WtsXamarin.Services;
using WtsXamarin.Views;
using WtsXamarin.Views.Navigation;

namespace WtsXamarin.ViewModels.Navigation
{
    public class MasterDetailPageMasterViewModel : Observable
    {
        public ObservableCollection<MasterDetailPageMenuItem> MenuItems { get; set; }

        public MasterDetailPageMasterViewModel()
        {
            var navigationItems = NavigationService.NavigationItems;
            MenuItems = new ObservableCollection<MasterDetailPageMenuItem>(navigationItems);
        }
    }
}
