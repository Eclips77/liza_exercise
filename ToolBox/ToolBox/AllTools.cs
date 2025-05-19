using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class AllTools
    {
        List<Tool> tools = new List<Tool>();        
        
        public void AddTool(Tool tooli)
        {
            tools.Add(tooli);
        }


        public void PrintAllTools()
        {
            foreach (Tool tool in tools)
            {
                tool.Describe();
                tool.Use();
                Console.WriteLine(tool.GetCategory());
                Console.WriteLine();
            }
        }

        public void SortByCategory()
        {
         tools = tools.OrderBy(tool => tool.GetCategory()).ToList();
        }
    }
}
