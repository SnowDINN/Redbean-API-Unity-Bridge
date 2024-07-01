using Newtonsoft.Json;

namespace Redbean.Api
{
#region AppConfig
	
	public class AppConfigResponse : IApiResponse
	{
		[JsonProperty("version")]
		public VersionConfig Version = new();
	}
	
	public class VersionConfig
	{
		[JsonProperty("aos_version")]
		public string AndroidVersion = string.Empty;
		
		[JsonProperty("ios_version")]
		public string iOSVersion = string.Empty;
	}

#endregion

#region AppVersion

	public class AppVersionResponse : IApiResponse
	{
		public string BeforeVersion = string.Empty;
		public string AfterVersion = string.Empty;
	}	

#endregion
}