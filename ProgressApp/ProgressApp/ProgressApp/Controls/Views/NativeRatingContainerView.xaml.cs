using ProgressApp.Controls.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgressApp.Controls.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NativeRatingContainerView : ContentView
	{
		NativeRatingView custom = new NativeRatingView();
		public NativeRatingContainerView()
		{
			InitializeComponent();
			this.BindingContext = new NativeRatingContainerViewModel();
			custom.SetBinding(NativeRatingView.ValueProperty, "CustomValue");
			custom.SetBinding(NativeRatingView.ColorProperty, "CustomColor");
			ratingViewFrame.Content = new StackLayout
			{
				Children =
				{
					custom
				}
			};
		}
		private void OnTextChanged(object sender, TextChangedEventArgs e)
		{
			//lets the Entry be empty
			if (string.IsNullOrEmpty(e.NewTextValue)) return;

			if (!int.TryParse(e.NewTextValue, out int value))
			{
				((Entry)sender).Text = e.OldTextValue;
			}
			else
			{
				if(int.Parse(e.NewTextValue) > 5 || e.NewTextValue == "0")
				{
					((Entry)sender).Text = e.OldTextValue;
				}
			}
		}
	}
}