using ProgressApp;
using ProgressApp.UWP.CustomRenderers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(NativeRatingView), typeof(NativeRatingViewRenderer))]
namespace ProgressApp.UWP.CustomRenderers
{
	class NativeRatingViewRenderer : ViewRenderer<NativeRatingView, CustomCircleTemplate>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<NativeRatingView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				var customCircleTemplate = new CustomCircleTemplate();
				SolidColorBrush mySolidColorBrush = new SolidColorBrush();
				mySolidColorBrush.Color = ConvertColorType(Element.Color);
				customCircleTemplate.Fill = mySolidColorBrush;

				SetVisibility(customCircleTemplate);
				SetNativeControl(customCircleTemplate);
			}
		}
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == NativeRatingView.ValueProperty.PropertyName)
			{
				SetVisibility(Control);
			}
			if (e.PropertyName == NativeRatingView.ColorProperty.PropertyName)
			{
				SolidColorBrush mySolidColorBrush = new SolidColorBrush();
				mySolidColorBrush.Color = ConvertColorType(Element.Color);
				Control.Fill = mySolidColorBrush;
			}
		}
		Windows.UI.Color ConvertColorType(System.Drawing.Color color)
		{
			byte AVal = color.A;
			byte RVal = color.R;
			byte GVal = color.G;
			byte BVal = color.B;

			return Windows.UI.Color.FromArgb(AVal, RVal, GVal, BVal);
		}
		private void SetVisibility(CustomCircleTemplate control)
		{
			int value = Element.Value;
			if (value == 1)
			{
				control.FirstEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.SecondEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
				control.ThirdEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
				control.FourthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
				control.FifthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
			}
			if (Element.Value == 2)
			{
				control.FirstEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.SecondEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.ThirdEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
				control.FourthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
				control.FifthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
			}
			if (Element.Value == 3)
			{
				control.FirstEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.SecondEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.ThirdEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.FourthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
				control.FifthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
			}
			if (Element.Value == 4)
			{
				control.FirstEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.SecondEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.ThirdEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.FourthEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.FifthEllipseVisibility = Windows.UI.Xaml.Visibility.Collapsed;
			}
			if (Element.Value == 5)
			{
				control.FirstEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.SecondEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.ThirdEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.FourthEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
				control.FifthEllipseVisibility = Windows.UI.Xaml.Visibility.Visible;
			}
		}
	}
}
