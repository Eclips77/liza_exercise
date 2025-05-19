using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Saw : Tool
    {

        public Saw(string name, int weight) : base(name, weight)
        {
            this.Category = "Cutting";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and i dont know what is it\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("Saw is cutting through material...\n");
        }


    }
}
