using Xamarin.Forms;

namespace Cost2Meet.Resources
{
	public  static class FontResources
	{
		public static readonly Font Header = Font.SystemFontOfSize( Device.OnPlatform( 16, 16, 26 ) );
		public static readonly Font Subheader = Font.SystemFontOfSize( Device.OnPlatform( 12, 14, 24 ) );
		public static readonly Font Standard = Font.SystemFontOfSize( Device.OnPlatform( 12, 12, 22 ) );
		public static readonly Font Small = Font.SystemFontOfSize( Device.OnPlatform( 10, 10, 16 ) );
	}
	
}

