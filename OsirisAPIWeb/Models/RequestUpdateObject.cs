using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsirisAPIWeb.Models
{
    public class RequestUpdateObject
    {
        public string deviceid { get; set; }
        public string adid { get; set; }
        public Latlng latlng { get; set; }
        public Deviceinfo deviceinfo { get; set; }
    }

    public class Latlng
    {
        public string lng { get; set; }
        public string lat { get; set; }
    }

    public class Deviceinfo
    {
        public string lightness { get; set; }
        public string temperature { get; set; }
        public string on { get; set; }
        public string displayMode { get; set; }
        public string powerWaste { get; set; }
        public string isLock { get; set; }
        public string gyroscope { get; set; }

    }
}