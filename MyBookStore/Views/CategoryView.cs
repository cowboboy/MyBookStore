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
    public partial class CategoryView : Form, ICategoryView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public CategoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(tabPageCategory);
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
                tabControl.TabPages.Remove(tabPageCategories);
                tabControl.TabPages.Add(tabPageCategory);
                tabPageCategory.Text = "Добавление жанра";
            };
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageCategories);
                tabControl.TabPages.Add(tabPageCategory);
                tabPageCategory.Text = "Изменение жанра";
            };
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl.TabPages.Remove(tabPageCategory);
                    tabControl.TabPages.Add(tabPageCategories);
                }
                MessageBox.Show(Message);
            };
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPageCategory);
                tabControl.TabPages.Add(tabPageCategories);
            };
            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный жанр?", "Предупреждение",
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
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }

        public string CategoryTitle
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
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

        private static CategoryView instance;
        public static CategoryView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoryView();
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
