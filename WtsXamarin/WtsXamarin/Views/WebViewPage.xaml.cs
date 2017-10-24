using WtsXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
            ViewModel.Initialize(webView);
            BindingContext = ViewModel;
        }

        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();
    }
}