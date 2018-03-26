using Xamarin.Forms;

namespace ColorEqualsRepro
{
	public static class ColorConstants
	{
		#region Fields
		static Color _darkBlue, _lightBlue;
		#endregion
        
		#region Properties
		public static Color DarkBlue => _darkBlue == default ? (_darkBlue = Color.FromHex("2980b9")) : _darkBlue;
		public static Color LightBlue => _lightBlue.Equals(default) ? (_lightBlue = Color.FromHex("3498db")) : _lightBlue;
		#endregion
	}
}
