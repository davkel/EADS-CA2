using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBLib.Entities;
using System.Data.SqlClient;
using System.Configuration;




namespace BookStoreRestApi.Controllers
{
    public class BookController : ApiController
    {

        BookStoreDB db = new BookStoreDB();
        
        //Method returns the title of every book  in the DB written after 1980 as XML
        public List <String> GetAllRecentBookTitles()
        {
            List<String> Titles = new List<String>();
            List<Book> Books = new List<Book>();
            Books = db.Books.ToList();

            foreach(Book b in Books)
            {
                if (b.Year >= 1980)
                {
                    Titles.Add(b.Title);
                }

            }
            if (Titles == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Titles; 

           
            
            
            
            
            
        }
    
    
    
    }
}
