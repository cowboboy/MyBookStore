using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyBookStore.Models
{
    public class AuthorModel
    {
        [DisplayName("Id")]
        public int AuthorId { get; set; }
        [DisplayName("Название")]
        public string AuthorName { get; set; }

        public string ToStr()
        {
            return AuthorName;
        }
    }
}
