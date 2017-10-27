using WtsXamarin.Core.Helpers;
using WtsXamarin.Services;
using WtsXamarin.Models;
using WtsXamarin.Core.ViewModels;

namespace WtsXamarin.ViewModels
{
    public class SettingsViewModel : SettingsViewModelBase
    {
        public SettingsViewModel()
        {
        }

        public override string AppName { get; } = $"{SettingsService.Instance.AppName} - {SettingsService.Instance.AppVersion}";

        public override string AboutDescription { get; } = "Settings page placeholder text. Your app description goes here.";

        public override string PrivacyTermsLink { get; } = @"https://YourPrivacyUrlGoesHere/";

        public bool SampleBoolSetting
        {
            get => SettingsService.Instance.SampleBoolSetting;
            set
            {
                SettingsService.Instance.SampleBoolSetting = value;
                OnPropertyChanged(nameof(SampleBoolSetting));
            }
        }

        public SampleProgramOptions SampleEnumSetting
        {
            get => SettingsService.Instance.SampleEnumSetting;
            set
            {
                SettingsService.Instance.SampleEnumSetting = value;
                OnPropertyChanged(nameof(SampleEnumSetting));
            }
        }
    }
}
