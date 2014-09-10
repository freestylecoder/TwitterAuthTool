using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Size {
		[DataMember]
		public int h;

		[DataMember]
		public string resize;

		[DataMember]
		public int w;
	}
}
