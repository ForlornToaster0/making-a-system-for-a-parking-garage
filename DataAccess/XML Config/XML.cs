using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataAccess
{
    public class XML //Ange properties för vår XML fil för att serialisera och deserialisera data.
    {
        
        private string _CZK;
        [XmlElement("Currency")]
        public string CZK
        {
            get { return _CZK; }
            set { _CZK = value; }
        }
        private int[] _vehiclePrice;
        [XmlArray("Vehicle Price")]
        public int[] VehiclePrice
        {
            get { return _vehiclePrice; }
            set { _vehiclePrice = value; }
        }


        private int _sizePerLot;
        [XmlElement("Parking Spot Size")]
        public int SizePerLot
        {
            get { return _sizePerLot; }
            set { _sizePerLot = value; }
        }
        private int _phouseSize; 
        [XmlElement("Parkinghouse Size")]
        public int PhouseSize
        {
            get { return _phouseSize; }
            set { _phouseSize = value; }
        }
        private int _carSize;
        [XmlElement("Car Size")]
        public int CarSize
        {
            get { return _carSize; }
            set { _carSize = value; }
        }
        private int _mcSize;
        [XmlElement("MC Size")]
        public int MCSize
        {
            get { return _mcSize; }
            set { _mcSize = value; }
        }
        private int _sizeX;
        public int SizeX
        {
            get { return _sizeX; }
            set { _sizeX = value; }
        }
        private int _sizeY;
        public int SizeY
        {
            get { return _sizeY; }
            set { _sizeY = value; }
        }

    }


}
