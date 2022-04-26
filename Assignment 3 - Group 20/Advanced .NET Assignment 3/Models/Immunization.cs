using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advanced_.NET_Assignment_3.Models
{
    public class Immunization:Entity
    {
        [Required]
        [StringLength(128)]
        public string OfficialName { get; set; }
        
        [StringLength(128)]
        public string TradeName { get; set; }

        [Required]
        [StringLength(255)]
        public string LotNumber { get; set; }

        [Required]
        public DateTimeOffset ExpirationDate { get; set; }

        public DateTimeOffset UpdatedTime { get; set; }
    }
}
