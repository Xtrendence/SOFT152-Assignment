using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152Assignment {
    public class Neighborhood {
        public string name;
        public int propertyCount;
        public string[] propertyNames;
        public Neighborhood(string neighborhoodName, int neighborhoodPropertyCount, string[] neighborhoodPropertyNames) {
            this.name = neighborhoodName;
            this.propertyCount = neighborhoodPropertyCount;
            this.propertyNames = neighborhoodPropertyNames;
        }
		public Neighborhood(string neighborhoodName, int neighborhoodPropertyCount) {
			this.name = neighborhoodName;
			this.propertyCount = neighborhoodPropertyCount;
		}
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
        public int PropertyCount {
            get {
                return this.propertyCount;
            }
            set {
                this.propertyCount = value;
            }
        }
        public string[] PropertyNames {
            get {
                return this.propertyNames;
            }
            set {
                this.propertyNames = value;
            }
        }
    }
}
