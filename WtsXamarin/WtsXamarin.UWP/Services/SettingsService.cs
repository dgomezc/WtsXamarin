using Windows.ApplicationModel;
using WtsXamarin.Services;
using WtsXamarin.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(SettingsService))]
namespace WtsXamarin.UWP.Services
{
    public class SettingsService : ISettingsService
    {
        public string AppName => Package.Current.DisplayName;

        public string AppVersion => GetAppVersion();
        
        private string GetAppVersion()
        {
            var package = Package.Current;
            var packageId = package.Id;
            var version = packageId.Version;
            return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }
    }
}
