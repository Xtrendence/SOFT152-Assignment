﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152Assignment
{
	public class District
	{
		public string name;
		public int neighborhoodCount;
		public Neighborhood[] neighborhoods = new Neighborhood[0];

		public District(string districtName, int districtNeighborhoodCount)
		{
			this.name = districtName;
			this.neighborhoodCount = districtNeighborhoodCount;
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

		public int NeighborhoodCount
		{
			get
			{
				return this.neighborhoodCount;
			}
			set
			{
				this.neighborhoodCount = value;
			}
		}

		public Neighborhood[] Neighborhoods
		{
			get
			{
				return this.neighborhoods;
			}
			set
			{
				this.neighborhoods = value;
			}
		}

		public void AddNeighborhood(Neighborhood neighborhood)
		{
			int numberOfNeighborhoods = this.neighborhoods.Length;
			Array.Resize(ref neighborhoods, numberOfNeighborhoods + 1);
			neighborhoods[numberOfNeighborhoods] = neighborhood;
			this.neighborhoodCount = neighborhoods.Length;
		}
	}
}
