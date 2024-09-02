using Newtonsoft.Json;

namespace Redbean.Api
{
	public class ApiResponse : IApiResponse
	{
		[JsonIgnore]
		public static ApiResponse Default { get; set; } = new();
		
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; } = -1;

		[JsonProperty("response")]
		public object RawResponse { get; set; } = new();
	}
	
	public class ApiResponse<T> : ApiResponse where T : class
	{
		[JsonIgnore]
		public T Response => RawResponse as T;
	}
}