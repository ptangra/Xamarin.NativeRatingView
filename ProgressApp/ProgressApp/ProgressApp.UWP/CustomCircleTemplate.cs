using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace ProgressApp.UWP
{
	public sealed class CustomCircleTemplate : Control
	{
		public CustomCircleTemplate()
		{
			this.DefaultStyleKey = typeof(CustomCircleTemplate);
		}
		public Brush Fill
		{
			get { return (Brush)GetValue(FillProperty); }
			set { SetValue(FillProperty, value); }
		}
		public static readonly DependencyProperty FillProperty =
			DependencyProperty.Register("Fill", typeof(Brush), typeof(CustomCircleTemplate), new PropertyMetadata(""));

		public Visibility FirstEllipseVisibility
		{
			get { return (Visibility)GetValue(FirstEllipseVisibilityProperty); }
			set { SetValue(FirstEllipseVisibilityProperty, value); }
		}
		public static readonly DependencyProperty FirstEllipseVisibilityProperty =
			DependencyProperty.Register("FirstEllipseVisibility", typeof(Visibility), typeof(CustomCircleTemplate), new PropertyMetadata(""));

		public Visibility SecondEllipseVisibility
		{
			get { return (Visibility)GetValue(SecondEllipseVisibilityProperty); }
			set { SetValue(SecondEllipseVisibilityProperty, value); }
		}
		public static readonly DependencyProperty SecondEllipseVisibilityProperty =
			DependencyProperty.Register("SecondEllipseVisibility", typeof(Visibility), typeof(CustomCircleTemplate), new PropertyMetadata(""));

		public Visibility ThirdEllipseVisibility
		{
			get { return (Visibility)GetValue(ThirdEllipseVisibilityProperty); }
			set { SetValue(ThirdEllipseVisibilityProperty, value); }
		}
		public static readonly DependencyProperty ThirdEllipseVisibilityProperty =
			DependencyProperty.Register("ThirdEllipseVisibility", typeof(Visibility), typeof(CustomCircleTemplate), new PropertyMetadata(""));

		public Visibility FourthEllipseVisibility
		{
			get { return (Visibility)GetValue(FourthEllipseVisibilityProperty); }
			set { SetValue(FourthEllipseVisibilityProperty, value); }
		}
		public static readonly DependencyProperty FourthEllipseVisibilityProperty =
			DependencyProperty.Register("FourthEllipseVisibility", typeof(Visibility), typeof(CustomCircleTemplate), new PropertyMetadata(""));

		public Visibility FifthEllipseVisibility
		{
			get { return (Visibility)GetValue(FifthEllipseVisibilityProperty); }
			set { SetValue(FifthEllipseVisibilityProperty, value); }
		}
		public static readonly DependencyProperty FifthEllipseVisibilityProperty =
			DependencyProperty.Register("FifthEllipseVisibility", typeof(Visibility), typeof(CustomCircleTemplate), new PropertyMetadata(""));
	}
}
