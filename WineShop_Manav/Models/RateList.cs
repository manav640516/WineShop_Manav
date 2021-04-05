using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WineShop_Manav.Models
{
    public class RateList
    {
        public int ID { get; set; }
        public string Price { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
