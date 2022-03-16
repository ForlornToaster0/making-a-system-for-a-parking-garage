using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Configurations
{
    public class XML
    {
        private int sizeX;
        private int sizeY;
        
        private string _CZK;
        [XmlElement("Currency")]
        public string CZK
        {
            get { return _CZK; }
            set { _CZK = value; }
        }
        private string _parkingPrice;
        [XmlElement("Parking Spot Price")]
        public string ParkingPrice
        {
            get { return _parkingPrice; }
            set { _parkingPrice = value; }
        }
        private string _sizePerLot;
        [XmlElement("Parking Spot Size")]
        public string SizePerLot
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
    }


}
