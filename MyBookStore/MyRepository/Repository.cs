using Microsoft.Data.Sqlite;
using MyBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.MyRepository
{
    public class Repository : IRepository
    {
        private string connectionString;
        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddBook(BookModel bookModel)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"INSERT INTO books (title, description, author, category, price, quantity) 
                                         VALUES (@title, @description, (SELECT author_id FROM authors WHERE name=@author), (SELECT category_id FROM categories WHERE name=@category), @price, @quantity)";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter titleParam = new SqliteParameter("@title", bookModel.Title);
                command.Parameters.Add(titleParam);
                SqliteParameter descriptionParam = new SqliteParameter("@description", bookModel.Description);
                command.Parameters.Add(descriptionParam);
                SqliteParameter authorParam = new SqliteParameter("@author", bookModel.Author);
                command.Parameters.Add(authorParam);
                SqliteParameter categoryParam = new SqliteParameter("@category", bookModel.Category);
                command.Parameters.Add(categoryParam);
                SqliteParameter priceParam = new SqliteParameter("@price", bookModel.Price);
                command.Parameters.Add(priceParam);
                SqliteParameter quantityParam = new SqliteParameter("@quantity", bookModel.Quantity);
                command.Parameters.Add(quantityParam);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteBook(int id)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = "DELETE FROM books WHERE book_id=@id";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@id", id);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }
        public void EditBook(BookModel bookModel)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"UPDATE books SET title=@title, description=@description, author=(SELECT author_id FROM authors WHERE name=@author), category=(SELECT category_id FROM categories WHERE name=@category), price=@price, quantity=@quantity 
                                         WHERE book_id=@id";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@id", bookModel.BookId.ToString());
                command.Parameters.Add(idParam);
                SqliteParameter titleParam = new SqliteParameter("@title", bookModel.Title);
                command.Parameters.Add(titleParam);
                SqliteParameter descriptionParam = new SqliteParameter("@description", bookModel.Description);
                command.Parameters.Add(descriptionParam);
                SqliteParameter authorParam = new SqliteParameter("@author", bookModel.Author);
                command.Parameters.Add(authorParam);
                SqliteParameter categoryParam = new SqliteParameter("@category", bookModel.Category);
                command.Parameters.Add(categoryParam);
                SqliteParameter quantityParam = new SqliteParameter("@quantity", bookModel.Quantity);
                command.Parameters.Add(quantityParam);
                SqliteParameter priceParam = new SqliteParameter("@price", bookModel.Price);
                command.Parameters.Add(priceParam);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            var bookList = new List<BookModel>();

            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"SELECT book_id, title, description, price, quantity,
                                         (SELECT name from authors WHERE author_id=author) AS author,
                                         (SELECT name from categories WHERE category_id=category) AS category
                                         FROM books ORDER BY book_id DESC";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var bookModel = new BookModel();
                            bookModel.BookId = Convert.ToInt32(reader["book_id"]);
                            bookModel.Title = reader["title"].ToString();
                            bookModel.Description = reader["description"].ToString();
                            bookModel.Author = reader["author"].ToString();
                            bookModel.Category = reader["category"].ToString();
                            bookModel.Price = Convert.ToInt32(reader["price"]);
                            bookModel.Quantity = Convert.ToInt32(reader["quantity"]);
                            bookList.Add(bookModel);
                        }
                    }
                }
            }
            return bookList;
        }

        public IEnumerable<BookModel> GetBookByValue(string value)
        {
            var bookList = new List<BookModel>();
            int bookId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"SELECT book_id, title, description, price, quantity,
                                         (SELECT name from authors WHERE author_id=author) AS author,
                                         (SELECT name from categories WHERE category_id=author) AS category FROM books"; ;
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var bookModel = new BookModel();
                            bookModel.BookId = Convert.ToInt32(reader["book_id"]);
                            bookModel.Title = reader["title"].ToString();
                            bookModel.Description = reader["description"].ToString();
                            bookModel.Author = reader["author"].ToString();
                            bookModel.Category = reader["category"].ToString();
                            bookModel.Price = Convert.ToInt32(reader["price"]);
                            bookModel.Quantity = Convert.ToInt32(reader["quantity"]);
                            if (bookModel.Title.Contains(value) || bookModel.BookId == bookId)
                            {
                                bookList.Add(bookModel);
                            }
                        }
                    }
                }
            }
            return bookList;
        }

        public void AddCategory(CategoryModel categoryModel)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"INSERT INTO categories (name) 
                                         VALUES (@name)";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter titleParam = new SqliteParameter("@name", categoryModel.CategoryName);
                command.Parameters.Add(titleParam);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteCategory(int id)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = "DELETE FROM categories WHERE category_id=@id";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@id", id);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }
        public void EditCategory(CategoryModel categoryModel)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"UPDATE categories SET name=@name 
                                         WHERE category_id=@id";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@id", categoryModel.CategoryId.ToString());
                command.Parameters.Add(idParam);
                SqliteParameter titleParam = new SqliteParameter("@name", categoryModel.CategoryName);
                command.Parameters.Add(titleParam);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAllCategories()
        {
            var bookList = new List<CategoryModel>();

            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"SELECT category_id, name
                                         FROM categories ORDER BY category_id DESC";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var categoryModel = new CategoryModel();
                            categoryModel.CategoryId = Convert.ToInt32(reader["category_id"]);
                            categoryModel.CategoryName = reader["name"].ToString();
                            bookList.Add(categoryModel);
                        }
                    }
                }
            }
            return bookList;
        }

        public IEnumerable<CategoryModel> GetCategoryByValue(string value)
        {
            var bookList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"SELECT category_id, name FROM categories";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var categoryModel = new CategoryModel();
                            categoryModel.CategoryId = Convert.ToInt32(reader["category_id"]);
                            categoryModel.CategoryName = reader["name"].ToString();
                            bookList.Add(categoryModel);
                            if (categoryModel.CategoryName.Contains(value) || categoryModel.CategoryId == categoryId)
                            {
                                bookList.Add(categoryModel);
                            }
                        }
                    }
                }
            }
            return bookList;
        }


        public void AddAuthor(AuthorModel authorModel)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"INSERT INTO authors (name) 
                                         VALUES (@name)";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter titleParam = new SqliteParameter("@name", authorModel.AuthorName);
                command.Parameters.Add(titleParam);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteAuthor(int id)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = "DELETE FROM authors WHERE author_id=@id";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@id", id);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }
        public void EditAuthor(AuthorModel authorModel)
        {
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"UPDATE authors SET name=@name 
                                         WHERE author_id=@id";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@id", authorModel.AuthorId.ToString());
                command.Parameters.Add(idParam);
                SqliteParameter titleParam = new SqliteParameter("@name", authorModel.AuthorName);
                command.Parameters.Add(titleParam);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<AuthorModel> GetAllAuthors()
        {
            var authorList = new List<AuthorModel>();

            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"SELECT author_id, name
                                         FROM authors ORDER BY author_id DESC";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var authorModel = new AuthorModel();
                            authorModel.AuthorId = Convert.ToInt32(reader["author_id"]);
                            authorModel.AuthorName = reader["name"].ToString();
                            authorList.Add(authorModel);
                        }
                    }
                }
            }
            return authorList;
        }

        public IEnumerable<AuthorModel> GetAuthorByValue(string value)
        {
            var authorList = new List<AuthorModel>();
            int authorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = @"SELECT author_id, name FROM categories";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var authorModel = new AuthorModel();
                            authorModel.AuthorId = Convert.ToInt32(reader["author_id"]);
                            authorModel.AuthorName = reader["name"].ToString();
                            authorList.Add(authorModel);
                            if (authorModel.AuthorName.Contains(value) || authorModel.AuthorId == authorId)
                            {
                                authorList.Add(authorModel);
                            }
                        }
                    }
                }
            }
            return authorList;
        }

        public UserModel GetUser(UserModel userModel)
        {
            var newUserModel = new UserModel();
            using (var connection = new SqliteConnection($"Data Source={connectionString}"))
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM users WHERE name=@name AND password=@password";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                SqliteParameter idParam = new SqliteParameter("@name", userModel.Nickname);
                command.Parameters.Add(idParam);
                SqliteParameter titleParam = new SqliteParameter("@password", userModel.Password);
                command.Parameters.Add(titleParam);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            newUserModel.Nickname = reader["name"].ToString();
                            newUserModel.Password = reader["password"].ToString();
                            newUserModel.IsAdmin = Convert.ToBoolean(reader["is_admin"]);

                        }
                    }
                }
            }
            return newUserModel;
        }
    }
}
