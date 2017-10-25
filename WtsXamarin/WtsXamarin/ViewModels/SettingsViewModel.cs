using WtsXamarin.Helpers;
using WtsXamarin.Services;
using Xamarin.Forms;

namespace WtsXamarin.ViewModels
{
    public class SettingsViewModel : Observable
    {
        public SettingsViewModel()
        {
            var service = DependencyService.Get<ISettingsService>();
            AppName = $"{service.AppName} - {service.AppVersion}";
        }

        public string AppName { get; }

        public string AboutDescription => "Settings page placeholder text.  Your app description goes here.";

        public string PrivacyTermsLink => @"https://YourPrivacyUrlGoesHere/";

    }
}
