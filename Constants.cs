using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tnwops.TwitterApi {
	public static class Constants {
		/// <summary>A format string for DateTime.ParseExact that will correctly convert a Twitter date time string</summary>
		public const string DATE_TIME_FORMAT = "ddd MMM dd HH:mm:ss '+0000' yyyy";
	}
}
