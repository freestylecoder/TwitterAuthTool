using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class URL {
		[DataMember]
		public string display_url;

		[DataMember]
		public string expanded_url;

		[DataMember]
		public List<int> indices;

		[DataMember]
		public string url;
	}
}
