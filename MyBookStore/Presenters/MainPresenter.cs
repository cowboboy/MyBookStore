using MyBookStore.MyRepository;
using MyBookStore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowBooksView += ShowBooksView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
            this.mainView.ShowAuthorsView += ShowAuthorsView;
            this.mainView.ShowLogin += ShowLogin;
            ShowBooksView(this, EventArgs.Empty);
        }

        private void ShowLogin(object sender, EventArgs e)
        {
            ILoginView view = LoginView.GetInstace((MainView)mainView);
            IRepository repository = new Repository(sqlConnectionString);
            LoginPresenter.CreateOnce(view, repository);
        }

        private void ShowBooksView(object sender, EventArgs e)
        {
            IBookView view = BookView.GetInstace((MainView)mainView);
            IRepository repository = new Repository(sqlConnectionString);
            BookPresenter.CreateOnce(view, repository);
        }

        private void ShowCategoriesView(object sender, EventArgs e)
        {
            ICategoryView view = CategoryView.GetInstace((MainView)mainView);
            IRepository repository = new Repository(sqlConnectionString);
            CategoryPresenter.CreateOnce(view, repository);
        }

        private void ShowAuthorsView(object sender, EventArgs e)
        {
            IAuthorView view = AuthorView.GetInstace((MainView)mainView);
            IRepository repository = new Repository(sqlConnectionString);
            AuthorPresenter.CreateOnce(view, repository);
        }
    }
}
