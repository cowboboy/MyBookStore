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
    public class CategoryPresenter
    {
        private ICategoryView view;
        private IRepository repository;
        private BindingSource bookBindingSource;
        private IEnumerable<CategoryModel> bookList;

        public CategoryPresenter(ICategoryView view, IRepository repository)
        {
            this.bookBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchBook;
            this.view.AddNewEvent += AddNewBook;
            this.view.EditEvent += LoadSelectedBookToEdit;
            this.view.DeleteEvent += DeleteSelectedBook;
            this.view.SaveEvent += SaveBook;
            this.view.CancelEvent += CancelAction;
            this.view.SetBookListBindingSource(bookBindingSource);
            LoadAllCategoryList();
            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            bookList = repository.GetAllCategories();
            bookBindingSource.DataSource = bookList;
        }
        private void SearchBook(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                bookList = repository.GetCategoryByValue(this.view.SearchValue);
            else bookList = repository.GetAllCategories();
            bookBindingSource.DataSource = bookList;
        }
        private void AddNewBook(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedBookToEdit(object sender, EventArgs e)
        {
            var category = (CategoryModel)bookBindingSource.Current;
            view.Id = Convert.ToString(category.CategoryId);
            view.CategoryTitle = category.CategoryName;
            view.IsEdit = true;
        }
        private void SaveBook(object sender, EventArgs e)
        {
            var model = new CategoryModel();
            model.CategoryId = int.TryParse(view.Id, out _) ? Convert.ToInt32(view.Id) : 0;
            model.CategoryName = view.CategoryTitle;
            try
            {
                if (!repository.GetUser(UserData.user).IsAdmin)
                {
                    view.Message = "Вы не администратор";
                    LoadAllCategoryList();
                    CleanviewFields();
                    return;
                }
                if (view.IsEdit)
                {
                    repository.EditCategory(model);
                    view.Message = "Жанр иземенен успешно";
                }
                else 
                {
                    repository.AddCategory(model);
                    view.Message = "Жанр добавлен успешно";
                }
                view.IsSuccessful = true;
                LoadAllCategoryList();
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
            view.CategoryTitle = "";
            view.Id = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedBook(object sender, EventArgs e)
        {
            try
            {
                if (!repository.GetUser(UserData.user).IsAdmin)
                {
                    view.Message = "Вы не администратор";
                    LoadAllCategoryList();
                    CleanviewFields();
                    return;
                }
                var book = (BookModel)bookBindingSource.Current;
                repository.DeleteCategory(book.BookId);
                view.IsSuccessful = true;
                view.Message = "Жанр удален успешно";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ошибка. Жанр не удален";
            }
        }
    }
}
