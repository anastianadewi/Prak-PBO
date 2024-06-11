﻿using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercobaanPPC.model
{

    internal class PenyakitModel
    {
        private ulong id;
        private string name;
        private DatabaseConfig con;
        private string query;
        private DataTable tmp;

        public PenyakitModel(DatabaseConfig con)
        {
            this.con = con;
            id = 0;
            name = string.Empty;
        }

        public ulong Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        int save()
        {
            int result = -1;
            query = $"insert into disease_tbl(name) values('{name}')";
            try
            {
                result = con.exec(query);
                if(result < 0)
                {
                    throw new Exception("Gagal menambahkan data");
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
            query = $"update disease_tbl set name='{name}' where id={id}";
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
            query = $"delete from disease_tbl where id={id}";
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
                Console.WriteLine(e.ToString());
            }
            return result;
        }

        public DataTable getAll()
        {
            query = "select id, name from disease_tbl";
            tmp = con.execQuery(query);
            return tmp;
        }
    }
}
