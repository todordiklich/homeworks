using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Train
{
    class Destination
    {
        private string townName;
        private int time;
        private int passengersCount;

        public string TownName
        {
            get { return townName; }
            set { townName = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public int PassengersCount
        {
            get { return passengersCount; }
            set { passengersCount = value; }
        }
    }
}
