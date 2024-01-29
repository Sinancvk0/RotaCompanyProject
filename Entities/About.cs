using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class About:BaseModel
    {
   
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public string? Icon { get; set; }

    }
}
