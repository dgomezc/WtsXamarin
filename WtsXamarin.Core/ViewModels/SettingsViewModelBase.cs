using WtsXamarin.Core.Helpers;

namespace WtsXamarin.Core.ViewModels
{
    public abstract class SettingsViewModelBase : Observable
    {
        public abstract string AppName { get; }

        public abstract string AboutDescription { get; }

        public abstract string PrivacyTermsLink { get; }
    }
}
