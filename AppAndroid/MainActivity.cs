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
        private List<string> myNames;
        private ListView myListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            TextView textView = FindViewById<TextView>(Resource.Id.myName);
            textView.Text += "and my name is Vasya!";


            myNames = new List<string>();
            myNames.Add("Vasya");
            myNames.Add("Petya");
            myNames.Add("Katya");

            myListView = FindViewById<ListView>(Resource.Id.namesList);

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myNames);

            MyListViewAdapter adapter = new MyListViewAdapter(this, myNames);
            //string indexerText = adapter.myItems[1];
            
            myListView.Adapter = adapter;

        }
    }
}

