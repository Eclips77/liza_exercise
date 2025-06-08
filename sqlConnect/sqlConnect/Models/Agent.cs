using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlConnect.Models
{
    internal class Agent
    {
        public int Id { get; private set; }
        private string CodeName;
        private string RealName;
        private string Location;
        private string Status;
        private int MissionCompleted;

        public Agent(string CD,string RN,string L,string S,int MC)
        {
            this.CodeName = CD;
            this.RealName = RN;
            this.Location = L;
            this.Status = S;
            this.MissionCompleted = MC;
        }
        public void GetId(int id)
        {
            Id = id;
        }
        public string GetCodeName() => CodeName;
        public string GetRealName() => RealName;
        public string GetLocation() => Location;
        public string GetStatus() => Status;
        public int GetMissionCompleted() => MissionCompleted;


        public override string ToString()
        {
            return$"id: {Id} \n" +
                $"CodeName: {CodeName} \n" +
                $"RealName: {RealName} \n" +
                $"Location: {Location} \n" +
                $"Status: {Status} \n" +
                $"MissionCompleted: {MissionCompleted}\n";
        }
    }
}
