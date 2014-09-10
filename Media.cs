using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Media {
		[DataMember]
		public string display_url;

		[DataMember]
		public string expanded_url;

		[DataMember]
		public long id;

		[DataMember]
		public string id_str;

		[DataMember]
		public List<int> indicies;

		[DataMember]
		public string media_url;

		[DataMember]
		public string media_url_https;

		[DataMember]
		public Sizes sizes;

		[DataMember]
		public long source_status_id;

		[DataMember]
		public string source_status_id_str;

		[DataMember]
		public string type;

		[DataMember]
		public string url;
	}
}
