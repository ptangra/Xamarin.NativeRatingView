using System.Windows.Input;
using Xamarin.Forms;

namespace ProgressApp.Controls.ViewModels
{
	class NativeRatingContainerViewModel : BaseViewModel
	{
		#region Commands
		public ICommand ApplyCommand { protected set; get; }
		#endregion

		#region Fields & Properties
		private Color ParsedColor;
		private string entryValue = "2";
		public string EntryValue
		{
			get { return entryValue; }
			set { entryValue = value; OnPropertyChanged("EntryValue"); }
		}
		private string entryColor = "Red";
		public string EntryColor
		{
			get { return entryColor; }
			set { entryColor = value; OnPropertyChanged("EntryColor"); SetColorValue(value); }
		}
		private string customValue = "2";
		public string CustomValue
		{
			get { return customValue; }
			set { customValue = value; OnPropertyChanged("CustomValue"); }
		}
		private Color customColor = Color.Red;
		public Color CustomColor
		{
			get { return customColor; }
			set { customColor = value; OnPropertyChanged("CustomColor"); }
		}
		#endregion

		#region Constructor
		public NativeRatingContainerViewModel()
		{
			ApplyCommand = new Command<string>((key) =>
			{
				CustomValue = EntryValue;
				CustomColor = ParsedColor;
			});
		}
		#endregion

		#region Methods
		private void SetColorValue(string color)
		{
			switch (color)
			{
				case "Red":
					ParsedColor = Color.Red;
					break;
				case "Blue":
					ParsedColor = Color.Blue;
					break;
				case "Green":
					ParsedColor = Color.Green;
					break;
				case "Black":
					ParsedColor = Color.Black;
					break;
				case "Yellow":
					ParsedColor = Color.Yellow;
					break;
			}
		}
		#endregion
	}
}
