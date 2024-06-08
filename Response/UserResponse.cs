namespace Redbean.Api
{
	public enum UserResponseCode
	{
		Success,
		NotFound,
	}
	
	public class UserResponse
	{
		public UserInfoModel information;
		public UserSocialModel social;
	}

	public class UserInfoModel
	{
		public string nickname;
	}

	public class UserSocialModel
	{
		public string id;
		public string platform;
	}	
}