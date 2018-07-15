using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7th
{
    
    class Program
    {
        public static void Main()
        {
            Contact[] contacts = new Contact[2];
            contacts[0] = new Contact
            (
                "Dick", "Traci",
                "123 Main St., Spokane, WA 99037",
                "123-123-1234"
            );
            contacts[1] = new Contact
            (
                "Dick2", "Traci2",
                "222 Main St., Spokane, WA 99037",
                "222-123-1234"
            );

            ConsoleListControl.List(Contact.Headers, contacts);

            Console.WriteLine();

            Publication[] pubs = new Publication[3]
            {
                new Publication("Celebration of Displine", "Richard", 1978),
                new Publication("Celebration of 222", "Richard222", 1972),
                new Publication("Celebration of 333", "Richard333", 1973)
            };

            ConsoleListControl.List(Publication.Headers, pubs);

            
        } //Main
    }
}
