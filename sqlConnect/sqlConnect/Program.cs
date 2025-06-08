using MySql.Data.MySqlClient;
using sqlConnect.DAL;
using sqlConnect.Factory;
using sqlConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sqlConnect.AgentManager;
namespace sqlConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgentDal dal = new AgentDal();
            UpdateAgentMenu();
            //start(5);
            //DeleteAgentsByRange(10,13);
            //dal.PrintAgentList(dal.GetAllAgents());
            //PrintStatusCounts();
        }
    }
}
