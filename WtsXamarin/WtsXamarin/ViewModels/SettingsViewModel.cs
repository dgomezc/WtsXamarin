﻿using WtsXamarin.Helpers;
using WtsXamarin.Services;
using WtsXamarin.Models;

namespace WtsXamarin.ViewModels
{
    public class SettingsViewModel : Observable
    {
        public SettingsViewModel()
        {
        }

        public string AppName => $"{SettingsService.Instance.AppName} - {SettingsService.Instance.AppVersion}";

        public string AboutDescription => "Settings page placeholder text. Your app description goes here.";

        public string PrivacyTermsLink => @"https://YourPrivacyUrlGoesHere/";

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
