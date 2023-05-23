using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Views
{
    public interface IMainView
    {
        event EventHandler ShowBooksView;
        event EventHandler ShowAuthorsView;
        event EventHandler ShowCategoriesView;
        event EventHandler ShowLogin;
    }
}
