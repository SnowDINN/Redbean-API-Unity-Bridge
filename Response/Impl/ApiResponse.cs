using Newtonsoft.Json;

namespace Redbean.Api
{
	public class ApiResponse : IApiResponse
	{
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; } = -1;

		[JsonProperty("response")]
		public object RawResponse { get; set; } = new();

		[JsonIgnore]
		public bool IsSuccess => ErrorCode == 0;
	}
	
	public class ApiResponse<T> : ApiResponse
	{
		[JsonIgnore]
		private T response;

		[JsonIgnore]
		public T Response
		{
			get
			{
				if (response is null)
					response = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(RawResponse));

				return response;
			}
		}
	}
}