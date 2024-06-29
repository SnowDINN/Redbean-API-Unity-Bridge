using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Redbean.Api
{
	public class Response : IResponse
	{
		public static Response Default { get; set; } = new();
		
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; }

		[JsonProperty("response")]
		public object Value { get; set; }
	}
}