using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advanced_.NET_Assignment_3.Models
{
    public abstract class Entity
    {
        [Required]
        public DateTimeOffset CreationTime { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Entity()
        {
            CreationTime = DateTimeOffset.Now;
        }
    }


}
