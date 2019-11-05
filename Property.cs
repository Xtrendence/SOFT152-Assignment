using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152Assignment {
    public class Property {
        public int id;
        public string name;
        public int hostID;
        public string hostName;
        public int count;
        public double latitude;
        public double longitude;
        public string roomType;
        public double roomPrice;
        public int roomNights;
        public int roomAvailability;
        public Property(int propertyID, string propertyName, int propertyHostID, string propertyHostName, int propertyCount, double propertyLatitude, double propertyLongitude, string propertyRoomType, double propertyRoomPrice, int propertyRoomNights, int propertyRoomAvailablity) {
            this.id = propertyID;
            this.name = propertyName;
            this.hostID = propertyHostID;
            this.hostName = propertyHostName;
            this.count = propertyCount;
            this.latitude = propertyLatitude;
            this.longitude = propertyLongitude;
            this.roomType = propertyRoomType;
            this.roomPrice = propertyRoomPrice;
            this.roomNights = propertyRoomNights;
            this.roomAvailability = propertyRoomAvailablity;
        }
        public int Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
        public int HostID {
            get {
                return this.hostID;
            }
            set {
                this.hostID = value;
            }
        }
        public string HostName {
            get {
                return this.hostName;
            }
            set {
                this.hostName = value;
            }
        }
        public int Count {
            get {
                return this.count;
            }
            set {
                this.count = value;
            }
        }
        public double Latitude {
            get {
                return this.latitude;
            }
            set {
                this.latitude = value;
            }
        }
        public double Longitude {
            get {
                return this.longitude;
            }
            set {
                this.longitude = value;
            }
        }
        public string RoomType {
            get {
                return this.roomType;
            }
            set {
                this.roomType = value;
            }
        }
        public double RoomPrice {
            get {
                return this.roomPrice;
            }
            set {
                this.roomPrice = value;
            }
        }
        public int RoomNights {
            get {
                return this.roomNights;
            }
            set {
                this.roomNights = value;
            }
        }
        public int RoomAvailability {
            get {
                return this.roomAvailability;
            }
            set {
                this.roomAvailability = value;
            }
        }
    }
}
