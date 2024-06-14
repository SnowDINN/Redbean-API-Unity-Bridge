using Newtonsoft.Json;

namespace Redbean.Api
{
#region AppConfig

	public class AppConfigResponse : IResponse
	{
		[JsonProperty("android")]
		public MobileConfig Android { get; set; } = new();
		
		[JsonProperty("ios")]
		public MobileConfig iOS { get; set; } = new();
	}
	
	public class MobileConfig
	{
		[JsonProperty("version")]
		public string Version { get; set; } = string.Empty;
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