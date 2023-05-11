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
    class Nekretnine_ima_karakteristikaNekretnineController
    {
        private static readonly string READ = "select * from Nekretnina_ima_karakteristikaNekretnine where idNekretnina=@idNekretnina;";
        private static readonly string INSERT = "insert into Nekretnina_ima_karakteristikaNekretnine (Nekretnina_idNekretnina,KarakteristikaNekretnine_idKarakteristikaNekretnine,DodatniOpis) " +
                                                "values (@idNekretnina,@idKarakteristikaNekretnine,@dodatniOpis);";
        private static readonly string READ_ALL = "select * from Nekretnina_ima_karakteristikaNekretnine;";

        public static Nekretnina_ima_karakteristikaNekretnine Read(int idNekretnina)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Nekretnina_ima_karakteristikaNekretnine result = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idNekretnina", idNekretnina);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = new Nekretnina_ima_karakteristikaNekretnine()
                {
                    idNekretnina = reader.GetInt32(0),
                    idKarakteristikaNekretnine = reader.GetInt32(1),
                    dodatniOpis = reader.GetString(2)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Nekretnine_ima_karakteristikaNekretnineController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public static long Insert(Nekretnina_ima_karakteristikaNekretnine obj)
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
                cmd.Parameters.AddWithValue("@klijentJMB", obj.idNekretnina);
                cmd.Parameters.AddWithValue("@idKarakteristikaNekretnine", obj.idKarakteristikaNekretnine);
                cmd.Parameters.AddWithValue("@dodatniOpis", obj.dodatniOpis);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Nekretnine_ima_karakteristikaNekretnineController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Nekretnina_ima_karakteristikaNekretnine> ReadAll()
        {
            var result = new List<Nekretnina_ima_karakteristikaNekretnine>();
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
                    result.Add(new Nekretnina_ima_karakteristikaNekretnine()
                    {
                        idNekretnina = reader.GetInt32(0),
                        idKarakteristikaNekretnine = reader.GetInt32(1),
                        dodatniOpis = reader.GetString(2)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Nekretnine_ima_karakteristikaNekretnineController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
