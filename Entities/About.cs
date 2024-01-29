using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class About:BaseModel
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string? Icon { get; set; }

    }
}
