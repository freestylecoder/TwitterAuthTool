using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Entities {
		[DataMember]
		public List<Hashtags> hashtags;

		[DataMember]
		public List<Media> media;

		[DataMember]
		public List<URL> urls;

		[DataMember]
		public List<UserMention> user_mentions;
	}
}
