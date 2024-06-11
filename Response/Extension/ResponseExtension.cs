using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
	}
	
	public class Response(object value, int code)
	{
		public object Value { get; set; } = value;
		public int Code { get; set; } = code;

		public T? ToConvert<T>()
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

		public static T? ToClass<T>(this string response) where T : IResponse =>
			JsonConvert.DeserializeObject<T>(response);
	}
}