using System;

namespace optionPricing.Models
{
    public class option
    {
        public int optionId { get; set; }
        public DateTime maturity { get; set; }
        public double strikePrice { get; set; }
        public double currentPrice { get; set;  }
        public double delta { get; set; }
        public double gamma { get; set; }
        public double theta { get; set; }
        public double rho { get; set; }
        public double vega { get; set; }
        public int daysToOptionExpiration { get; set; }
        public bool call { get; set; }
        public bool put { get; set; }

    }
}