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
    public partial class BookView : Form, IBookView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public BookView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(tabPageBookDetail);
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
                tabControl.TabPages.Remove(tabPageBookList);
                tabControl.TabPages.Add(tabPageBookDetail);
                tabPageBookDetail.Text = "Добавление книги";
            };
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageBookList);
                tabControl.TabPages.Add(tabPageBookDetail);
                tabPageBookDetail.Text = "Edit book";
            };
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl.TabPages.Remove(tabPageBookDetail);
                    tabControl.TabPages.Add(tabPageBookList);
                }
                MessageBox.Show(Message);
            };
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageBookDetail);
                tabControl.TabPages.Add(tabPageBookList);
            };
            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную книгу?", "Предупреждение",
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

        public string BookTitle
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }

        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public ref ComboBox Author
        {
            get { return ref comboBoxAuthor; }
        }

        public ref ComboBox Category
        {
            get { return ref comboBoxCategory; }
        }

        public string Price
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public int Quantity
        {
            get { return Convert.ToInt32(upDownQuantity.Value); }
            set { upDownQuantity.Value = Convert.ToDecimal(value); }
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

        private static BookView instance;
        public static BookView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BookView();
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
