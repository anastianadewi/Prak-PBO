using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.Data;
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
        DatabaseConfig connection;
        DataTable tmp;

        string query;

        public KecamatanModel()
        {
            id = 0;
            name = String.Empty;

            connection = new DatabaseConfig();
            tmp = new DataTable();
            query = String.Empty;
        }

        public ulong Id
        {
            set { id = value; }
            get { return id; }
        }
        public ulong Nama
        {
            set { Nama = value; }
            get { return Nama; }
        }

        int save()
        {
            int result = -1;
            query = $"insert into kecamatan_tbl(name) values('{name}')";
            try
            {
                result = connection.exec(query);
                if(result < 0)
                {
                    throw new Exception("Gagal menyimpan data");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return result;
        }

        int update()
        {
            int result = -1;
            query = $"update kecamatan_tbl set name = '{name}' where id={id}";

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
            query = $"delete from kecamatan_tbl where id={id}";

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
            query = "select id, name from kecamatan_tbl";
            tmp = connection.execQuery(query);
            return tmp;
        }
    }

}
