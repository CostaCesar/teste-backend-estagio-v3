using System;
using Npgsql;
using System.Threading.Tasks;
using System.Collections.Generic;

/*  CREATE DATABASE company
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace PgsqlAPI
{
    public class DatabaseHandler
    {
        string host;
        string username;
        string passwd;
        string database;
        static string cs = "Host=localhost;Username=postgres;Password=H4rd$tyl3;Database=company";
        private static NpgsqlConnection connection;

        public static void Start()
        {
            connection = new NpgsqlConnection(cs);
            connection.Open();
        }

        public static void AddEquipment(Equipment toAdd)
        {
            string sql = "INSERT INTO equipment (name, model_id) VALUES(@name, @model)";
            using(NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("model", toAdd.model);
                cmd.Parameters.AddWithValue("name", toAdd.name);
       
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Model> GetModels()
        {
            string sql = $"SELECT * FROM equipment_models";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    List<Model> output = new List<Model>();
                    while (reader.Read())
                    {
                        Model toAdd = new Model
                        {
                            id = (int)reader["id"],
                            name = (string)reader["name"]
                        };
                        output.Add(toAdd);
                    }
                    return output;
                }
            }
        }

        public string ExecuteCommand(string command)
        {
            string output = "";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand(command, con);
            if(command.Contains("SELECT"))
            {
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output += String.Format("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
                    output += Environment.NewLine;
                }
            }
            else
            {
                output = cmd.ExecuteNonQuery().ToString();
            }

            return output;
        }
    }
}
