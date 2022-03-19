using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class RssiDto
    {
        [Required] public int Id {get; set;}
        [Required] public string bssid {get; set;}
        [Required] public int signal_level {get; set;}
        [Required] public string ssid {get; set;}
        [Required] public int wpa_auth {get; set;}
        [Required] public int wpa_cipher {get; set;}
    }
}