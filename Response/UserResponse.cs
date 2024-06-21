using Newtonsoft.Json;

namespace Redbean.Api
{
	public class UserResponse : IResponse
	{
		[JsonProperty("information")]
		public UserInfo Information = new();

		[JsonProperty("social")]
		public UserSocial Social = new();
	}
	
	public class UserInfo
	{
		[JsonProperty("nickname")]
		public string Nickname = "";
	}
	
	public class UserSocial
	{
		[JsonProperty("id")]
		public string Id = "";
		
		[JsonProperty("platform")]
		public string Platform = "";
	}	
}