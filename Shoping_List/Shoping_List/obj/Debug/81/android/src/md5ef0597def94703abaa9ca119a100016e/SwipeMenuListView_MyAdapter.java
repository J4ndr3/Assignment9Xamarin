package md5ef0597def94703abaa9ca119a100016e;


public class SwipeMenuListView_MyAdapter
	extends md5ef0597def94703abaa9ca119a100016e.SwipeMenuAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Wahid.SwipemenuListview.SwipeMenuListView+MyAdapter, Shoping_List", SwipeMenuListView_MyAdapter.class, __md_methods);
	}


	public SwipeMenuListView_MyAdapter ()
	{
		super ();
		if (getClass () == SwipeMenuListView_MyAdapter.class)
			mono.android.TypeManager.Activate ("Wahid.SwipemenuListview.SwipeMenuListView+MyAdapter, Shoping_List", "", this, new java.lang.Object[] {  });
	}

	public SwipeMenuListView_MyAdapter (android.content.Context p0, android.widget.ListAdapter p1)
	{
		super ();
		if (getClass () == SwipeMenuListView_MyAdapter.class)
			mono.android.TypeManager.Activate ("Wahid.SwipemenuListview.SwipeMenuListView+MyAdapter, Shoping_List", "Android.Content.Context, Mono.Android:Android.Widget.IListAdapter, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
