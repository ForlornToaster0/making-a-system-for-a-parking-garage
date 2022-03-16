﻿using System;
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
        private double _parkingPrice;
        [XmlElement("Parking Spot Price")]
        public double ParkingPrice
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

        internal void ChangePrice(int newPrice)
        {
            ParkingPrice = newPrice;
        }

    }


}
