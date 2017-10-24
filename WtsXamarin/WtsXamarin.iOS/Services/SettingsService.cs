using Foundation;
using WtsXamarin.iOS.Services;
using WtsXamarin.Services;

[assembly: Xamarin.Forms.Dependency(typeof(SettingsService))]
namespace WtsXamarin.iOS.Services
{
    public class SettingsService : ISettingsService
    {
        public string AppName => NSBundle.MainBundle.InfoDictionary["CFBundleName"].ToString();

        public string AppVersion => NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
    }
}