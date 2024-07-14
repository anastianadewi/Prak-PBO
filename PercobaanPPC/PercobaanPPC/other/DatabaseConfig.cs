using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercobaanPPC.other
{
    internal class DatabaseConfig
    {
        NpgsqlCommand command;
        NpgsqlConnection conn;
        NpgsqlDataAdapter dataAdapter;

        public DatabaseConfig()
        {
            conn = new NpgsqlConnection(
                connectionString: "Host=ep-dark-leaf-a1s2g4rp-pooler.ap-southeast-1.aws.neon.tech;Username=project_owner;Password=lW52zwHkyxpT;Database=project;SSL Mode=require"
            );
            command = new NpgsqlCommand();
            dataAdapter = new NpgsqlDataAdapter();
        }

        void open()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        void close()
        {
            conn.Close();
        }

        public int exec(string query)
        {
            open();
            int result = -1;
            try
            {
                command.Connection = conn;
                command.CommandText = query;
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error executing query: {query}");
                Console.WriteLine(e.Message);
            }
            finally
            {
                close();
            }
            return result;
        }

        public DataTable execQuery(string query)
        {
            open();
            DataTable result = new DataTable();
            try
            {
                command.Connection = conn;
                command.CommandText = query;
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(result);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error executing query: {query}");
                Console.WriteLine(e.Message);
            }
            finally
            {
                close();
            }
            return result;
        }

    }
}
