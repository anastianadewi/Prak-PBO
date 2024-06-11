using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercobaanPPC.model
{
    internal class RecapModel
    {
        private ulong id;
        private ulong kelurahan;
        private ulong penyakit;
        private ulong total;
        private DatabaseConfig con;
        private DataTable tmp;
        private string query;

        public RecapModel()
        {
            id = 0;
            kelurahan = 0;
            penyakit = 0;
            total = 0;
        }

        public ulong Id
        {
            get { return id; }
            set { id = value; }
        }

        public ulong Kelurahan
        {
            get { return kelurahan;}
            set { kelurahan = value;}
        }

        public ulong Penyakit
        {
            get { return penyakit;}
            set { penyakit = value;}
        }

        public ulong Total
        {
            get { return total; }
            set { total = value; }
        }

        int save()
        {
            int result = -1;
            query = $"insert into recap_tbl(kelurahan_id, penyakit_id, total) values ({kelurahan}, {penyakit}, {total})";

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
                Console.WriteLine(e.ToString());
            }
            return result;
        }


        int edit()
        {
            int result = -1;
            query = $"update recap_tbl set total = {total} where id={id}";

            try
            {
                result = con.exec(query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return result;
        }

        int delete()
        {
            int result = -1;
            query = $"delete from recap_tbl where id={id}";

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

        DataTable getAll()
        {
            query = $"select kecamatan.name, kelurahan.name, penyakit.name, recap.total from recap_tbl recap join kelurahan_tbl kelurahan on recap.kelurahan_id = kelurahan.id join kecamatan_tbl kecamatan on kelurahan.kecamatan_id = kecamatan.id join disease_tbl penyakit on recap.penyakit_id = penyakit.id order by recap.total";
            tmp = con.execQuery(query);
            return tmp;
        }
        DataTable getAllByKelurahan()
        {
            query = $"select kecamatan.name, kelurahan.name, penyakit.name, recap.total from recap_tbl recap join kelurahan_tbl kelurahan on recap.kelurahan_id = kelurahan.id join kecamatan_tbl kecamatan on kelurahan.kecamatan_id = kecamatan.id join disease_tbl penyakit on recap.penyakit_id = penyakit.id where recap.kelurahan_id={kelurahan} order by recap.total";
            tmp = con.execQuery(query);
            return tmp;
        }
        DataTable getAllByPenyakit()
        {
            query = $"select kecamatan.name, kelurahan.name, penyakit.name, recap.total from recap_tbl recap join kelurahan_tbl kelurahan on recap.kelurahan_id = kelurahan.id join kecamatan_tbl kecamatan on kelurahan.kecamatan_id = kecamatan.id join disease_tbl penyakit on recap.penyakit_id = penyakit.id where penyakit.id={penyakit} order by recap.total";
            tmp = con.execQuery(query);
            return tmp;
        }
    }
}
