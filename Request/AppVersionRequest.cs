namespace Redbean.Api
{
	public class AppVersionRequest : ApiRequest
	{
		public MobileType Type = MobileType.None;
		public string Version = string.Empty;
	}	
}