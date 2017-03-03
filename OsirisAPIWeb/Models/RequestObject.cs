using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsirisAPIWeb.Models
{
    public class RequestObject
    { 
        public string username {get; set;}
        public string password { get; set; }
        public string deviceid { get; set; }
        public string actiontype { get; set; }
    }
}