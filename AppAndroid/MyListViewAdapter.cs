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
    
    class MyListViewAdapter : BaseAdapter<Pattern>
    {
        public List<Pattern> myItems;
        private Context myContext;

        public MyListViewAdapter(Context context, List<Pattern> items)
        {
            myItems = items;
            myContext = context;
        }

        public override int Count
        {
            get { return myItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        
        public override Pattern this[int position]
        {
            get { return myItems[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null) {
                row = LayoutInflater.From(myContext).Inflate(Resource.Layout.llistview_row, null, false);
            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtViewName);
            txtName.Text = myItems[position].Name;

            ImageView imageView = row.FindViewById<ImageView>(Resource.Id.imageBox);
            imageView.SetImageResource(myItems[position].imageid);


            return row;
        }
    }
}