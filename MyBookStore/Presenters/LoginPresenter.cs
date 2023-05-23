using MyBookStore.Models;
using MyBookStore.MyRepository;
using MyBookStore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private IRepository repository;

        public LoginPresenter(ILoginView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.LoginEvent += Validate;
            this.view.ExitEvent += Exit;
            this.view.Show();
        }
        private void Exit(object sender, EventArgs e)
        {
            UserData.user = new UserModel();
            ((LoginView)this.view).DoLogin();
        }

        private void Validate(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            userModel.Nickname = this.view.Nickname;
            userModel.Password = this.view.Password;
            if (repository.GetUser(userModel).IsAdmin == true)
            {
                userModel.IsAdmin = true;
                UserData.user = userModel;
                ((LoginView)this.view).DoExit();
            }
            else
            {
                this.view.Message = "Неверный логин или пароль";
            }
        }
    }
}
