using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class RSSIValue
    {
        public int Id {get; set;}
        public string Bssid {get; set;}
        public string Signal_level {get; set;}

        public string Signal {get; set;}
        public string SSID {get; set;}

        public string WPA_AUTH {get; set;}

        public string WPA_CIPHER {get; set;}

        //public string enc_passwd {get; set;}

    }
}