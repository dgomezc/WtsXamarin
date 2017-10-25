using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsXamarin.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage : Xamarin.Forms.MasterDetailPage
    {
        public MasterDetailPage()
        {
            InitializeComponent();

            MasterPage.PrimaryListView.ItemSelected += ListView_ItemSelected;
            MasterPage.SecondaryListView.ItemSelected += ListView_ItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            DisableMenuItem(sender as ListView);
        }

        private void DisableMenuItem(ListView listView)
        {
            if(listView == MasterPage.PrimaryListView)
                MasterPage.SecondaryListView.SelectedItem = null;

            else if(listView == MasterPage.SecondaryListView)
                MasterPage.PrimaryListView.SelectedItem = null;
        }
    }
}