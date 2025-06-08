using Bogus;
using MySqlX.XDevAPI.CRUD;
using sqlConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
namespace sqlConnect.Factory
{
    internal class AgentFactory
    {
        private readonly Faker faker;
        public AgentFactory()
        {
            this.faker = new Faker();
        }

        public Agent CreateNewAgent()
        {
            string Codename = faker.Name.FirstName();
            string realName = faker.Name.FirstName();
            string location = faker.Address.City();
            string status = faker.PickRandom(new[] { "Active", "Injured", "Missing", "Retired" });
            int missionCompleted = faker.Random.Int(1, 10);

            return new Agent(Codename, realName, location, status, missionCompleted);
        }
    }
}
