using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Sizes {
		[DataMember]
		public Size thumb;

		[DataMember]
		public Size large;

		[DataMember]
		public Size medium;

		[DataMember]
		public Size small;
	}
}
