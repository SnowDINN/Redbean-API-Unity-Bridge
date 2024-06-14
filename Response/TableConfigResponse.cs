using Newtonsoft.Json;
using Redbean.Api;

namespace Redbean.MVP.Content
{
	public class TableConfigResponse : IResponse
	{
		[JsonProperty("client")]
		public TableClientConfig Client { get; set; } = new();
		
		[JsonProperty("sheet")]
		public TableSheetConfig Sheet { get; set; } = new();
	}
	
	public class TableClientConfig
	{
		[JsonProperty("id")]
		public string Id { get; set; } = string.Empty;
		
		[JsonProperty("secret")]
		public string Secret { get; set; } = string.Empty;
	}
	
	public class TableSheetConfig
	{
		[JsonProperty("id")]
		public string Id { get; set; } = string.Empty;
	}
}