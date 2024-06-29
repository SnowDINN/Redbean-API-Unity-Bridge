using System;
using System.Collections.Generic;

namespace Redbean.Api
{
	public class StringResponse : IResponse
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
	
	public class StringArrayResponse : IResponse
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
	
	public class DictionaryResponse : IResponse
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