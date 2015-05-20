using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStore;
using BookStore.Controllers;
using  BookStore.Models;

namespace BookStore.Tests.Controllers
{
    [TestClass]
    public class BookControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
                
            Assert.AreEqual("Index", result.ViewBag.Title);
        }

        public void Details()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;
            var book = (Book)result.ViewData.Model;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewBag.Title);
            Assert.AreEqual("1", book.Book_ID);

            

        }

        public void Search()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.Search("Lord of the Rings") as ViewResult;
            var book = (Book)result.ViewData.Model;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Search", result.ViewBag.Title);
            Assert.AreEqual("Lord of the Rings", book.Title);

        }

        public void Edit()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.Edit(1) as ViewResult;
            var book = (Book)result.ViewData.Model;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Edit", result.ViewBag.Title);
            Assert.AreEqual("1", book.Book_ID);


        }

        public void Delete()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Delete", result.ViewBag.Title);


        }

    }
}
