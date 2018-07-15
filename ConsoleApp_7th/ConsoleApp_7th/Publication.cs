using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7th
{
    class Publication : IListable
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Publication(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }

        public string[] ColumnValues
        {
            get
            {
                return new string[]
                {
                    this.Title,
                    this.Author,
                    this.Year.ToString()
                };
            }
        }//columnValues

        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "Title",
                    "Author",
                    "Year"
                };
            }
        }//Headers

    }// class publication
}
