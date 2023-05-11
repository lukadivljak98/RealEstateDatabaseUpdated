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
    class Klijent_zahtjeva_KarakteristikaNekretnineController
    {
        private static readonly string READ = "select * from Klijent_zahtjeva_karakteristikaNekretnine where klijentJMB=@klijentJMB;";
        private static readonly string INSERT = "insert into Klijent_zahtjeva_karakteristikaNekretnine (Klijent_JMB,KarakteristikaNekretnine_idKarakteristikaNekretnine,DodatniOpis) " +
                                                "values (@klijentJMB,@idKarakteristikaNekretnine,@dodatniOpis);";
        private static readonly string READ_ALL = "select * from Klijent_zahtjeva_karakteristikaNekretnine;";

        public static Klijent_zahtjeva_karakteristikaNekretnine Read(string klijentJMB)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Klijent_zahtjeva_karakteristikaNekretnine result = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@klijentJMB", klijentJMB);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = new Klijent_zahtjeva_karakteristikaNekretnine()
                {
                    klijentJMB = reader.GetInt32(0),
                    idKarakteristikaNekretnine = reader.GetInt32(1),
                    dodatniOpis = reader.GetString(2)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Klijent_zahtjeva_KarakteristikaNekretnineController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public static long Insert(Klijent_zahtjeva_karakteristikaNekretnine obj)
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
                cmd.Parameters.AddWithValue("@idKarakteristikaNekretnine", obj.idKarakteristikaNekretnine);
                cmd.Parameters.AddWithValue("@dodatniOpis", obj.dodatniOpis);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Klijent_zahtjeva_KarakteristikaNekretnineController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Klijent_zahtjeva_karakteristikaNekretnine> ReadAll()
        {
            var result = new List<Klijent_zahtjeva_karakteristikaNekretnine>();
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
                    result.Add(new Klijent_zahtjeva_karakteristikaNekretnine()
                    {
                        klijentJMB = reader.GetInt32(0),
                        idKarakteristikaNekretnine = reader.GetInt32(1),
                        dodatniOpis = reader.GetString(2)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Klijent_zahtjeva_KarakteristikaNekretnineController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
