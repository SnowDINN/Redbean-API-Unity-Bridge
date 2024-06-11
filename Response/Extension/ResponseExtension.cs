using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
	}
	
	public class Response
	{
		public int StatusCode;
		public object Result;

		public T ToConvert<T>()
		{
			if (Result is string result)
				return JsonConvert.DeserializeObject<T>(result);

			return default;
		}
	}
	
	public static class ResponseExtension
	{
		public static string ToJson<T>(this T value, int code = 0) where T : IResponse
		{
			var result = new Response
			{
				StatusCode = code,
				Result = value
			};

			return JsonConvert.SerializeObject(result, Formatting.Indented);
		}

		public static T ToClass<T>(this string response) where T : IResponse
		{
			return JsonConvert.DeserializeObject<T>(response);
		}
	}
}