using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152Assignment
{
	public class Neighborhood
	{
		public string name;
		public int propertyCount;
		public Property[] properties = new Property[0];
		public Neighborhood(string neighborhoodName, int neighborhoodPropertyCount, Property neighborhoodProperty)
		{
			this.name = neighborhoodName;
			this.propertyCount = neighborhoodPropertyCount;
			int numberOfProperties = this.properties.Length;
			Array.Resize(ref properties, numberOfProperties + 1);
			properties[numberOfProperties] = neighborhoodProperty;
		}
		public Neighborhood(string neighborhoodName, int neighborhoodPropertyCount)
		{
			this.name = neighborhoodName;
			this.propertyCount = neighborhoodPropertyCount;
		}
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		public int PropertyCount
		{
			get
			{
				return this.propertyCount;
			}
			set
			{
				this.propertyCount = value;
			}
		}
		public Property[] Properties
		{
			get
			{
				return this.properties;
			}
			set
			{
				this.properties = value;
			}
		}
		public void addProperty(Property property)
		{
			int numberOfProperties = this.properties.Length;
			Array.Resize(ref properties, numberOfProperties + 1);
			properties[numberOfProperties] = property;
		}
	}
}
