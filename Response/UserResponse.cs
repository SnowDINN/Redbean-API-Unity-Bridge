using Newtonsoft.Json;

namespace Redbean.Api
{
	public class UserResponse : Response
	{
		[JsonProperty("information")]
		public UserInfo Information = new();

		[JsonProperty("social")]
		public UserSocial Social = new();
	}
	
	public class UserInfo
	{
		[JsonProperty("nickname")]
		public string Nickname = string.Empty;
	}
	
	public class UserSocial
	{
		[JsonProperty("id")]
		public string Id = string.Empty;
		
		[JsonProperty("platform")]
		public string Platform = string.Empty;
	}	
}