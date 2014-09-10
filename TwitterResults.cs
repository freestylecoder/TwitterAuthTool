using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	[KnownType(typeof(Tweet))]
	public class TwitterResults {
		[DataMember]
		public List<Tweet> statuses;

		[DataMember]
		public SearchMetadata search_metadata;
	}
}
