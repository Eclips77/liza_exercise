using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class NailGun : Tool
    {

        public NailGun(string name, int weight) : base(name, weight)
        {
            this.Category = "Impcat";
        }

        public override void Describe()
        {
            Console.WriteLine($"Toll Name: {this.Name} Weight: {this.Weight} KG and Nail it.\n");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("NailGun is firing nails quickly into surfaces.");
        }
    }
}
