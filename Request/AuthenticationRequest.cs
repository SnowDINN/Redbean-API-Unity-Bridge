namespace Redbean.Api
{
	public class UserRequest : IApiRequest
	{
		public AuthenticationType type;
		public string id;
	}

	public class UserWithdrawalRequest : IApiRequest
	{
		public AuthenticationType type;
	}
}