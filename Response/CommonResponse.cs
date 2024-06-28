using System;
using System.Collections.Generic;

namespace Redbean.Api
{
	public class StringResponse : Response
	{
		public StringResponse(string value) => Value = value;
		
		public string Value = string.Empty;
	}
	
	public class StringArrayResponse : Response
	{
		public StringArrayResponse(IEnumerable<string> value) => Value = value;
		
		public IEnumerable<string> Value = Array.Empty<string>();
	}
	
	public class DictionaryResponse : Response
	{
		public DictionaryResponse(Dictionary<string, object> value) => Value = value;
		
		public Dictionary<string, object> Value = new();
	}	
}