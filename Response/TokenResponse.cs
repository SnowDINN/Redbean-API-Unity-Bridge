using System;

namespace Redbean.Api
{
	public class TokenResponse : IResponse
	{
		public DateTime AccessTokenExpire = DateTime.UtcNow;
		public DateTime RefreshTokenExpire = DateTime.UtcNow;
		public string AccessToken = "";
		public string RefreshToken = "";
	}	
}