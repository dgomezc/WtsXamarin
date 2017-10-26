using Foundation;
using WtsXamarin.iOS.Services;
using WtsXamarin.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformService))]
namespace WtsXamarin.iOS.Services
{
    public class PlatformInfoService : IPlatformService
    {
        public string AppName => NSBundle.MainBundle.InfoDictionary["CFBundleName"].ToString();

        public string AppVersion => NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
    }
}