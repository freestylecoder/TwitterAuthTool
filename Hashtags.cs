using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Hashtags {
		[DataMember]
		public List<int> indicies;

		[DataMember]
		public string text;
	}
}
