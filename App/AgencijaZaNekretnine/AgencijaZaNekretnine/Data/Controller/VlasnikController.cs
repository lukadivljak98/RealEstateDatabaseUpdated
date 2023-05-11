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
    class VlasnikController
    {
        private static readonly string READ = "select * from Vlasnik where JMB=@JMB;";
        private static readonly string INSERT = "insert into Vlasnik (JMB) " +
                                                "values (@JMB);";
        private static readonly string READ_ALL = "select * from Vlasnik;";

        public static Vlasnik Read(string JMB)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Vlasnik vlasnik = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@JMB", JMB);
                reader = cmd.ExecuteReader();
                reader.Read();
                vlasnik = new Vlasnik()
                {
                    JMB = reader.GetString(0),
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in VlasnikController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return vlasnik;
        }

        public static long Insert(Vlasnik obj)
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
                throw new DataAccessException("Exception in VlasnikController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Vlasnik> ReadAll()
        {
            var result = new List<Vlasnik>();
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
                    result.Add(new Vlasnik()
                    {
                        JMB = reader.GetString(0),
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in VlasnikController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
