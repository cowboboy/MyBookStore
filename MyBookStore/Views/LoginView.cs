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
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            buttonExit.Click += delegate { ExitEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string Nickname
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string Message
        {
            get { return errorLabel.Text; }
            set { errorLabel.Text = value; }
        }

        public event EventHandler LoginEvent;
        public event EventHandler ExitEvent;

        private static LoginView instance;

        public void DoExit()
        {
            panelExit.Visible = true;
            panelLogin.Visible = false;
            txtName.Text = "";
            txtPassword.Text = "";
        }

        public void DoLogin()
        {
            panelExit.Visible = false;
            panelLogin.Visible = true;
        }
        public static LoginView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginView();
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
