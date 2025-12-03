using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal  class Item
    {
        protected string name;
        protected string description;
        public string Name { get; set; }
        public string Description { get; set; }
        
        //public Item(string name, string description)
        //{
        //    this.name = name;
        //    this.description = description;
        //}
        public virtual void ShowInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
        }
        

        

        
        


    }
}
