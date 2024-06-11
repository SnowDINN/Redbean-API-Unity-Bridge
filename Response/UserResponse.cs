using Newtonsoft.Json;

namespace Redbean.Api
{
	public class UserResponse : IResponse
	{
		[JsonProperty("information")]
		public UserInfoModel Information { get; set; } = new();

		[JsonProperty("social")]
		public UserSocialModel Social { get; set; } = new();
	}

	public class UserInfoModel
	{
		[JsonProperty("nickname")]
		public string Nickname { get; set; } = "";
	}

	public class UserSocialModel
	{
		[JsonProperty("id")]
		public string Id { get; set; } = "";
		
		[JsonProperty("platform")]
		public string Platform { get; set; } = "";
	}	
}