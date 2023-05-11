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
    class PosjetaController
    {
        private static readonly string READ = "select * from Posjeta where idPosjeta=@idPosjeta;";
        private static readonly string INSERT = "insert into Posjeta (idPosjeta,Datum,Klijent_JMB,Agent_JMB,idNekretnina) " +
                                                "values (@idAgencija,@datum,@klijentJMB,@agentJMB,@idNekretnina);";
        private static readonly string READ_ALL = "select * from Posjeta;";

        public static Posjeta Read(int idPosjeta)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Posjeta posjeta = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idPosjeta", idPosjeta);
                reader = cmd.ExecuteReader();
                reader.Read();
                posjeta = new Posjeta()
                {
                    idPosjeta = reader.GetInt32(0),
                    datum = reader.GetDateTime(1),
                    klijentJMB = reader.GetString(2),
                    agentJMB = reader.GetString(3),
                    idNekretnina = reader.GetInt32(4)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in PosjetaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return posjeta;
        }

        public static long Insert(Posjeta obj)
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
                cmd.Parameters.AddWithValue("@idPosjeta", obj.idPosjeta);
                cmd.Parameters.AddWithValue("@datum", obj.datum);
                cmd.Parameters.AddWithValue("@klijentJMB", obj.klijentJMB);
                cmd.Parameters.AddWithValue("@agentJMB", obj.agentJMB);
                cmd.Parameters.AddWithValue("@idNekretnina", obj.idNekretnina);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in PosjetaController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Posjeta> ReadAll()
        {
            var result = new List<Posjeta>();
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
                    result.Add(new Posjeta()
                    {
                        idPosjeta = reader.GetInt32(0),
                        datum = reader.GetDateTime(1),
                        klijentJMB = reader.GetString(2),
                        agentJMB = reader.GetString(3),
                        idNekretnina = reader.GetInt32(4)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in PosjetaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
