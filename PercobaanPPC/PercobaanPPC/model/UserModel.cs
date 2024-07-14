using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        private DatabaseConfig con;
        private string username;
        private string password;
        DataTable tmp;

        string query;

        public UserModel()
        {
            id = 0;
            name = String.Empty;
            username = String.Empty;
            password = String.Empty;

            con = new DatabaseConfig();
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


        public int save()
        {
            int result = -1;
            query = $"insert into user_tbl(name, password, username) values('{name}', '{password}', '{username}')";
            try
            {
                result = con.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menambahkan data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return result;
        }

        public int update()
        {
            int result = -1;
            query = $"update user_tbl set name = '{name}', username = '{username}',password = '{password}'where id={id}";

            try
            {
                result = con.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        public int delete(ulong id)
        {
            int result = -1;
            query = $"delete from user_tbl where id={id}";

            try
            {
                result = con.exec(query);
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
            string query = "SELECT id, name, username, password FROM user_tbl";

            return con.execQuery(query);
        }

        public bool login(string username, string password)
        {
            query = $"select id, name from user_tbl where username='{username}' and password='{password}'";
            try
            {
                tmp = con.execQuery(query);
                if (tmp.Rows.Count > 0)
                {
                    id = Convert.ToUInt64(tmp.Rows[0]["id"]);
                    name = tmp.Rows[0]["name"].ToString();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return false;
        }

        public DataTable findUserByName(string name)
        {
            query = $"select * from user_tbl where name like '%{name}%'";
            return tmp = con.execQuery(query);
        }
    }
}
