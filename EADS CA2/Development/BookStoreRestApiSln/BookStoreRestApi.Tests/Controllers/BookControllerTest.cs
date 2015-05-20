using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStoreRestApi;
using BookStoreRestApi.Controllers;
using DBLib.Entities;

namespace BookStoreRestApi.Tests.Controllers
{
    [TestClass]
    public class BookControllerTests
    {
        [TestMethod]
        public void GetAllBookTitles()
        {
            //Arrange
            BookController controller = new BookController();
            BookStoreDB db = new BookStoreDB();
            List<Book> Books = new List<Book>();
            Books = db.Books.ToList();
            int x = 0;
            

            

           

            //Act
            IEnumerable<string> result = controller.GetAllBookTitles();
            


            //Assert
            Assert.IsNotNull(result);
            foreach(Book b in Books)
            {
                
                Assert.AreEqual(b.Title, result.ElementAt(x));
                    x++;
            }
            
        }
    }
}
