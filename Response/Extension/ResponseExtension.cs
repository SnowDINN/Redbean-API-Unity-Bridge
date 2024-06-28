using Newtonsoft.Json;

namespace Redbean.Api
{
	public interface IResponse
	{
		int ErrorCode { get; set; }
	}
	
	public class Response<T> : IResponse where T : new()
	{
		[JsonProperty("errorCode")]
		public int ErrorCode { get; set; }

		public static Task<T> ReturnErrorCode(int code)
		{
			var completionSource = new TaskCompletionSource<T>();
			
			var instance = new T();
			var response = instance as Response<T>;
			
			response.ErrorCode = code;
			
			completionSource.SetResult(instance);
			return completionSource.Task;
		}
	}
}