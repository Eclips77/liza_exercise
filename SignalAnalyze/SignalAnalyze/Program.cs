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
            ThreatDictionary dict = new ThreatDictionary();
            dict.AddKeyword("bomb");
            dict.AddKeyword("attack");
            dict.AddKeyword("explosive");

            Signal s1 = new Signal("There is a bomb");
            Signal s2 = new Signal("We are under attack");
            Signal s3 = new Signal("Let's meet at the cafe");

            SignalAnalyzer analyzer = new SignalAnalyzer(dict);
            analyzer.AddSignal(s1);
            analyzer.AddSignal(s2);
            analyzer.AddSignal(s3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

        }
    }
}
