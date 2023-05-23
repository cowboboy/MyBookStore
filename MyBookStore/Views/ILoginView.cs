using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Views
{
    public interface ILoginView
    {
        string Nickname { get; set; }
        string Password { get; set; }
        string Message { get; set; }

        event EventHandler LoginEvent;
        event EventHandler ExitEvent;

        void Show();//Optional
        void Close();

        void DoExit();
        void DoLogin();
    }
}
