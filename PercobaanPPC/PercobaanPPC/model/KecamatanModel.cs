using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PercobaanPPC.model
{
    internal class KecamatanModel
    {
        private ulong id;
        private string name;
        private DatabaseConfig con;

        string query;

        public KecamatanModel()
        {
            id = 0;
            name = String.Empty;

            con = new DatabaseConfig();
            query = String.Empty;
        }

        public ulong Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Nama
        {
            set { name = value; }
            get { return name; }
        }

        public int save()
        {
            int result = -1;
            string query = $"INSERT INTO kecamatan_tbl(name) VALUES('{name}')";

            try
            {
                result = con.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menyimpan data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}"); // Logging error
            }

            return result;
        }

        public int update()
        {
            int result = -1;
            query = $"update kecamatan_tbl set name = '{name}' where id={id}";

            try
            {
                Console.WriteLine($"Executing query: {query}"); // Logging query
                result = con.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}"); // Logging error
            }
            return result;
        }

        public int delete(ulong id)
        {
            int result = -1;
            query = $"delete from kecamatan_tbl where id={id}";

            try
            {
                result = con.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public DataTable getAll()
        {
            string query = "SELECT id, name FROM kecamatan_tbl";

            return con.execQuery(query);
        }

        public DataTable getKecamatanByName(string name)
        {
            query = $"select id, name from kecamatan_tbl where name like '%{name}%'";
            return con.execQuery(query);
        }
    }

}
