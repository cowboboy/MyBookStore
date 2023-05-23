using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Views
{
    public interface IBookView
    {
        string Id { get; set; }
        string BookTitle { get; set; }
        string Description { get; set; }
        ref ComboBox Author { get; }
        ref ComboBox Category { get; }
        string Price { get; set; }
        int Quantity { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetBookListBindingSource(BindingSource bookList);
        void Show();
    }
}
