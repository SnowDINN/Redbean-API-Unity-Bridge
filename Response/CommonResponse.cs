using System;
using System.Collections.Generic;

namespace Redbean.Api
{
	public class StringResponse : IHttpResponse
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
	
	public class StringArrayResponse : IHttpResponse
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
	
	public class DictionaryResponse : IHttpResponse
	{
		public DictionaryResponse()
		{
			
		}
		
		public DictionaryResponse(Dictionary<string, object> value)
		{
			Value = value;
		}
		
		public Dictionary<string, object> Value = new();
	}	
}