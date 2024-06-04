using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public int BlogId { get; set; }
        public int TotalScore { get; set; }
        public int RatingCount { get; set; }

    }
}
