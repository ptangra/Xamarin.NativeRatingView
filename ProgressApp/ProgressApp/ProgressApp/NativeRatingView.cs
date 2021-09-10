using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace ProgressApp
{
	public class NativeRatingView : View
	{
		public static readonly BindableProperty ValueProperty =
			BindableProperty.Create("Value", typeof(int), typeof(NativeRatingView), 1);
		public int Value
		{
			get { return (int)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		public static readonly BindableProperty ColorProperty =
			BindableProperty.Create("Color", typeof(Color), typeof(NativeRatingView), Color.Blue);
		public Color Color
		{
			get { return (Color)GetValue(ColorProperty); }
			set { SetValue(ColorProperty, value); }
		}
	}
}
