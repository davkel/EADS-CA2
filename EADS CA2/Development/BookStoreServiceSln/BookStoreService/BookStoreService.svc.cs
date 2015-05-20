using DBLib.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookStore
    {
        public static string connectionString = "Data Source=lc5n4dz5ls.database.windows.net;Initial Catalog=Library_DB;User ID=ProjectDB;Password=DT265sql";
        public SqlConnection connectDb = new SqlConnection(connectionString);
        BookStoreDB db = new BookStoreDB();

        public Book GetBook(int bookId)
        {
            Book book =new Book();

            if (bookId != null)
            {
                Book b = new Book();
                b = db.Books.FirstOrDefault(x => x.Book_ID == bookId);
                return b;
            }
            else
                return null;
        }

        /*public string GetBooksByAuthor(string author)
        {
            Book book = new Book();

            if (author != null)
            {
                Book b = new Book();
                String str;
                var m = db.Books.Where(x => x.Author == author).Select(n=>n.Title).ToString();
                return m;
            }
            else
                return null;
        }*/
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
