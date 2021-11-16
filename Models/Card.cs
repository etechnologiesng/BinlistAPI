using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinlistAPI.Models
{
    public class Card
    {
        public string Schema { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool isPrepaid { get; set; }
        public Bank Bank { get; set; }
        public Country Country { get; set; }
    }
}
