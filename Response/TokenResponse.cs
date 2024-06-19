using System;

namespace Redbean.Api
{
	public class TokenResponse : IResponse
	{
		public DateTime Expires { get; set; } = DateTime.UtcNow;
		public string AccessToken { get; set; } = "";
		public string RefreshToken { get; set; } = "";
	}	
}