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
    public class BookPresenter
    {
        private IBookView view;
        private IRepository repository;
        private BindingSource bookBindingSource;
        private IEnumerable<BookModel> bookList;

        public BookPresenter(IBookView view, IRepository repository)
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
            this.view.Show();
        }

        private void LoadAllBookList()
        {
            bookList = repository.GetAllBooks();
            bookBindingSource.DataSource = bookList;
        }
        private void SearchBook(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                bookList = repository.GetBookByValue(this.view.SearchValue);
            else bookList = repository.GetAllBooks();
            bookBindingSource.DataSource = bookList;
        }
        private void AddNewBook(object sender, EventArgs e)
        {
            foreach (var field in repository.GetAllCategories())
            {
                view.Category.Items.Add(field.ToStr());
            }
            foreach (var field in repository.GetAllAuthors())
            {
                view.Author.Items.Add(field.ToStr());
            }
            view.IsEdit = false;
        }
        private void LoadSelectedBookToEdit(object sender, EventArgs e)
        {
            var book = (BookModel)bookBindingSource.Current;
            view.Id = Convert.ToString(book.BookId);
            view.BookTitle = book.Title;
            view.Description = book.Description;

            view.Category.Items.Add(book.Category);
            view.Category.SelectedItem = book.Category;
            foreach (var field in repository.GetAllCategories())
            {
                if (field.ToStr() != book.Category)
                {
                    view.Category.Items.Add(field.ToStr());
                }
            }

            view.Author.Items.Add(book.Author);
            view.Author.SelectedItem = book.Author;
            foreach (var field in repository.GetAllAuthors())
            {
                if (field.ToStr() != book.Author)
                {
                    view.Author.Items.Add(field.ToStr());
                }
            }
            view.Price = book.Price.ToString();
            view.Quantity = book.Quantity;
            view.IsEdit = true;
        }
        private void SaveBook(object sender, EventArgs e)
        {
            var model = new BookModel();
            model.BookId = int.TryParse(view.Id, out _) ? Convert.ToInt32(view.Id) : 0;
            model.Title = view.BookTitle;
            model.Description = view.Description;
            model.Category = (string)view.Category.SelectedItem;
            model.Author = (string)view.Author.SelectedItem;
            model.Price = int.TryParse(view.Price, out _) ? Convert.ToInt32(view.Price) : 0;
            model.Quantity = Convert.ToInt32(view.Quantity);
            try
            {
                if (repository.GetUser(UserData.user).IsAdmin)
                {
                    if (view.IsEdit)
                    {
                        repository.EditBook(model);
                        view.Message = "Книга изменена успешно";
                    }
                    else
                    {
                        repository.AddBook(model);
                        view.Message = "Книга добавлена успешно";
                    }
                    view.IsSuccessful = true;
                    LoadAllBookList();
                    CleanviewFields();
                }
                else
                {
                    view.Message = "Вы не администратор";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            
        }

        private void CleanviewFields()
        {
            view.BookTitle = "";
            view.Description = "";
            view.Price = "";
            view.Quantity = 0;
            view.Author.Items.Clear();
            view.Category.Items.Clear();
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
                    LoadAllBookList();
                    CleanviewFields();
                    return;
                }
                var book = (BookModel)bookBindingSource.Current;
                repository.DeleteBook(book.BookId);
                view.IsSuccessful = true;
                view.Message = "Книга удалена успешно";
                LoadAllBookList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ошибка. Книга не удалена";
            }
        }
        static BookPresenter instance;
        public static void CreateOnce(IBookView view, IRepository repository)
        {
            if (instance == null)
            {
                instance = new BookPresenter(view, repository);
            }
           instance.LoadAllBookList();
        }
    }
}
