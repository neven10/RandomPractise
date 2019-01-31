using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD
{
    public class radnik
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public long maticni { get; set; }
        public int sektorid { get; set; }


    }

    public class tbl_sektor
    {
        public int id { get; set; }
        public string sektor { get; set; }
    }

    public static class Conn
    {
        public static string ConnectionString = "Server=localhost; Database=simple_crud;Uid=root;Pwd=battlefury;";
    }

    public enum EntityState
    {
        Unchanged,
        Added,
        Changed,
        Deleted
    }


}
