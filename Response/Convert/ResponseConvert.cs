using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Redbean.Api
{
	public class ResponseConvert
	{
		public static string ToJson<T>(T value, int code = 0)
		{
			var result = new ResponseResult<T>
			{
				StatusCode = code,
				Result = value
			};

			return JsonConvert.SerializeObject(result, Formatting.Indented);
		}

		public static ResponseResult<T> ToClass<T>(string response)
		{
			var json = JObject.Parse(response);
			var statusCode = json[nameof(ResponseResult<T>.StatusCode)].Value<int>();
			if (statusCode > 0)
				return new ResponseResult<T>()
				{
					StatusCode = statusCode,
					Result = default
				};
			
			return JsonConvert.DeserializeObject<ResponseResult<T>>(response);
		}
	}

	public class ResponseResult<T>
	{
		public int StatusCode;
		public T Result;
	}
}