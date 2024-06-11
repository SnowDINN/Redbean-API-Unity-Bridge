namespace Redbean.Api
{
	public class AppVersionResponse : IResponse
	{
		public string BeforeVersion { get; set; } = "";
		public string AfterVersion { get; set; } = "";
	}	
}