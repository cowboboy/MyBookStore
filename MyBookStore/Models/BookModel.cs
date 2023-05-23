using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyBookStore.Models
{
    public class BookModel
    {
        [DisplayName("Id")]
        public int BookId { get; set; }
        [DisplayName("Название")]
        public string Title { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Жанр")]
        public string Category { get; set; }
        [DisplayName("Автор")]
        public string Author { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
        [DisplayName("В наличии")]
        public int Quantity { get; set; }
    }
}
