using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAnalyze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello world 123 ABC";
            Signal signal = new Signal(msg);
            string clean = signal.GetCleanMessage();
            Console.WriteLine(clean);
            Console.WriteLine(signal);
           

            
             
            
        }
    }
}
