using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace AppAndroid
{

    [Activity(Label = "AppAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            TextView textView = FindViewById<TextView>(Resource.Id.myName);
            textView.Text += "and my name is Vasya!";
            Button btnGo = FindViewById<Button>(Resource.Id.btnGo);
            btnGo.Click += BtnGo_Click;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Second_page_Activity));
        }
    }
}

