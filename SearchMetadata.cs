using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class SearchMetadata {
		[DataMember]
		public double completed_in;

		[DataMember]
		public long max_id;

		[DataMember]
		public string max_id_str;

		[DataMember]
		public string next_results;

		[DataMember]
		public int count;

		[DataMember]
		public string query;

		[DataMember]
		public string refresh_url;

		[DataMember]
		public long since_id;
	
		[DataMember]
		public string since_id_str;
	}
}
