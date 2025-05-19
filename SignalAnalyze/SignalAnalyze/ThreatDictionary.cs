using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalAnalyze
{
    internal class ThreatDictionary
    {
        private List<string> Keywords = new List<string>();

        public ThreatDictionary()
        {
           this.Keywords = new List<string>();
        }


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


            return new List<string>(this.Keywords);
        }

        public bool IsThreat(string _message)
        {
            string[] words = _message.Split(' ');
            foreach (string word in words)
            {
                if (this.Keywords.Contains(word))
                    return  true;
                
            }
            return false;
        
        }
    }
}
