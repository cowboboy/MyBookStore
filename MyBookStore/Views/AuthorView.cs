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
    public partial class AuthorView : Form, IAuthorView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public AuthorView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(tabPageAuthor);
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageAuthors);
                tabControl.TabPages.Add(tabPageAuthor);
                tabPageAuthor.Text = "Добавление автора";
            };
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageAuthors);
                tabControl.TabPages.Add(tabPageAuthor);
                tabPageAuthor.Text = "Редактирование автора";
            };
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl.TabPages.Remove(tabPageAuthor);
                    tabControl.TabPages.Add(tabPageAuthors);
                }
                MessageBox.Show(Message);
            };
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageAuthor);
                tabControl.TabPages.Add(tabPageAuthors);
            };
            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного автора?", "Предупреждение",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string Id
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public string AuthorTitle
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool IsAdmin { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetBookListBindingSource(BindingSource bookList)
        {
            dataGridView.DataSource = bookList;
        }

        private static AuthorView instance;
        public static AuthorView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AuthorView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
