using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace NissanApi.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Code), IsUnique = true)]
    public class User:BaseModel
    {
        public User()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            Avatar = string.Empty;
            Code = string.Empty;
            //StatusId = 0;
            Administrative = false;
            Administrator = false;
            Operator = false;
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public string? Code { get; set; }
        //[Required]
        //public long StatusId { get; set; }
        
        //public virtual PropertyValue? Status { get; set; }
        [Required]
        public bool Administrative { get; set; }
        [Required]
        public bool Administrator { get; set; }
        [Required]
        public bool Operator { get; set; }
        public long? LastConnection { get; set; }

    }
}