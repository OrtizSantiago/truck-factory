using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NissanApi.Models
{
     [Index(nameof(Code), IsUnique = true)]
    public class Property:BaseModel
    {
        public Property()
        {
            Name = string.Empty;
            Type = string.Empty;
            Code = string.Empty;
            Description = string.Empty;
        }

        [Required]
        public string Name { get; set; }
 
        [Required]
        public string Type { get; set; }
 
        [Required]
        public string Code { get; set; }

        public string Description { get; set; }
    }
}