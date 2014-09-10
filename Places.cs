using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Places {
		[DataMember]
		public Dictionary<string,string> attributes;

		[DataMember]
		public BoundingBox bounding_box;

		[DataMember]
		public string country;

		[DataMember]
		public string country_code;

		[DataMember]
		public string full_name;

		[DataMember]
		public string id;

		[DataMember]
		public string name;

		[DataMember]
		public string place_type;

		[DataMember]
		public string url;
	}
}
