using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advanced_.NET_Assignment_3.Models
{
    public class Organization : Entity
    {

        public enum OrganizationType
        {
            Hospital,
            Clinic,
            Pharmacy
        };

        [Required]
        [MaxLength(256)]    
        public string Name { get; set; }
        
        [Required] 
        public OrganizationType Type { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
