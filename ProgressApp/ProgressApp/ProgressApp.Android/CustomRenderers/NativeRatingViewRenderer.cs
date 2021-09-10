using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProgressApp;
using ProgressApp.Droid.CustomRenderers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(NativeRatingView), typeof(NativeRatingViewRenderer))]
namespace ProgressApp.Droid.CustomRenderers
{
	class NativeRatingViewRenderer : ViewRenderer<NativeRatingView, CircleNativeView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<NativeRatingView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				var circleNativeView = new CircleNativeView(Android.App.Application.Context);
				circleNativeView.SetValue(Element.Value);
				circleNativeView.SetColor(Element.Color.ToAndroid());
				SetNativeControl(circleNativeView);
			}
		}
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if(e.PropertyName == NativeRatingView.ValueProperty.PropertyName)
			{
				Control.SetValue(Element.Value);
			}
			if (e.PropertyName == NativeRatingView.ColorProperty.PropertyName)
			{
				Control.SetColor(Element.Color.ToAndroid());
			}
			Control.RefreshView();
		}
		public NativeRatingViewRenderer(Context context) : base(context)
		{
		}
	}
}