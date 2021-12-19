using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrrMrr.Entities
{
    public class Cities
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public virtual List<Distrincts> Distrincts { get; set; }
    }
}
