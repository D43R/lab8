using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    [Serializable]
    class bus
    {
        public int routeNumber;
        public string driverName;
        public int busNumber;
        public bool busState; // 0 - на маршруте, 1 - в парке
        public string busStateString;
        public bus(int route, string dName, int busN, bool busS)
        {
            routeNumber = route;
            driverName = dName;
            busNumber = busN;
            busState = busS;
            if (busState)
            {
                busStateString = "В парке";
            }
            else busStateString = "На маршруте";
        }
        public int RouteNumber
        {
            get { return routeNumber; }
            set
            {
                if (value <= 0 || value > 1000)
                {

                }
                else
                {
                    routeNumber = value;
                }
            }
        }
        public int BusNumber
        {
            get { return busNumber; }
            set
            {
                if (value <= 0 || value > 1000)
                {

                }
                else
                {
                    busNumber = value;
                }
            }
        }
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }
        public bool BusState
        {

            set { busState = value; }
        }
        public string BusStateString
        {
            get { return busStateString; }
        }
        public static bool operator < (bus c1, bus c2)
        {
            if (c1.routeNumber < c2.routeNumber)
            {
                return true;
            }
            else if (c1.routeNumber == c2.routeNumber)
            {
                if (c1.busNumber < c2.routeNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
        public static bool operator >(bus c1, bus c2)
        {
            if (c1.routeNumber > c2.routeNumber)
            {
                return true;
            }
            else if (c1.routeNumber == c2.routeNumber)
            {
                if (c1.busNumber > c2.routeNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
        public static bool operator <=(bus c1, bus c2)
        {
            if (c1.routeNumber <= c2.routeNumber)
            {
                return true;
            }
            else if (c1.routeNumber == c2.routeNumber)
            {
                if (c1.busNumber <= c2.routeNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
        public static bool operator >=(bus c1, bus c2)
        {
            if (c1.routeNumber >= c2.routeNumber)
            {
                return true;
            }
            else if (c1.routeNumber == c2.routeNumber)
            {
                if (c1.busNumber >= c2.routeNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
        }
    }
}
