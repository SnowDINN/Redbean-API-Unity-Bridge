using System;
using System.Collections.Generic;

namespace Redbean.Api
{
	public class StringResponse : ApiResponse
	{
		public StringResponse()
		{
			
		}

		public StringResponse(string value)
		{
			Value = value;
		}
		
		public string Value = string.Empty;
	}
	
	public class StringArrayResponse : ApiResponse
	{
		public StringArrayResponse()
		{
			
		}
		
		public StringArrayResponse(IEnumerable<string> value)
		{
			Value = value;
		}
		
		public IEnumerable<string> Value = Array.Empty<string>();
	}
}