using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Pipecutter : Tool
    {

        public Pipecutter(string name, int weight) : base(name, weight)
        {
            this.Category = "Cutting";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and is using to cut pipes\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("PipeCutter is slicing through pipes cleanly.");
        }

    }
}
