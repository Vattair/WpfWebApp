using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfWebApp.Models
{
    class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { get; set; }
        [ForeignKey("CategoryID")]
        [Required]
        public int CategoryID { get; set; }
        [ForeignKey("UserID")]
        [Required]
        public int UserID { get; set; }

        public string? Content { get; set; }

    }
}
