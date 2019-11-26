using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А
{
    [Serializable]
    class bus
    {
        public int routeNumber;
        public string driverName;
        public int busNumber;
        public bool busState; // 0 - на маршруте, 1 - в парке
        public bus(int route, string dName, int busN, bool busS)
        {
            routeNumber = route;
            driverName = dName;
            busNumber = busN;
            busState = busS;
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
            get { return busState; }
            set { busState = value; }
        }
    }
}
