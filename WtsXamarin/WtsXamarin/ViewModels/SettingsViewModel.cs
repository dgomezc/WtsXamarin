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

            AppName = service.AppName;
            AppVersion = $"Version - {service.AppVersion}";
        }

        public string AppName { get; private set; }

        public string AppVersion { get; private set; }
    }
}
