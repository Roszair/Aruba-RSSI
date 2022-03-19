using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Dto;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RssiController : ControllerBase
    {
        private readonly RSSIContext _context;
        

        public RssiController(RSSIContext context)
        {
            _context = context;         
        }

        [HttpGet]
        public async Task<ActionResult<List<RSSIValue>>> GetRssiValues()
        {
            return await _context.RSSIValues.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RSSIValue>> GetRssiValue(int id)
        {
            return await _context.RSSIValues.FindAsync(id);
        }

        [HttpPost("saveInfo")]
        public async Task<ActionResult<RSSIValue>> AddValues(string bssid, string signal_level, string signal, string ssid, string wpa_auth, string wpa_cipher)
        {
           


            var dataInfo = new RSSIValue
            {
               Bssid = bssid,
               Signal_level = signal_level,
               Signal = signal,
               SSID = ssid,
               WPA_AUTH = wpa_auth,
               WPA_CIPHER = wpa_cipher

            };

            _context.RSSIValues.Add(dataInfo);
            await _context.SaveChangesAsync();

            return dataInfo;
        }
    }
}