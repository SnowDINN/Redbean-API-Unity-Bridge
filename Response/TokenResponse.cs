using System;

namespace Redbean.Api
{
	public class TokenResponse : IResponse
	{
		public DateTime AccessTokenExpire { get; set; } = DateTime.UtcNow;
		public DateTime RefreshTokenExpire { get; set; } = DateTime.UtcNow;
		public string AccessToken { get; set; } = "";
		public string RefreshToken { get; set; } = "";
	}	
}