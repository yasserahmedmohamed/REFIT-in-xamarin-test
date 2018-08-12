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
using Java.Lang;

namespace AndroidProjectFirst.Classes
{
    class ListviewAdapter : BaseAdapter
    {
        Activity context;
        List<UsersTest> users;

      

        public ListviewAdapter(Activity context, List<UsersTest> users) : base()
        {
            this.context = context;
            this.users = users;

        }

        public override int Count {
           get{ return users.Count;
                 }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.seriesListviewitem, null);
            view.FindViewById<TextView>(Resource.Id.text_description).Text = users[position].Header;
            view.FindViewById<TextView>(Resource.Id.text_numb).Text = users[position].subheader;
            view.FindViewById<ImageView>(Resource.Id.ser_thum).SetImageResource(users[position].image);



            return view;
        }
    }
}