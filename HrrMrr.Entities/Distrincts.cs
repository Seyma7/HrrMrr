using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrrMrr.Entities
{
    public class Distrincts
    {
        public int DistrinctId { get; set; }
        public string Name { get; set; }

        [Required]
        [ForeignKey("CityId")]
        public virtual Cities City { get; set; }
    }
}
