﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Shoping_List
{
   
        public class ViewHolder : Java.Lang.Object
        {
            public TextView txtName { get; set; }
        }
        public class ListViewAdapter : BaseAdapter
        {
            private Activity activity;
            private List<ShopinList> listshop;
            public ListViewAdapter(Activity activity, List<ShopinList> listshop)
            {
                this.activity = activity;
                this.listshop = listshop;
            }
            public override int Count
            {
                get { return listshop.Count; }
            }
            public override Java.Lang.Object GetItem(int position)
            {
                return null;
            }
            public override long GetItemId(int position)
            {
                return listshop[position].Id;
            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.Listview, parent, false);
                var txtName = view.FindViewById<TextView>(Resource.Id.txtView_Name);
                txtName.Text = listshop[position].Name;
                return view;
            }
        }
    
}