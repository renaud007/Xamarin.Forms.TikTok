﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using PanCardView.Droid;
using Xamarin.Forms.Platform.Android;

namespace Xamarin.Forms.TikTok.Droid
{
    [Activity(Label = "Xamarin.Forms.TikTok",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme", 
        MainLauncher = false,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Forms.Init(this, savedInstanceState);

            InitializePackages();

            LoadApplication(new App());
            Window?.SetStatusBarColor(Color.Black.ToAndroid());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void InitializePackages()
        {
            CardsViewRenderer.Preserve(); 
        }
    }
}