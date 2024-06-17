namespace Redbean.Api
{
	public class AccessTokenResponse : IResponse
	{
		public long Expires = 0;
		public string AccessToken = "";
	}	
}