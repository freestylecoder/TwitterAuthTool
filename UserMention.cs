using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class UserMention {
		[DataMember]
		public long id;

		[DataMember]
		public string id_str;

		[DataMember]
		public List<int> indices;

		[DataMember]
		public string name;

		[DataMember]
		public string screen_name;
	}
}
