﻿using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class AccessToken {
		[DataMember]
		public string token_type;

		[DataMember]
		public string access_token;
	}
}
