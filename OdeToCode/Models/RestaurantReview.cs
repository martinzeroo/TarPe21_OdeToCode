using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToCode.Models
{
    public class RestaurantReview
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
    }
}