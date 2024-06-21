using Newtonsoft.Json;

namespace Redbean.Api
{
	[Serializable]
	public class UserResponse : IResponse
	{
		[JsonProperty("information")]
		public UserInfo Information = new();

		[JsonProperty("social")]
		public UserSocial Social = new();
	}

	[Serializable]
	public class UserInfo
	{
		[JsonProperty("nickname")]
		public string Nickname = "";
	}

	[Serializable]
	public class UserSocial
	{
		[JsonProperty("id")]
		public string Id = "";
		
		[JsonProperty("platform")]
		public string Platform = "";
	}	
}