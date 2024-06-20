#pragma warning disable CS8603
#pragma warning disable CS8618

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
	}
	
	public class Response
	{
		private static readonly Response Default = new();
		
		public int Code { get; set; }
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
	
	public static class ResponseExtension
	{
		public static Response ToResponse(this string message, ApiErrorType type = 0) => Response.Return((int)type, message);

		public static Response ToResponse<T>(this List<T> message, ApiErrorType type = 0) => Response.Return((int)type, message);

		public static Response ToResponse(this IDictionary<string, object> snapshot, ApiErrorType type = 0) => Response.Return((int)type, snapshot);

		public static Response ToResponse<T>(this T value, ApiErrorType type = 0) where T : IResponse => Response.Return((int)type, value);
	}
}