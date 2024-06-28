using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
		int ErrorCode { get; set; }
	}
	
	public class Response : IResponse
	{
		[JsonProperty("errorCode", Order = 1)]
		public int ErrorCode { get; set; }
	}
}