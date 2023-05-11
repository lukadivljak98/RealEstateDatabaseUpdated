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
    class NekretninaIznajmljivanjeController
    {
        private static readonly string READ = "select * from NekretninaIznajmljivanje where idNekretnina=@idNekretnina;";
        private static readonly string INSERT = "call SACUVAJ_NEKRETNINU_IZNAJMLJIVANJE_PROCEDURE(@idNekretnina,@predlozenaKirija,@slobodnoOd,@slobodnoDo,@jeIznajmljena)";//"insert into NekretninaIznajmljivanje (idNekretnina,PredlozenaKirija,SlobodnoOd,SlobodnoDo,jeIznajmljena) " +
                                                //"values (@idNekretnina,@predlozenaKirija,@slobodnoOd,@slobodnoDo,@jeIznajmljena);";
        private static readonly string READ_ALL = "SELECT * FROM nekretnine_database.view_lista_nekretnina;";

        public static NekretninaIznajmljivanje Read(int idNekretnina)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            NekretninaIznajmljivanje nekretninaIznajmljivanje = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idNekretnina", idNekretnina);
                reader = cmd.ExecuteReader();
               // reader.Read();
                if (reader.Read())
                {
                    nekretninaIznajmljivanje = new NekretninaIznajmljivanje()
                    {

                        idNekretnina = reader.GetInt32(0),
                        predlozenaKirija = reader.GetDouble(1),
                        slobodnoOd = reader.GetDateTime(2),
                        slobodnoDo = reader.GetDateTime(3),
                        jeIznajmljena = reader.GetBoolean(4)
                    };
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in NekretninaIznajmljivanjeController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return nekretninaIznajmljivanje;
        }

        public static long Insert(NekretninaIznajmljivanje obj)
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
                cmd.Parameters.AddWithValue("@idNekretnina", obj.idNekretnina);
                cmd.Parameters.AddWithValue("@predlozenaKirija", obj.predlozenaKirija);
                cmd.Parameters.AddWithValue("@slobodnoOd", obj.slobodnoOd);
                cmd.Parameters.AddWithValue("@slobodnoDo", obj.slobodnoDo);
                cmd.Parameters.AddWithValue("@jeIznajmljena", obj.jeIznajmljena);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in NekretninaIznajmljivanjeController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<NekretninaIznajmljivanje> ReadAll()
        {
            var result = new List<NekretninaIznajmljivanje>();
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
                    Nekretnina n = NekretninaController.Read(reader.GetInt32(0));
                    result.Add(new NekretninaIznajmljivanje()
                    {
                        idNekretnina = reader.GetInt32(0),
                        brPoste = n.brPoste,
                        adresa = n.adresa,
                        vlasnikJMB = n.vlasnikJMB,
                        predlozenaKirija = reader.GetDouble(4),
                        slobodnoOd = reader.GetDateTime(5),
                        slobodnoDo = reader.GetDateTime(6),
                        jeIznajmljena = reader.GetBoolean(7)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in NekretninaIznajmljivanjeController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
