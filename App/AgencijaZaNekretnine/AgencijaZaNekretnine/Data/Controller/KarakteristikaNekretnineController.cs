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
    class KarakteristikaNekretnineController
    {
        private static readonly string READ = "select * from KarakteristikaNekretnine where idKarakteristikaNekretnine=@idKarakteristikaNekretnine;";
        private static readonly string INSERT = "insert into KarakteristikaNekretnine (idKarakteristikaNekretnine,Naziv) " +
                                                "values (@idKarakteristikaNekretnine,@naziv);";
        private static readonly string READ_ALL = "select * from KarakteristikaNekretnine;";

        public static KarakteristikaNekretnine Read(int idKarakteristikaNekretnine)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            KarakteristikaNekretnine karakteristikaNekretnine = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idKarakteristikaNekretnine", idKarakteristikaNekretnine);
                reader = cmd.ExecuteReader();
                reader.Read();
                karakteristikaNekretnine = new KarakteristikaNekretnine()
                {
                    idKarakteristikaNekretnine = reader.GetInt32(0),
                    naziv = reader.GetString(1)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in KarakteristikaNekretnineController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return karakteristikaNekretnine;
        }

        public static long Insert(KarakteristikaNekretnine obj)
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
                cmd.Parameters.AddWithValue("@idKarakteristikaNekretnine", obj.idKarakteristikaNekretnine);
                cmd.Parameters.AddWithValue("@naziv", obj.naziv);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in KarakteristikaNekretnineController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<KarakteristikaNekretnine> ReadAll()
        {
            var result = new List<KarakteristikaNekretnine>();
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
                    result.Add(new KarakteristikaNekretnine()
                    {
                        idKarakteristikaNekretnine = reader.GetInt32(0),
                        naziv = reader.GetString(1)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in KarakteristikaNekretnineController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
