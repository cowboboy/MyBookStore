using MyBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.MyRepository
{
    public interface IRepository
    {
        void AddBook(BookModel bookModel);
        void EditBook(BookModel bookModel);
        void DeleteBook(int id);
        IEnumerable<BookModel> GetAllBooks();
        IEnumerable<BookModel> GetBookByValue(string value);//Searchs
        void AddCategory(CategoryModel categoryModel);
        void EditCategory(CategoryModel categoryModel);
        void DeleteCategory(int id);
        IEnumerable<CategoryModel> GetAllCategories();
        IEnumerable<CategoryModel> GetCategoryByValue(string value);//Searchs
        void AddAuthor(AuthorModel categoryModel);
        void EditAuthor(AuthorModel categoryModel);
        void DeleteAuthor(int id);
        IEnumerable<AuthorModel> GetAllAuthors();
        IEnumerable<AuthorModel> GetAuthorByValue(string value);//Searchs
        UserModel GetUser(UserModel userModel);
    }
}
