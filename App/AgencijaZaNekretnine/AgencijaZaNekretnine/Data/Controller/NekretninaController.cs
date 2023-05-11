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
    class NekretninaController
    {
        private static readonly string READ = "select * from Nekretnina where idNekretnina=@idNekretnina;";
        private static readonly string INSERT =  "insert into Nekretnina (BrPoste,Adresa,Vlasnik_JMB) " +
                                                      "values (@brPoste,@adresa,@vlasnikJMB);";

        //"call SACUVAJ_NEKRETNINU_PROCEDURE(@idNekretnina,@brPoste,@adresa,@vlasnikJMB)";


        private static readonly string READ_ALL = "select * from Nekretnina;";

        public static Nekretnina Read(int idNekretnina)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Nekretnina nekretnina = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idNekretnina", idNekretnina);
                reader = cmd.ExecuteReader();
                //reader.Read();
                if (reader.Read())
                {
                    nekretnina = new Nekretnina()
                    {
                        idNekretnina = reader.GetInt32(0),
                        brPoste = reader.GetString(1),
                        adresa = reader.GetString(2),
                        vlasnikJMB = reader.GetString(3)
                    };
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in NekretninaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return nekretnina;
        }

        public static long Insert(Nekretnina obj)
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
                cmd.Parameters.AddWithValue("@brPoste", obj.brPoste);
                cmd.Parameters.AddWithValue("@adresa", obj.adresa);
                cmd.Parameters.AddWithValue("@vlasnikJMB", obj.vlasnikJMB);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in NekretninaController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Nekretnina> ReadAll()
        {
            var result = new List<Nekretnina>();
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
                    result.Add(new Nekretnina()
                    {
                        idNekretnina = reader.GetInt32(0),
                        brPoste = reader.GetString(1),
                        adresa = reader.GetString(2),
                        vlasnikJMB = reader.GetString(3)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in NekretninaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
