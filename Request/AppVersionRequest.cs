namespace Redbean.Api
{
	public class AppVersionRequest : Request
	{
		public MobileType Type = MobileType.None;
		public string Version = string.Empty;
	}	
}