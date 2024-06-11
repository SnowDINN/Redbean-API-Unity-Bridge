using Newtonsoft.Json;

namespace Redbean.Api
{
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
}