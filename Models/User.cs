using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WpfWebApp.Models
{
    class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
