using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Tweet {
		[DataMember]
		public object annotations;

		[DataMember]
		public List<Contributors> contributors;

		[DataMember]
		public Coordinates coordinates;

		[DataMember]
		public string created_at;

		[DataMember]
		public CurrentUserRetweet current_user_retweet;

		[DataMember]
		public Entities entities;

		[DataMember]
		public int? favorite_count;

		[DataMember]
		public bool? favorited;

		[DataMember]
		public string filter_level;

		[DataMember]
		public object geo;

		[DataMember]
		public long id;

		[DataMember]
		public string id_str;

		[DataMember]
		public string in_reply_to_screen_name;

		[DataMember]
		public long? in_reply_to_status_id;

		[DataMember]
		public string in_reply_to_status_id_str;

		[DataMember]
		public long? in_reply_to_user_id;

		[DataMember]
		public string in_reply_to_user_id_str;

		[DataMember]
		public string lang;

		[DataMember]
		public List<Places> place;

		[DataMember]
		public bool? possibly_sensitive;
 
		[DataMember]
		public Dictionary<string,string> scopes;

		[DataMember]
		public int retweet_count;

		[DataMember]
		public bool retweeted;

		[DataMember]
		public Tweet retweeted_status;

		[DataMember]
		public string source;

		[DataMember]
		public string text;

		[DataMember]
		public bool truncated;

		[DataMember]
		public Users user;

		[DataMember]
		public bool withheld_copyright;

		[DataMember]
		public List<string> withheld_in_countries;

		[DataMember]
		public string withheld_scope;
	}
}
