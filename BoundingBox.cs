using System.Collections.Generic;
using System.Runtime.Serialization;

namespace tnwops.TwitterApi {
	[DataContract]
	public class BoundingBox {
		[DataMember]
		public List<List<List<double>>> coordinates;

		[DataMember]
		public string type;
	}
}
