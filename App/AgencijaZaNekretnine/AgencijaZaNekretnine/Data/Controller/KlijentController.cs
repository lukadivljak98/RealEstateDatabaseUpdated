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
    class KlijentController
    {
        private static readonly string READ = "select * from Klijent where JMB=@JMB;";
        private static readonly string INSERT = "insert into Klijent (JMB) " +
                                                "values (@JMB);";
        private static readonly string READ_ALL = "select * from Klijent;";

        public static Klijent Read(string JMB)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Klijent klijent = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@JMB", JMB);
                reader = cmd.ExecuteReader();
                reader.Read();
                klijent = new Klijent()
                {
                    JMB = reader.GetString(0),
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in KlijentController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return klijent;
        }

        public static long Insert(Klijent obj)
        {
            long id = 0;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@JMB", obj.JMB);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in KlijentController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Klijent> ReadAll()
        {
            var result = new List<Klijent>();
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
                    result.Add(new Klijent()
                    {
                        JMB = reader.GetString(0),
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in KlijentController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
