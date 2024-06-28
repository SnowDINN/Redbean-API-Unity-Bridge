﻿using Newtonsoft.Json;

namespace Redbean.Api
{
	public class UserAndTokenResponse : Response
	{
		[JsonProperty("information")]
		public UserInfo Information = new();

		[JsonProperty("social")]
		public UserSocial Social = new();
	
		public string AccessToken = string.Empty;
		public string RefreshToken = string.Empty;
		public DateTime AccessTokenExpire = DateTime.UtcNow;
		public DateTime RefreshTokenExpire = DateTime.UtcNow;
	}	
}