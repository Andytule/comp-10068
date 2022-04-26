using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced_.NET_Assignment_3.Models
{
    public class Provider : Person
    {
        [Required]
        public uint LicenseNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
