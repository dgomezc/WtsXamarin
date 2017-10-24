﻿using Android.App;
using Android.Content.PM;
using WtsXamarin.Droid.Services;
using WtsXamarin.Services;

[assembly: Xamarin.Forms.Dependency(typeof(SettingsService))]
namespace WtsXamarin.Droid.Services
{
    public class SettingsService : ISettingsService
    {
        private static PackageInfo info = Application.Context.PackageManager.GetPackageInfo(
            Application.Context.PackageName,
            PackageInfoFlags.MetaData);

        public string AppName => info.ApplicationInfo.LoadLabel(Application.Context.PackageManager).ToString();

        public string AppVersion => info.VersionName;        
    }
}