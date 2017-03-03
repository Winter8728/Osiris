using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Osiris.CloudWeb.Models
{
    public class UserInfo
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}