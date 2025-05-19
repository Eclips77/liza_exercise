using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class ScrewDriver : Tool
    {

        public ScrewDriver(string name, int weight) : base(name, weight)
        {
            this.Category = "Precision";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and is using to cut trees\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("Screwdriver is turning screws.");
        }


    }
}
