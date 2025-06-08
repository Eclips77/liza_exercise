using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using sqlConnect.Models;

namespace sqlConnect.DAL
{
    internal class AgentDal
    {
        private string connStr = "server=localhost;user=root;password=;database=eagleeyedb";
        private MySqlConnection _conn;

        public AgentDal()
        {
            try
            {
                OpenConnection();
                CloseConnection();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }
        public MySqlConnection OpenConnection()
        {
            if (this._conn == null)
            {
                this._conn = new MySqlConnection(connStr);
            }
            if (this._conn.State != System.Data.ConnectionState.Open)
            {
                this._conn.Open();
                Console.WriteLine("Connection successful.");
                //Console.Clear();
            }
            return this._conn;
        }
        public void CloseConnection()
        {
            if (this._conn != null && this._conn.State == System.Data.ConnectionState.Open)
            {
                this._conn.Close();
                this._conn = null;
            }
        }
        public List<Agent> GetAllAgents(string Where = "")
        {
            List<Agent> agents = new List<Agent>();
            string Query = "SELECT * FROM agents";
            Query += Where;
            try
            {
                OpenConnection();
                using (var cmd = new MySqlCommand(Query, this._conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32("id");
                        string CodeName = reader.GetString("codeName");
                        string RealName = reader.GetString("realName");
                        string Location = reader.GetString("location");
                        string Status = reader.GetString("status");
                        int MissionCompleted = reader.GetInt32("missionCompleted");
                        Agent agent = new Agent(CodeName, RealName, Location, Status, MissionCompleted);
                        agent.GetId(reader.GetInt32("id"));
                        agents.Add(agent);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching agents: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
      
            return agents;
        }
        public void PrintAgentList(List<Agent> agents)
        {
            foreach(Agent agent in agents)
            {
                Console.WriteLine(agent);
            }
        }
        public void AddAgent(Agent agent)
        {
            string query = $"INSERT INTO agents (codeName,realName,location,status,missionCompleted)" +
                    $"VALUES (@codeName, @realName, @location, @status, @missionCompleted)";
            try
            {
                OpenConnection();
                using(var cmd = new MySqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@codeName", agent.GetCodeName());
                    cmd.Parameters.AddWithValue("@realName",agent.GetRealName());
                    cmd.Parameters.AddWithValue("@location",agent.GetLocation());
                    cmd.Parameters.AddWithValue("@status",agent.GetStatus());
                    cmd.Parameters.AddWithValue("@missionCompleted",agent.GetMissionCompleted());
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("agent added successfully.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"sql error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }
        public void UpdateAgentField(int id,string field,object value)
        {
            string query = $"UPDATE agents SET {field} = @newValue WHERE id = @id";
            try
            {
                OpenConnection();
                using (var cmd = new MySqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@newValue", value);
                    int effected = cmd.ExecuteNonQuery();
                    if (effected > 0)
                        Console.WriteLine("Agent Updating successfully.");
                    else
                        Console.WriteLine("No agent found with that ID.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"sql error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }
        public void DeleteAgentById(int id)
        {
            string Query = "DELETE FROM agents WHERE id = @id";
            try
            {
                OpenConnection();
                using (var cmd = new MySqlCommand(Query, _conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int effected = cmd.ExecuteNonQuery();

                    if (effected > 0)
                        Console.WriteLine("Agent deleted successfully.");
                    else
                        Console.WriteLine("No agent found with that ID.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"sql error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }
        public List<Agent> GetAgentByCodeName(string codeName)
        {
            return GetAllAgents($"WHERE codeName LIKE '%{codeName}%'");
        }
    }
}
