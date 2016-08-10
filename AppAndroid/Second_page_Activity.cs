using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppAndroid
{
    [Activity(Label = "Second_page_Activity")]
    public class Second_page_Activity : Activity
    {
        private List<Pattern> myNames;
        private ListView myListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Second_page);

            myListView = FindViewById<ListView>(Resource.Id.namesList);
            myNames = new List<Pattern>();
            myNames.Add(new Pattern() { Name = "Vasya Makarchuk", imageid = Resource.Drawable.arsenal });
            myNames.Add(new Pattern() { Name = "Maxim Barovskii", imageid = Resource.Drawable.max });
            myNames.Add(new Pattern() { Name = "Super Dlinnoe imya cheloveka" , imageid = Resource.Drawable.hack});

            MyListViewAdapter adapter = new MyListViewAdapter(this, myNames);
            
            myListView.Adapter = adapter;
            myListView.ItemClick += MyListView_ItemClick;


        }

        private void MyListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(myNames[e.Position].Name);
        }
    }
}