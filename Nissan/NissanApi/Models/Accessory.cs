using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NissanApi.Models
{
    [Index(nameof(Code), IsUnique = true)]
    public class Accessory:BaseModel
    {
        
        public Accessory()
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = string.Empty;
            Code = string.Empty;
            Enabled = true;
            Required = true;
        }
        [Required]
        public string Name {get ; set ;}
        public string? Description {get ; set ;}
        public string? Image {get ; set ;}
        public string? Code {get ; set ;}
        [Required]
        public bool Enabled {get ; set ;}
        [Required]
        public bool Required {get ; set ;}
    }
}