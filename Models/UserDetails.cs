using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfWebApp.Models
{
    class UserDetails
    {
        public int UserID { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
