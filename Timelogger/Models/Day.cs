using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timelogger.Models
{
    public class Day
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
        // contains workItems
    }
}
