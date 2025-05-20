using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer("hammer 1",12);
            Drill drill = new Drill("drill 1", 5);
            Saw saw = new Saw("saw 1", 3);
            Wrench wrench = new Wrench("wrench 1", 8);
            ScrewDriver screwDriver = new ScrewDriver("screw driver 1", 28);
            Pipecutter pipecutter = new Pipecutter("pipe cutter 1", 7);
            NailGun nailGun = new NailGun("nail gun 1", 50);
            WireStripper wirestripper = new WireStripper("Wire Stripper 1", 40);
            
            Tool[] tools = { hammer, drill, saw, wrench, pipecutter,nailGun,wirestripper };

            AllTools all = new AllTools();

            foreach (var tool in tools)
            {
                all.AddTool(tool);
            }
            all.SortByCategory();
            all.PrintAllTools();
        }
    }
}
