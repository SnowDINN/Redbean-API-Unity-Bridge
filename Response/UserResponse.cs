using Newtonsoft.Json;

namespace Redbean.Api
{
	public class UserResponse : IResponse
	{
		[JsonProperty("information")]
		public UserInfoModel Information;
		
		[JsonProperty("social")]
		public UserSocialModel Social;
	}

	public class UserInfoModel
	{
		[JsonProperty("nickname")]
		public string Nickname;
	}

	public class UserSocialModel
	{
		[JsonProperty("id")]
		public string Id;
		
		[JsonProperty("platform")]
		public string Platform;
	}	
}