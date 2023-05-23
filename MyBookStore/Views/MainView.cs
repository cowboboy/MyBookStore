using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookStore.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            buttonBooks.Click += delegate { ShowBooksView?.Invoke(this, EventArgs.Empty); };
            buttonAuthors.Click += delegate { ShowAuthorsView?.Invoke(this, EventArgs.Empty); };
            buttonCategories.Click += delegate { ShowCategoriesView?.Invoke(this, EventArgs.Empty); };
            buttonLogin.Click += delegate { ShowLogin?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowBooksView;
        public event EventHandler ShowAuthorsView;
        public event EventHandler ShowCategoriesView;
        public event EventHandler ShowLogin;
    }
}
