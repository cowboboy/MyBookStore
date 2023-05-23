using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyBookStore.Models
{
    public class CategoryModel
    {
        [DisplayName("Id")]
        public int CategoryId { get; set; }
        [DisplayName("Название")]
        public string CategoryName { get; set; }

        public string ToStr()
        {
            return CategoryName;
        }
    }
}
