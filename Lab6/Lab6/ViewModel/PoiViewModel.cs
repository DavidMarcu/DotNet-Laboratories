using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.ViewModel
{
    public class PoiViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 50, ErrorMessage = "not valid length")]
        public String Name { get; private set; }

        [Required]
        [StringLength(150)]
        public string Description { get; private set; }
    }
}
