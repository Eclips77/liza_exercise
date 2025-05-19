using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAnalyze
{
    public abstract class ThreatDictionary
    {
        private List<string> Keywords;



        public void AddKeyword(string _keyword)
        {
            this.Keywords.Add(_keyword);
        }

        public void RemoveKeyword(string _keyword)
        {
            this.Keywords.Remove(_keyword);
        }

        public List<string> GetAllKeywords()
        {
            return this.Keywords;
        }

        public bool IsThreat(string _message)
        {
            bool result = false;
            foreach (string word in this.Keywords)
            {
                if (_message.Contains(word))
                    result = true;
                
            }
            return result;
        
        }
    }
}
