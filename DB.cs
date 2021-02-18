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
    }
}
