using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NissanApi.Models
{
    public partial class BaseModel
    {
        public long Id { get; set; }
        [Required]
        public long CreatedAt { get; private set; }
        [Required]
        public long UpdatedAt { get; private set; }
        [Required]
        public bool Deleted { get; set; } = false;
        public int? CreatedUserID { get; set; }
        [ForeignKey("CreatedUserID")]
        [NotMapped]
        public virtual User? CreatedUser { get; set; }
        public int? UpdatedUserID { get; set; }
        [ForeignKey("UpdatedUserID")]
        [NotMapped]
        public virtual User? UpdatedUser{ get; set;}

    }
}