using PercobaanPPC.other;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercobaanPPC.model
{
    internal class KelurahanModel
    {
        private ulong id;

        private string name;
        private ulong kecamatanId;
        private DatabaseConfig connection;
        private DataTable tmp;
        private string query;

        public KelurahanModel()
        {
            id = 0;
            name = String.Empty;
            kecamatanId = 0;

            connection = new DatabaseConfig();
            tmp = new DataTable();
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

        public ulong KecamatanId
        {
            set { kecamatanId = value; }
            get { return kecamatanId;}
        }

        public int save()
        {
            int result = -1;
            query = $"insert into kelurahan_tbl(name) values('{name}')";
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
                Console.WriteLine($"Error: {e.Message}"); // Logging error
            }

            return result;
        }

        public int update()
        {
            int result = -1;
            query = $"update kelurahan_tbl set name = '{name}' where id={id}";

            try
            {
                Console.WriteLine($"Executing query: {query}"); // Logging query
                result = connection.exec(query);
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
            query = $"delete from kelurahan_tbl where id={id}";

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

        public DataTable getKabupatenByKecamatanId()
        {
            query = $"select id, name from kelurahan_tbl where kecamatan_id = {kecamatanId}";
            tmp = connection.execQuery(query);
            return tmp;
        }
        public DataTable getAll()
        {
            query = "select id, name from kelurahan_tbl";
            return connection.execQuery(query);
        }

        public DataTable getKelurahanByName(string name)
        {
            query = $"select id, name from kelurahan_tbl where name like '%{name}%'";
            return connection.execQuery(query);
        }
    }
}
