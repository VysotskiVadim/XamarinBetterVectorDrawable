using System;
using Android.App;
using Com.Bettervectordrawable;
using Android.Runtime;

namespace XamarinBetterVectorDrawableApp
{
	[Application]
	public class DroidApplication : Application
	{
		public DroidApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			VectorDrawableCompat.EnableResourceInterceptionFor (Resources, Resource.Drawable.ic_pets_black);
			base.OnCreate();
		}
	}
}

