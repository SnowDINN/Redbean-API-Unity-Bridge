using Newtonsoft.Json;

namespace Redbean.Api
{
	public class Response : IResponse
	{
		[JsonIgnore]
		public static Response Default { get; set; } = new();
		
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("response")]
		public object Value { get; set; }
	}
	
	public class Response<T> : IResponse
	{
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("response")]
		public T Value { get; set; }
	}
}