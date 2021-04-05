using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WineShop_Manav.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public int WineID { get; set; }
        public int RateListID { get; set; }
        public Wine Wine { get; set; }
        public RateList RateList { get; set; }
    }
}
