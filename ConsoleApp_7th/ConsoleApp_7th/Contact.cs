using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7th
{
    public class Contact : PdaItem, IListable  //반드시 클래스가 인터페이스 앞에
    {
        //public Contact()
        //{
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Contact(string fName, string lName, string address, string phone) : base(null)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Address = address;
            this.Phone = phone;
        }



        //string[] IListable.ColumnValues => throw new NotImplementedException();
        //public string[] ColumnValues => throw new NotImplementedException();
        public string[] ColumnValues
        {
            get
            {
                return new string[]
                    { FirstName,
                    LastName,
                    Phone,
                    Address
                    };
            }
        }

        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "First NAme", "Last Name      "  ,
                    "Phone         ",
                    "Address                  "
                };
            }
        }
    } // class Contact
}
