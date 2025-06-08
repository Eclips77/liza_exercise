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

        public static void UpdateAgentMenu()
        {
            Console.Write("Enter Agent ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose what to update:");
            Console.WriteLine("1. Location");
            Console.WriteLine("2. Status");
            Console.WriteLine("3. MissionCompleted");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            string column = "";
            object value;

            switch (choice)
            {
                case 1:
                    column = "location";
                    Console.Write("Enter new location: ");
                    value = Console.ReadLine();
                    break;

                case 2:
                    column = "status";
                    Console.WriteLine("Choose status:");
                    Console.WriteLine("1. Active\n2. Injured\n3. Missing\n4. Retired");
                    int statusChoice = int.Parse(Console.ReadLine());
                    string[] statuses = { "Active", "Injured", "Missing", "Retired" };
                    if (statusChoice < 1 || statusChoice > 4)
                    {
                        Console.WriteLine("Invalid status choice.");
                        return;
                    }
                    value = statuses[statusChoice - 1];
                    column = "Status";
                    break;

                case 3:
                    column = "missionCompleted";
                    Console.Write("Enter new mission count: ");
                    value = int.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            agentDal.UpdateAgentField(id, column, value);
            Console.WriteLine("Agent updated successfully.");
        }

    }
}
