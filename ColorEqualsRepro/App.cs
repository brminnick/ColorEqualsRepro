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
		readonly  Button _toggleColorButton;
		public MainPage()
		{
			_toggleColorButton = new Button { Text = "Toggle Background Color" };
			_toggleColorButton.Clicked += HandleColorButtonClicked;

			Content = _toggleColorButton;
		}      
		void HandleColorButtonClicked(object sender, EventArgs e)
		{
			if (BackgroundColor.Equals(ColorConstants.LightBlue))
			{
				BackgroundColor = ColorConstants.DarkBlue;
				_toggleColorButton.TextColor = Color.White;
				_toggleColorButton.Text = $"Change Color to {nameof(ColorConstants.LightBlue)}";
			}
			else
			{
				BackgroundColor = ColorConstants.LightBlue;
				_toggleColorButton.TextColor = Color.Black;
				_toggleColorButton.Text = $"Change Color to {nameof(ColorConstants.DarkBlue)}";
			}
		}
	}
}
