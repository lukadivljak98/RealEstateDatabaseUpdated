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
    class AgencijaController
    {
        private static readonly string READ = "select * from Agencija where idAgencija=@idAgencija;";
        private static readonly string INSERT = "insert into Agencija (idAgencija,Naziv,BrTelefona,Adresa,BrPoste) " +
                                                "values (@idAgencija,@naziv,@brTelefona,@adresa,@brPoste);";
        private static readonly string READ_ALL = "select * from Agencija;";

        public static Agencija Read(int idAgencija)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Agencija agencija = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                reader = cmd.ExecuteReader();
                reader.Read();
                agencija = new Agencija()
                {
                    idAgencija = reader.GetInt32(0),
                    naziv = reader.GetString(1),
                    brTelefona = reader.GetString(2),
                    adresa = reader.GetString(3),
                    brPoste = reader.GetString(4)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in AgencijaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return agencija;
        }

        public static long Insert(Agencija obj)
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
                cmd.Parameters.AddWithValue("@idAgencija", obj.idAgencija);
                cmd.Parameters.AddWithValue("@naziv", obj.naziv);
                cmd.Parameters.AddWithValue("@brTelefona", obj.brTelefona);
                cmd.Parameters.AddWithValue("@adresa", obj.adresa);
                cmd.Parameters.AddWithValue("@brPoste", obj.brPoste);    
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in AgencijaController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Agencija> ReadAll()
        {
            var result = new List<Agencija>();
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
                    result.Add(new Agencija()
                    {
                        idAgencija = reader.GetInt32(0),
                        naziv = reader.GetString(1),
                        brTelefona = reader.GetString(2),
                        adresa = reader.GetString(3),
                        brPoste = reader.GetString(4)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in AgencijaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
