using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Tool
    {
        protected string Name;
        protected int Weight;
        protected string Category;
        protected int UseCount = 0;

        public Tool(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;

        }

        public virtual void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight}\n");
        }  
        public virtual void Use()
        {
            this.UseCount++;
        }
        public int GEtUseCount()
        {
            return this.UseCount;
        }
        public string GetCategory()
        {
            return this.Category;
        }


    }
}
