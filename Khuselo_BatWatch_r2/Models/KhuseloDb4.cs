using System;
using System.Collections.Generic;

namespace Khuselo_BatWatch_r2.Models
{
    public partial class KhuseloDb4
    {
        public int Serial { get; set; }
        public string Brand { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Branch { get; set; } = null!;
        public string? Price { get; set; }
        public string? Location { get; set; }
        public string? TechnName { get; set; }
        public string? TechCell { get; set; }
        public DateTime? DateExpired { get; set; }
        public DateTime? DateInstalled { get; set; }
        public string? ChargeCycles { get; set; }
    }
}
