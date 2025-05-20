using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class WireStripper : Tool
    {

        public WireStripper(string name, int weight) : base(name, weight) 
        {
            this.Category = "Precision";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and strip it\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("WireStripper is removing insulation from wires.");
        }


    }
}
