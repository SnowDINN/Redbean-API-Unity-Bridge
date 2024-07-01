using Newtonsoft.Json;

namespace Redbean.Api
{
	public class HttpResponse : IHttpResponse
	{
		[JsonIgnore]
		public static HttpResponse Default { get; set; } = new();
		
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("response")]
		public object Response { get; set; }
	}
	
	public class HttpResponse<T> : IHttpResponse
	{
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("response")]
		public T Response { get; set; }
	}
}