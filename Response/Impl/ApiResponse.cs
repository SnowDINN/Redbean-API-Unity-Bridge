﻿using Newtonsoft.Json;

namespace Redbean.Api
{
	public class ApiResponse : IApiResponse
	{
		[JsonIgnore]
		public static ApiResponse Default { get; set; } = new();
		
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; } = -1;

		[JsonProperty("response")]
		public object Response { get; set; } = new();
	}
	
	public class ApiResponse<T> : IApiResponse where T : new()
	{
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; } = -1;

		[JsonProperty("response")]
		public T Response { get; set; } = new();
	}
}