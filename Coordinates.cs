using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class Coordinates {
		[DataMember]
		public List<double> coordinates;

		[DataMember]
		public string type;
	}
}
