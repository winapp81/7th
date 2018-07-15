using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7th
{
    class ConsoleListControl
    {
        
        public static void List(string[] headers, IListable[] items)
        {
            int[] columnWidths = DisplayHeaders(headers);

            for(int i = 0; i < items.Length; i++)
            {
                string[] values = items[i].ColumnValues;
                DisplayItemRow(columnWidths, values);
            }

        }

        private static int[] DisplayHeaders(string[] headers)
        {
            //..
            //throw new NotImplementedException();
            int[] aaa = {1,2,5 };
            return aaa;
        }
        
        private static void DisplayItemRow(int[] columnWidths, string[] values)
        {
            //,,
        }
    }
}
