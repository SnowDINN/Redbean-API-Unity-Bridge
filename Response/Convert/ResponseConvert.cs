using Newtonsoft.Json;

namespace Redbean.Api
{
	public class ResponseConvert
	{
		public static string ToJson(object value, int code = 0)
		{
			var result = new ResponseResult
			{
				StatusCode = code,
				Result = value
			};

			return JsonConvert.SerializeObject(result, Formatting.Indented);
		}

		public static T ToClass<T>(string response)
		{
			return JsonConvert.DeserializeObject<T>(response);
		}
	}

	public class ResponseResult
	{
		public int StatusCode;
		public object Result;
	}
}