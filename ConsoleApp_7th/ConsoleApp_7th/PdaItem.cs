using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7th
{
    public abstract class PdaItem
    {
        public virtual string Name
        {
            get; set;
        }
        public PdaItem(string name)
        {
            this.Name = name;
        }

    } // base class pdaItem
}
