using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Contributors {
		[DataMember]
		public long id;

		[DataMember]
		public string id_str;

		[DataMember]
		public string screen_name;
	}
}
