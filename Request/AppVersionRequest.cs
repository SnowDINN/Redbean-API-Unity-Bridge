namespace Redbean.Api
{
	public class AppVersionRequest : IApiRequest
	{
		public MobileType Type = MobileType.None;
		public string Version = string.Empty;
	}	
}