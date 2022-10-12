using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToCode.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string Rating { get; set; }
        public string Body { get; set; }
        public string RestaurantId { get; set; }
    }
}