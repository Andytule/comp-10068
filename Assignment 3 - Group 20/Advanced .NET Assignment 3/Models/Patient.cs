using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced_.NET_Assignment_3.Models
{
    public class Patient : Person
    {
        [Required]
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
