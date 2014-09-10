using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class CurrentUserRetweet {
		[DataMember]
		public long id;

		[DataMember]
		public string id_str;
	}
}
