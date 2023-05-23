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
    public class AuthorPresenter
    {
        private IAuthorView view;
        private IRepository repository;
        private BindingSource authorBindingSource;
        private IEnumerable<AuthorModel> authorList;

        public AuthorPresenter(IAuthorView view, IRepository repository)
        {
            this.authorBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchAuthor;
            this.view.AddNewEvent += AddNewAuthor;
            this.view.EditEvent += LoadSelectedAuthorToEdit;
            this.view.DeleteEvent += DeleteSelectedAuthor;
            this.view.SaveEvent += SaveAuthor;
            this.view.CancelEvent += CancelAction;
            this.view.SetBookListBindingSource(authorBindingSource);
            LoadAllAuthorList();
            this.view.Show();
        }

        private void LoadAllAuthorList()
        {
            authorList = repository.GetAllAuthors();
            authorBindingSource.DataSource = authorList;
        }
        private void SearchAuthor(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                authorList = repository.GetAuthorByValue(this.view.SearchValue);
            else authorList = repository.GetAllAuthors();
            authorBindingSource.DataSource = authorList;
        }
        private void AddNewAuthor(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedAuthorToEdit(object sender, EventArgs e)
        {
            var author = (AuthorModel)authorBindingSource.Current;
            view.Id = Convert.ToString(author.AuthorId);
            view.AuthorTitle = author.AuthorName;
            view.IsEdit = true;
        }
        private void SaveAuthor(object sender, EventArgs e)
        {
            var model = new AuthorModel();
            model.AuthorId = int.TryParse(view.Id, out _) ? Convert.ToInt32(view.Id) : 0;
            model.AuthorName = view.AuthorTitle;
            try
            {
                if (!repository.GetUser(UserData.user).IsAdmin)
                {
                    view.Message = "Вы не администратор";
                    LoadAllAuthorList();
                    CleanviewFields();
                    return;
                }
                if (view.IsEdit)
                {
                    repository.EditAuthor(model);
                    view.Message = "Автор изменен успешно";
                }
                else
                {
                    repository.AddAuthor(model);
                    view.Message = "Автор добавлен успешно";
                }
                view.IsSuccessful = true;
                LoadAllAuthorList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.AuthorTitle = "";
            view.Id = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedAuthor(object sender, EventArgs e)
        {
            try
            {
                if (!repository.GetUser(UserData.user).IsAdmin)
                {
                    view.Message = "Вы не администратор";
                    LoadAllAuthorList();
                    CleanviewFields();
                    return;
                }
                var author = (AuthorModel)authorBindingSource.Current;
                repository.DeleteAuthor(author.AuthorId);
                view.IsSuccessful = true;
                view.Message = "Автор удален успешно";
                LoadAllAuthorList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ошибка. Автор не удален";
            }
        }

        static AuthorPresenter instance;
        public static void CreateOnce(IAuthorView view, IRepository repository)
        {
            if (instance == null)
            {
                instance = new AuthorPresenter(view, repository);
            }
        }
    }
}
