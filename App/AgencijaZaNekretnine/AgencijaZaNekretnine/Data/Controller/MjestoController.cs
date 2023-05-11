using AgencijaZaNekretnine.Data.DataAccess;
using AgencijaZaNekretnine.Data.Exception;
using AgencijaZaNekretnine.Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Data.Controller
{
    class MjestoController
    {
        //CRUD
        private static readonly string INSERT = "";
        private static readonly string DELETE = "";
        private static readonly string UPDATE = "";
        private static readonly string READ = "";
        private static readonly string READ_ALL = "select * from Mjesto;";

        public static List<Mjesto> ReadAll()
        {
            var result = new List<Mjesto>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ_ALL;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Mjesto()
                    {
                        brPoste = reader.GetString(0),
                        naziv = reader.GetString(1)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in MjestoController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
