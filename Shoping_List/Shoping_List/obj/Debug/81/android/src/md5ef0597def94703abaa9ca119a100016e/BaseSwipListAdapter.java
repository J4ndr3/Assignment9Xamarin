package md5ef0597def94703abaa9ca119a100016e;


public abstract class BaseSwipListAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Wahid.SwipemenuListview.BaseSwipListAdapter, Shoping_List", BaseSwipListAdapter.class, __md_methods);
	}


	public BaseSwipListAdapter ()
	{
		super ();
		if (getClass () == BaseSwipListAdapter.class)
			mono.android.TypeManager.Activate ("Wahid.SwipemenuListview.BaseSwipListAdapter, Shoping_List", "", this, new java.lang.Object[] {  });
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
