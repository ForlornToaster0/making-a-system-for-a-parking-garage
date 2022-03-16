using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataAccess
{
    public class XML
    {
        
        private string _CZK;
        [XmlElement("Currency")]
        public string CZK
        {
            get { return _CZK; }
            set { _CZK = value; }
        }
        private int _parkingPrice;
        [XmlElement("Parking Spot Price")]
        public int ParkingPrice
        {
            get { return _parkingPrice; }
            set { _parkingPrice = value; }
        }
        private int _sizePerLot;
        [XmlElement("Parking Spot Size")]
        public int SizePerLot
        {
            get { return _sizePerLot; }
            set { _sizePerLot = value; }
        }
        private string _phouseSize; 
        [XmlElement("Parkinghouse Size")]
        public string PhouseSize
        {
            get { return _phouseSize; }
            set { _phouseSize = value; }
        }
        private string _carSize;
        [XmlElement("Car Size")]
        public string CarSize
        {
            get { return _carSize; }
            set { _carSize = value; }
        }
        private string _mcSize;
        [XmlElement("MC Size")]
        public string MCSize
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
