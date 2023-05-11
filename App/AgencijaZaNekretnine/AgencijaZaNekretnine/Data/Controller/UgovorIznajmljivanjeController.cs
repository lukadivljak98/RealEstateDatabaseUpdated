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
    class UgovorIznajmljivanjeController
    {
        private static readonly string READ = "select * from UgovorIznajmljivanje where idUgovorIznajmljivanje=@idUgovorIznajmljivanje;";
        private static readonly string INSERT = "insert into UgovorIznajmljivanje (Klijent_JMB,Agent_JMB,Kirija,Datum,Opis,Depozit,MinimalanPeriodIznajmljivanja,NekretninaIznajmljivanje_idNekretnina) " +
                                                "values (@klijentJMB,@agentJMB,@kirija,@datum,@opis,@depozit,@minimalanPeriodIznajmljivanja,@idNekretnina);";
        private static readonly string READ_ALL = "select * from UgovorIznajmljivanje;";

        public static UgovorIznajmljivanje Read(int idUgovorIznajmljivanje)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            UgovorIznajmljivanje ugovorIznajmljivanje = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idUgovorIznajmljivanje", idUgovorIznajmljivanje);
                reader = cmd.ExecuteReader();
                reader.Read();
                ugovorIznajmljivanje = new UgovorIznajmljivanje()
                {
                    idUgovorIznajmljivanje = reader.GetInt32(0),
                    klijentJMB = reader.GetString(1),
                    agentJMB = reader.GetString(2),
                    kirija = reader.GetDouble(3),
                    datum = reader.GetDateTime(4),
                    opis = reader.GetString(5),
                    depozit = reader.GetDouble(6),
                    minimalanPeriodIznajmljivanja = reader.GetInt32(7),
                    idNekretnina = reader.GetInt32(8)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in UgovorIznajmljivanjeController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return ugovorIznajmljivanje;
        }

        public static long Insert(UgovorIznajmljivanje obj)
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
                cmd.Parameters.AddWithValue("@klijentJMB", obj.klijentJMB);
                cmd.Parameters.AddWithValue("@agentJMB", obj.agentJMB);
                cmd.Parameters.AddWithValue("@kirija", obj.kirija);
                cmd.Parameters.AddWithValue("@datum", obj.datum);
                cmd.Parameters.AddWithValue("@opis", obj.opis);
                cmd.Parameters.AddWithValue("@depozit", obj.depozit);
                cmd.Parameters.AddWithValue("@minimalanPeriodIznajmljivanja", obj.minimalanPeriodIznajmljivanja);
                cmd.Parameters.AddWithValue("@idNekretnina", obj.idNekretnina);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in UgovorIznajmljivanjeController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<UgovorIznajmljivanje> ReadAll()
        {
            var result = new List<UgovorIznajmljivanje>();
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
                    result.Add(new UgovorIznajmljivanje()
                    {
                        idUgovorIznajmljivanje = reader.GetInt32(0),
                        klijentJMB = reader.GetString(1),
                        agentJMB = reader.GetString(2),
                        kirija = reader.GetDouble(3),
                        datum = reader.GetDateTime(4),
                        opis = reader.GetString(5),
                        depozit = reader.GetDouble(6),
                        minimalanPeriodIznajmljivanja = reader.GetInt32(7),
                        idNekretnina = reader.GetInt32(8)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in UgovorIznajmljivanjeController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
