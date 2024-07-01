namespace Redbean.Api
{
#region Maintenance

	public class AppMaintenanceRequest : IApiRequest
	{
		public string Contents = string.Empty;
		public DateTime StartTime = DateTime.UtcNow;
		public DateTime EndTime = DateTime.UtcNow;
	}

#endregion

#region Version

	public class AppVersionRequest : IApiRequest
	{
		public MobileType Type = MobileType.None;
		public string Version = string.Empty;
	}

#endregion
	
#region Upload Files
	
	public class AppUploadFilesRequest : IApiRequest
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