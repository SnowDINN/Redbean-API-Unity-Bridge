using System;

namespace Redbean.Api
{
#region Maintenance

	public class AppMaintenanceRequest : ApiRequest
	{
		public string Contents = string.Empty;
		public DateTime StartTime = DateTime.Today;
		public DateTime EndTime = DateTime.Today;
	}

#endregion

#region Version

	public class AppVersionRequest : ApiRequest
	{
		public MobileType Type = MobileType.None;
		public string Version = string.Empty;
	}

#endregion
	
#region Upload Files
	
	public class AppUploadFilesRequest : ApiRequest
	{
		public MobileType Type = MobileType.None;
		public RequestFile[] Files = Array.Empty<RequestFile>();
	}

	public class RequestFile
	{
		public string FileName;
		public byte[] FileData;
	}	
	
#endregion
}