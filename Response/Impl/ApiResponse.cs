using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Redbean.Api
{
	public class ApiResponse : IApiResponse
	{
		[JsonIgnore]
		public static ApiResponse Default { get; set; } = new();
		
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; } = -1;

		[JsonProperty("response")]
		public JObject RawResponse { get; set; } = new();
	}
	
	public class ApiResponse<T> : ApiResponse
	{
		[JsonIgnore]
		public T Response => RawResponse.Value<T>();
	}
}