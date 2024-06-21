#pragma warning disable CS8603
#pragma warning disable CS8618

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
	}
	
	public class Response
	{
		private static readonly Response Default = new();
		
		[JsonProperty("code")]
		public int Code { get; set; }
		
		[JsonProperty("value")]
		public object Value { get; set; }

		public static Response Return(int code, object value)
		{
			Default.Code = code;
			Default.Value = value;

			return Default;
		}
		
		public T ToConvert<T>()
		{
			if (Value is string result)
				return JsonConvert.DeserializeObject<T>(result);

			return default;
		}
	}
}