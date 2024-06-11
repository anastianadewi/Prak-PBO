using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PercobaanPPC.model
{
    internal class UserModel
    {
        private ulong id;
        private string name;
        private string username;
        private string password;
        DatabaseConfig connection;
        DataTable tmp;

        string query;

        public UserModel()
        {
            id = 0;
            name = String.Empty;
            username = String.Empty;
            password = String.Empty;

            connection = new DatabaseConfig();
            tmp = new DataTable();
            query = String.Empty;
        }

        public ulong Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        int save()
        {
            int result = -1;
            query = $"insert into user_tbl(name, username, password) values('{name}', '{username}', '{password}')";
            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menyimpan data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return result;
        }

        int update()
        {
            int result = -1;
            query = $"update user_tbl set name = '{name}', username = '{username}',password = '{password}'where id={id}";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        int delete()
        {
            int result = -1;
            query = $"delete from user_tbl where id={id}";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        public DataTable getAll()
        {
            query = "select id, name, username from user_tbl";
            tmp = connection.execQuery(query);
            return tmp;
        }

        public bool login()
        {
            int result = -1;
            query = $"select id, name from user_tbl where username='{username}' and password='{password}'";
            try
            {
                int user = connection.exec(query);
                if(user < 0)
                {
                    throw new Exception("Username dan password tidak ditemukan");
                }
            }catch (Exception e)
            {
                Console.WriteLine (e.ToString());
            }
            return result == -1;
        }
    }
}
