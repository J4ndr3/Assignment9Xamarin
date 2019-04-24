package md5ef0597def94703abaa9ca119a100016e;


public class GestureListerner
	extends android.view.GestureDetector.SimpleOnGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDown:(Landroid/view/MotionEvent;)Z:GetOnDown_Landroid_view_MotionEvent_Handler\n" +
			"n_onFling:(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z:GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler\n" +
			"";
		mono.android.Runtime.register ("Wahid.SwipemenuListview.GestureListerner, Shoping_List", GestureListerner.class, __md_methods);
	}


	public GestureListerner ()
	{
		super ();
		if (getClass () == GestureListerner.class)
			mono.android.TypeManager.Activate ("Wahid.SwipemenuListview.GestureListerner, Shoping_List", "", this, new java.lang.Object[] {  });
	}

	public GestureListerner (md5ef0597def94703abaa9ca119a100016e.SwipeMenuLayout p0)
	{
		super ();
		if (getClass () == GestureListerner.class)
			mono.android.TypeManager.Activate ("Wahid.SwipemenuListview.GestureListerner, Shoping_List", "Wahid.SwipemenuListview.SwipeMenuLayout, Shoping_List", this, new java.lang.Object[] { p0 });
	}


	public boolean onDown (android.view.MotionEvent p0)
	{
		return n_onDown (p0);
	}

	private native boolean n_onDown (android.view.MotionEvent p0);


	public boolean onFling (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3)
	{
		return n_onFling (p0, p1, p2, p3);
	}

	private native boolean n_onFling (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3);

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
