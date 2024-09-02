namespace Redbean.Api
{
	public class StringRequest : ApiRequest
	{
		public StringRequest()
		{
			
		}

		public StringRequest(string value)
		{
			Value = value;
		}
		
		public string Value = string.Empty;
	}
}