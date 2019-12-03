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
		// Used to determine if there are changes that need to be saved to the data file.
		public static bool unsaved = false;
		// Used to determine whether or not a district was deleted.
		public static bool deletedDistrict = false;
		// Used to determine whether or not a neighborhood was deleted.
		public static bool deletedNeighborhood = false;
		// Used to determine whether or not a property was deleted.
		public static bool deletedProperty = false;

		// Method to add a district to the districts array.
		public static void AddDistrict(District district)
		{
			int numberOfDistricts = districts.Length;
			Array.Resize(ref districts, numberOfDistricts + 1);
			districts[numberOfDistricts] = district;
		}
	}
}
