using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152Assignment
{
	class Data
	{
		// Used to store the data from the file. Each district contains an array of neighborhoods, which contain arrays of properties.
		public static District[] districts = new District[0];
		// Used to determine when the data in the districts array has changed. This is used by the main form's "Activated" event listener to refresh the data.
		public static bool changed = false;
	}
}
