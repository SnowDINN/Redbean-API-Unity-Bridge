using Newtonsoft.Json;

namespace Redbean.Api
{
	public class UserResponse : IResponse
	{
		[JsonProperty("information")]
		public UserInfo Information { get; set; } = new();

		[JsonProperty("social")]
		public UserSocial Social { get; set; } = new();
	}

	public class UserInfo
	{
		[JsonProperty("nickname")]
		public string Nickname { get; set; } = "";
	}

	public class UserSocial
	{
		[JsonProperty("id")]
		public string Id { get; set; } = "";
		
		[JsonProperty("platform")]
		public string Platform { get; set; } = "";
	}	
}