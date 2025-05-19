using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Wrench : Tool
    {

        public Wrench(string name, int weight) : base(name, weight)
        {
            this.Category = "Precision";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and miiu\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("Wrench is tightening or loosening bolts.");
        }


    }
}
