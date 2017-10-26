using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using WtsXamarin.Models;
using Xamarin.Forms;

namespace WtsXamarin.Services
{
    public class SettingsService
    {
        private ISettings _appSettings = CrossSettings.Current;
        private IPlatformInfoService _platformService;
        private static SettingsService _instance;

        public static SettingsService Instance => _instance ?? (_instance = new SettingsService());
        
        private SettingsService()
        {
            _platformService = DependencyService.Get<IPlatformInfoService>();
        }

        public string AppName => _platformService.AppName;

        public string AppVersion => _platformService.AppVersion;

        public bool SampleBoolSetting
        {
            get => _appSettings.GetValueOrDefault(nameof(SampleBoolSetting), false);
            set => _appSettings.AddOrUpdateValue(nameof(SampleBoolSetting), value);
        }

        public SampleProgramOptions SampleEnumSetting
        {
            get => (SampleProgramOptions)_appSettings.GetValueOrDefault(nameof(SampleEnumSetting), 0);
            set => _appSettings.AddOrUpdateValue(nameof(SampleEnumSetting), (int)value);
        }
    }
}
