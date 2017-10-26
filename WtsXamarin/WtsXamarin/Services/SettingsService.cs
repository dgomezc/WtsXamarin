using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WtsXamarin.Services
{
    public class SettingsService
    {
        private ISettings _appSettings = CrossSettings.Current;

        private IPlatformInfoService _platformService = DependencyService.Get<IPlatformInfoService>();

        private static SettingsService _instance;
        public static SettingsService Instance => _instance ?? (_instance = new SettingsService());
        
        private SettingsService()
        {
        }

        public string AppName => _platformService.AppName;
        public string AppVersion => _platformService.AppVersion;

        public bool SampleBoolSetting
        {
            get => _appSettings.GetValueOrDefault(nameof(SampleBoolSetting), false);
            set => _appSettings.AddOrUpdateValue(nameof(SampleBoolSetting), value);
        }        
    }
}
