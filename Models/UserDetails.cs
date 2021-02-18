using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfWebApp.Models
{
    class UserDetails
    {
        [Key]
        [ForeignKey("User")]
        [Required]
        public int UserID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}
