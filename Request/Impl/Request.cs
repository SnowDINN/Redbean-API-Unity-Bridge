using System.Linq;
using Newtonsoft.Json;

namespace Redbean.Api
{
	public class Request : IRequest
	{
		[JsonIgnore]
		public RequestType RequestType
		{
			get
			{
				var fields = GetType().GetFields().Any(_ => _.FieldType == typeof(byte[]));
				return fields ? RequestType.MultiPart : RequestType.Json;
			}
		}
	}
}