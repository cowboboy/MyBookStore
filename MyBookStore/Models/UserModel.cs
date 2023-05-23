using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
