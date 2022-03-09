using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DataAccess.Configurations
{
    //[Serializable]
    public class XML
    {
        private string _CZK;
        [XmlElement("Currency")]
        public string CZK
        {
            get { return _CZK; }
            set { _CZK = value; }
        }
        private double _mcPrice;
        [XmlElement("MC Price")]
        public double mPrice
        {
            get { return _mcPrice; }
            set { _mcPrice = value; }
        }
        private double _carPrice;
        [XmlElement("Car Price")]
        public double cPrice
        {
            get { return _carPrice; }
            set { _carPrice = value; }
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

    }


}
