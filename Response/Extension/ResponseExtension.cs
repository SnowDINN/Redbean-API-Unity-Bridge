using System.Collections.Generic;
using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
	}
	
	public class Response
	{
		public Response(int code, object value)
		{
			Code = code;
			Value = value;
		}
		
		public int Code { get; set; }
		public object Value { get; set; }

		public T ToConvert<T>()
		{
			if (Value is string result)
				return JsonConvert.DeserializeObject<T>(result);

			return default;
		}
	}
	
	public static class ResponseExtension
	{
		public static Response ToResponse(this string message, ApiErrorType type = 0) => new((int)type, message);

		public static Response ToResponse<T>(this List<T> message, ApiErrorType type = 0) => new((int)type, message);

		public static Response ToResponse(this IDictionary<string, object> snapshot, ApiErrorType type = 0) => new((int)type, snapshot);

		public static Response ToResponse<T>(this T value, ApiErrorType type = 0) where T : IResponse => new((int)type, value);
	}
}