using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbiblioo.Models
{
    public class Books
    {

        private Int32 book_id;
        private String book_name;
        private DateTime publishing_date;
        private String isbn;
        private String genre;
        private String synopsis;
        private String book_image;
        private String book_pdf;
        private String state;
        private Int32 clicks; 


        public Int32 Book_id { get; set; }
        public String Book_name { get; set; }
        public DateTime Publishing_date { get; set; }
        public String Isbn { get; set; }
        public String Genre { get; set; }
        public String Synopsis { get; set; }
        public String Book_image { get; set; }
        public String Book_pdf { get; set; }
        public String State { get; set; }
        public Int32 Clicks { get; set; }

        public void insert_book()
        {

        }

        public void save_book()
        {

        }

        public void delete_book()
        {

        }











    }
}
