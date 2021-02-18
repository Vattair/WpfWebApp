using System;
using System.Collections.Generic;
using System.Text;

namespace WpfWebApp.Models
{
    class Post
    {
        public int PostID { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

        public string Content { get; set; }

    }
}
