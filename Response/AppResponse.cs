using Newtonsoft.Json;

namespace Redbean.Api
{
#region AppConfig

	public class AppConfigResponse : IResponse
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

	public class AppVersionResponse : IResponse
	{
		public string BeforeVersion { get; set; } = "";
		public string AfterVersion { get; set; } = "";
	}	

#endregion
}