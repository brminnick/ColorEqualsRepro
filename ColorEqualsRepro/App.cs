using System;

using Xamarin.Forms;

namespace ColorEqualsRepro
{
	public class App : Application
	{
		public App() => MainPage = new MainPage();
	}

	public class MainPage : ContentPage
	{
		readonly Button _toggleColorButton;

		public MainPage()
		{
			_toggleColorButton = new Button
			{
				Text = "Toggle Background Color",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};
			_toggleColorButton.Clicked += HandleColorButtonClicked;

			Content = _toggleColorButton;
		}

		void HandleColorButtonClicked(object sender, EventArgs e)
		{
			if (BackgroundColor.Equals(ColorConstants.LightBlue))
			{
				if (Device.RuntimePlatform.Equals(Device.iOS))
					_toggleColorButton.TextColor = Color.White;
				
				_toggleColorButton.Text = $"Change Background Color to {nameof(ColorConstants.LightBlue)}";
                BackgroundColor = ColorConstants.DarkBlue;
			}
			else
			{
                _toggleColorButton.TextColor = Color.Black;
                _toggleColorButton.Text = $"Change Background Color to {nameof(ColorConstants.DarkBlue)}";
				BackgroundColor = ColorConstants.LightBlue;
			}
		}
	}
}
