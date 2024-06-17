﻿using Newtonsoft.Json;
using Redbean.Api;

namespace Redbean.MVP.Content
{
#region TableConfig

	public class TableConfigResponse : IResponse
	{
		[JsonProperty("client")]
		public TableClientConfig Client = new();
		
		[JsonProperty("sheet")]
		public TableSheetConfig Sheet = new();
	}
	
	public class TableClientConfig
	{
		[JsonProperty("id")]
		public string Id = string.Empty;
		
		[JsonProperty("secret")]
		public string Secret = string.Empty;
	}
	
	public class TableSheetConfig
	{
		[JsonProperty("id")]
		public string Id = string.Empty;
	}

#endregion
}