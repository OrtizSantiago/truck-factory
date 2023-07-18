using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NissanApi.Models
{
    [Index(nameof(Code), IsUnique = true)]
    public class Pickup: BaseModel
    { 
        public Pickup()
        {
            Name = string.Empty;
            Description = string.Empty;
            Image = string.Empty;
            Code = string.Empty;
            MarketId = 0;
            Enabled = true;
        }
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string? Code { get; set; }

        [Required]
        public long MarketId { get; set; }

        [Required]
        public virtual PropertyValue? Market { get; set; }

        /*[Required]
        public long TrademarkId { get; set; }*/

        /*[Required]
        public virtual PropertyValue? Trademark { get; set; }*/

        [Required]
        public bool Enabled { get; set; }

    }
}