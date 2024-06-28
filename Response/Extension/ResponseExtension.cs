namespace Redbean.Api
{
	public interface IResponse
	{
		int ErrorCode { get; set; }
	}
	
	public class Response : IResponse
	{
		public int ErrorCode { get; set; }
	}
}