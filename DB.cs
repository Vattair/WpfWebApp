using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWebApp.Data;
using WpfWebApp.Models;

namespace WpfWebApp
{
    class DB
    {
        public static void AddUser(string username, string firstname, string lastname)
        {
            using var context = new WebAppContext();

            UserDetails userDetails = new UserDetails() { FirstName = firstname, LastName = lastname };

            User user = new User() {
                UserName = username,
                UserDetails = userDetails
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
        public static void AddCategory(string name)
        {
            using var context = new WebAppContext();

            PostCategory postCategory = new PostCategory() { Category = name };
            context.PostCategory.Add(postCategory);
            context.SaveChanges();
        }
        public static void AddPost(int userid, int categoryid, string content)
        {
            using var context = new WebAppContext();

            Post post = new Post() { UserID = userid,CategoryID=categoryid,Content=content};
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
