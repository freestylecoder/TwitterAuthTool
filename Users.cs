using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Users {
		[DataMember]
		public bool contributors_enabled;

		[DataMember]
		public string created_at;

		[DataMember]
		public bool default_profile;

		[DataMember]
		public bool default_profile_image;

		[DataMember]
		public string description;

		[DataMember]
		public Entities entities;

		[DataMember]
		public int favourites_count;

		[DataMember]
		public bool? follow_request_sent;

		[DataMember]
		public bool? following;

		[DataMember]
		public int followers_count;

		[DataMember]
		public int friends_count;

		[DataMember]
		public bool geo_enabled;

		[DataMember]
		public long id;

		[DataMember]
		public string id_str;

		[DataMember]
		public bool is_translator;

		[DataMember]
		public string lang;

		[DataMember]
		public int listed_count;

		[DataMember]
		public string location;

		[DataMember]
		public string name;

		[DataMember]
		public bool? notifications;

		[DataMember]
		public string profile_background_color;

		[DataMember]
		public string profile_background_image_url;

		[DataMember]
		public string profile_background_image_url_https;

		[DataMember]
		public bool profile_background_tile;

		[DataMember]
		public string profile_banner_url;

		[DataMember]
		public string profile_image_url;

		[DataMember]
		public string profile_image_url_https;

		[DataMember]
		public string profile_link_color;

		[DataMember]
		public string profile_sidebar_border_color;

		[DataMember]
		public string profile_sidebar_fill_color;

		[DataMember]
		public string profile_text_color;

		[DataMember]
		public bool profile_use_background_image;

		[DataMember( Name="protected" )]
		public bool Protected;

		[DataMember]
		public string screen_name;

		[DataMember]
		public bool show_all_inline_media;

		[DataMember]
		public Tweet status;

		[DataMember]
		public int statuses_count;

		[DataMember]
		public string time_zone;

		[DataMember]
		public string url;

		[DataMember]
		public int? utc_offset;

		[DataMember]
		public bool verified;

		[DataMember]
		public List<string> withheld_in_countries;

		[DataMember]
		public string withheld_scope;
	}
}
