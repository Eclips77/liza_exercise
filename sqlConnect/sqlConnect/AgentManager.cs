using sqlConnect.DAL;
using sqlConnect.Factory;
using sqlConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sqlConnect
{
    static class AgentManager
    {
        static AgentFactory agentFactory = new AgentFactory();
        static AgentDal agentDal = new AgentDal();

        public static void start(int count)
        {
            for (int i = 0;i< count;i++)
            {
                Agent agent = agentFactory.CreateNewAgent();
                agentDal.AddAgent(agent);
            }  
        }
        public static void DeleteAgentsByRange(int start,int stop)
        {
            for (int i = start; i < stop; i++)
            {
                agentDal.DeleteAgentById(i);
            }
        }
        public static Dictionary<string, int> GetStatusCounts()
        {
            List<Agent> agents = agentDal.GetAllAgents();
            Dictionary<string, int> statusCounts = new Dictionary<string, int>();

            foreach (Agent agent in agents)
            {
                if (statusCounts.ContainsKey(agent.GetStatus()))
                    statusCounts[agent.GetStatus()]++;
                else
                    statusCounts[agent.GetStatus()] = 1;
            }
            return statusCounts;
        }
        public static void PrintStatusCounts()
        {
            Dictionary<string, int> statusCounts = GetStatusCounts();

            foreach (var entry in statusCounts)
            {
                Console.WriteLine($"There are {entry.Value} agents with status {entry.Key}.");
            }
        }
    }
}
