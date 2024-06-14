using System.Collections.Generic;
using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
	}
	
	public class Response
	{
		public Response(object value, int code)
		{
			Value = value;
			Code = code;
		}
		
		public object Value { get; set; }
		public int Code { get; set; }

		public T ToConvert<T>()
		{
			if (Value is string result)
				return JsonConvert.DeserializeObject<T>(result);

			return default;
		}
	}
	
	public static class ResponseExtension
	{
		public static string ToJson(this string message, int code = 0) =>
			JsonConvert.SerializeObject(new Response(message, code), Formatting.Indented);

		public static string ToJson<T>(this List<T> message, int code = 0) =>
			JsonConvert.SerializeObject(new Response(message, code), Formatting.Indented);

		public static string ToJson(this IDictionary<string, object> snapshot, int code = 0) =>
			JsonConvert.SerializeObject(new Response(snapshot, code), Formatting.Indented);

		public static string ToJson<T>(this T value, int code = 0) where T : IResponse =>
			JsonConvert.SerializeObject(new Response(value, code), Formatting.Indented);

		public static T ToConvert<T>(this string response) where T : IResponse =>
			JsonConvert.DeserializeObject<T>(response);
	}
}