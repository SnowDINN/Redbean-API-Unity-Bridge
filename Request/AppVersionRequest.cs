namespace Redbean.Api
{
	public class AppVersionRequest : HttpRequest
	{
		public MobileType Type = MobileType.None;
		public string Version = string.Empty;
	}	
}