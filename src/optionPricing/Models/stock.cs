using System.Collections.Generic;

namespace optionPricing.Models
{
    public class stock
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<option> options { get; set; }
        public double stockPrice { get; set; }


    }
}
