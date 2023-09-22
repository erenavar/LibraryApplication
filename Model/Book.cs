using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Model
{

    public class Book
    {
        public int bookId { get; set; }

        private string bookName { get; set; }
        private string writer { get; set; }
        private string lang { get; set; }
        private string publisher { get; set; }
        private string genre { get; set; }
        private int amount { get; set; }

        public Book()
        {
            
        }

        public Book(int id,string bookName,string writer,string lang,string publisher,string genre,int amount)
        {
            this.bookId = id;
            this.bookName = bookName;
            this.writer = writer;
            this.lang = lang;
            this.publisher = publisher;
            this.genre = genre;
            this.amount = amount;
        }

        public int getBookId()
        {
            return this.bookId;
        }

        public string getBookName()
        {
            return this.bookName;
        }
        public string getWriter()
        {
            return this.writer;
        }
        public string getLang()
        {
            return this.lang;
        }
        public string getPublisher()
        {
            return this.publisher;
        }
        public string getGenre()
        {
            return this.genre;
        }

        public int getAmonut()
        {
            return this.amount;
        }



    }
}
