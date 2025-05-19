using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Drill : Tool
    {

        public Drill(string name, int weight) : base(name, weight)
        {
            this.Category = "Impact";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and i like it\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("Drill is drilling holes into materials.");
        }


    }
}
