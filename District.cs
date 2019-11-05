using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152Assignment {
    public class District {
        public string name;
        public int neighborhoodCount;
        public string[] neighborhoodNames;
        public District(string districtName, int districtNeighborhoodCount, string[] districtNeighborhoodNames) {
            this.name = districtName;
            this.neighborhoodCount = districtNeighborhoodCount;
            this.neighborhoodNames = districtNeighborhoodNames;
        }
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
        public int NeighborhoodCount {
            get {
                return this.neighborhoodCount;
            }
            set {
                this.neighborhoodCount = value;
            }
        }
        public string[] NeighborhoodNames {
            get {
                return this.neighborhoodNames;
            }
            set {
                this.neighborhoodNames = value;
            }
        }
    }
}
