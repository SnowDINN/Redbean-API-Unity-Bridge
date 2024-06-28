using Newtonsoft.Json;

namespace Redbean.Api
{
#region AppConfig
	
	public class AppConfigResponse : Response<AppConfigResponse>
	{
		[JsonProperty("android")]
		public MobileConfig Android = new();

		[JsonProperty("ios")]
		public MobileConfig iOS = new();
	}
	
	public class MobileConfig
	{
		[JsonProperty("version")]
		public string Version = string.Empty;
	}

#endregion

#region AppVersion

	public class AppVersionResponse : Response<AppVersionResponse>
	{
		public string BeforeVersion = string.Empty;
		public string AfterVersion = string.Empty;
	}	

#endregion
}