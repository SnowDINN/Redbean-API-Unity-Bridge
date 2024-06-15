namespace Redbean.Api
{
	public class AccessTokenResponse : IResponse
	{
		public long Expires { get; set; } = 0;
		public string AccessToken { get; set; } = "";
	}	
}