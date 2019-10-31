using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Wahid.SwipemenuListview;
using Android.Graphics.Drawables;
using Android.Graphics;
using System.Collections.Generic;
using Android.Views;

namespace Shoping_List
{
    [Activity(Label = "U17055386 Shopping list App", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, ISwipeMenuCreator, IOnMenuItemClickListener
    {

        SwipeMenuListView lstViewData;
        List<ShopinList> listSource = new List<ShopinList>();

        Database db;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button addToList = FindViewById<Button>(Resource.Id.btnAdd);
            //addToList.Click
            SwipeMenuListView listView = FindViewById<SwipeMenuListView>(Resource.Id.listView);
            ArrayAdapter<ShopinList> ListAdapter = new ArrayAdapter<ShopinList>(this, Android.Resource.Layout.SimpleListItem1, listSource);
            listView.Adapter = ListAdapter;
            listView.MenuCreator = this;
            listView.MenuItemClickListener = this;
            db = new Database();
            db.createDatabase();
            lstViewData = FindViewById<SwipeMenuListView>(Resource.Id.listView);
            //var edtName = FindViewById<EditText>(Resource.Id.edtName);
            var btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            var btnRemove = FindViewById<Button>(Resource.Id.btnRemove);
            //Load Data  
            LoadData();
            //Event  
            Button button = FindViewById<Button>(Resource.Id.btnAdd);
            button.Click += delegate
            {
                LayoutInflater layoutInflater = LayoutInflater.From(this);
                View view = layoutInflater.Inflate(Resource.Layout.user_input_dialog_box, null);
                Android.Support.V7.App.AlertDialog.Builder alertbuilder = new Android.Support.V7.App.AlertDialog.Builder(this);
                alertbuilder.SetView(view);
                var userdata = view.FindViewById<EditText>(Resource.Id.editText);
                alertbuilder.SetCancelable(false)
                .SetPositiveButton("Submit", delegate
                {
                    Toast.MakeText(this, "Submit Input: " + userdata.Text, ToastLength.Short).Show();
                    ShopinList person = new ShopinList()
                    {
                        Name = userdata.Text
                    };
                    db.insertIntoTable(person);
                    LoadData();
                })
                .SetNegativeButton("Cancel", delegate
                {
                    alertbuilder.Dispose();
                });
                Android.Support.V7.App.AlertDialog dialog = alertbuilder.Create();
                dialog.Show();
            };
            //btnAdd.Click += delegate
            //{
            //    ShopinList person = new ShopinList()
            //    {
            //        Name = edtName.Text
            //    };
            //    db.insertIntoTable(person);
            //    LoadData();
            //};

            
            lstViewData.ItemClick += (s, e) =>
            {
                //Set Backround for selected item  
                for (int i = 0; i < lstViewData.Count; i++)
                {
                    if (e.Position == i)
                    {
                        lstViewData.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Aqua);
                        btnRemove.Click += delegate
                        {
                            ShopinList person = new ShopinList()
                            {
                                Id = (int)(e.Id)

                            };
                            db.removeTable(person);
                            LoadData();
                        };
                    }
                    else
                        lstViewData.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
                //Binding Data  
                //var txtName = e.View.FindViewById<TextView>(Resource.Id.txtView_Name);
                //edtName.Tag = e.Id;
            };

        }
        public void Create(SwipeMenu menu)
        {

            SwipeMenuItem callItem = new SwipeMenuItem(this)
            {
                Width = (200),
                Background = new ColorDrawable(Color.Red),
                IconRes = Resource.Mipmap.icD
 
            };
            menu.AddMenuItem(callItem);
        }
        public bool OnMenuItemClick(int position, SwipeMenu menu, int index)
        {
            //var contact = ((listview.Adapter as SwipeMenuAdapter).WrappedAdapter as ContactUsSwipeAdapter).Items[position];
            string contact = listSource[position].ToString();
            switch (index)
            {
                case 0:
                    int type = menu.GetViewType();
                    if (menu.GetViewType() == 0)
                    {
                        ShopinList person = new ShopinList()
                        {
                            Id = (int)(listSource[position].Id)

                        };
                        db.removeTable(person);
                        LoadData();
                    }
                    else
                    {
                    }
                    break;
                case 1: // copy
                    break;
            }
            return false;
        }

        private void LoadData()
        {
            listSource = db.selectTable();
            var adapter = new ListViewAdapter(this, listSource);
            lstViewData.Adapter = adapter;
        }
    }
}