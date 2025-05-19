using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAnalyze
{
    internal class SignalAnalyzer
    {
        private ThreatDictionary threatDictionary;
        private List<Signal> interceptedSignals;

        public SignalAnalyzer(ThreatDictionary dictionary)
        {
            this.threatDictionary = dictionary;
            this.interceptedSignals = new List<Signal>();
        }
        public void AddSignal(Signal s)
        {
            this.interceptedSignals.Add(s);

        }

        public List<Signal> GetThreat()
        {
           List<Signal> threatsignals = new List<Signal>();
           foreach (Signal s in this.interceptedSignals)
            {
                if (threatDictionary.IsThreat(s.GetCleanMessage()))
                {
                    threatsignals.Add(s);
                }
            }
           return threatsignals;
        }

        public int CountThreatsPerHour()
        {
            Dictionary<int,int> counters = new Dictionary<int,int>();

        }
    }

   

}
