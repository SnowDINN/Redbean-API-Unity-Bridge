using System;

namespace Redbean.Api
{
	public class AppUploadFilesRequest : Request
	{
		public MobileType Type = MobileType.None;
		public RequestFile[] Files = Array.Empty<RequestFile>();
	}

	public class RequestFile
	{
		public string FileName;
		public byte[] FileData;
	}	
}