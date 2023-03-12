using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaMart
{
    internal class Koneksidb
    {
        public static MySqlConnection getKonektionn()
        {
            MySqlConnection sambungankoneksi = null;

            try
            {
                string sConnstring = "server = localhost; database = db_zeamartbarang; uid=root; password=;";
                sambungankoneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return sambungankoneksi;
        }
    }
}
