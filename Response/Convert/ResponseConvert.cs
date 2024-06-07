using Newtonsoft.Json;

namespace Redbean.Api;

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
		return JsonConvert.DeserializeObject<ResponseResult<T>>(response);
	}
}

public class ResponseResult<T>
{
	public int StatusCode;
	public T Result;
}