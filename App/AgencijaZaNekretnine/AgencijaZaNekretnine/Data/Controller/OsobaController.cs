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
    class OsobaController
    {
        private static readonly string READ = "select * from Osoba where JMB=@JMB;";
        private static readonly string INSERT = "insert into Osoba (JMB,ime,prezime,brTelefona,pol,brPoste,adresa) " +
                                                "values (@JMB,@ime,@prezime,@brTelefona,@pol,@brPoste,@adresa);";
        private static readonly string READ_ALL = "select * from Osoba;";

        public static Osoba Read(string JMB)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Osoba osoba = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@JMB", JMB);
                reader = cmd.ExecuteReader();
                reader.Read();
                osoba = new Osoba()
                {
                    JMB = reader.GetString(0),
                    ime = reader.GetString(1),
                    prezime = reader.GetString(2),
                    brTelefona = reader.GetString(3),
                    pol = reader.GetBoolean(4),
                    brPoste = reader.GetString(5),
                    adresa = reader.GetString(6)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in OsobaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return osoba;
        }

        public static long Insert(Osoba obj)
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
                cmd.Parameters.AddWithValue("@ime", obj.ime);
                cmd.Parameters.AddWithValue("@prezime", obj.prezime);
                cmd.Parameters.AddWithValue("@brTelefona", obj.brTelefona);
                cmd.Parameters.AddWithValue("@pol", obj.pol);
                cmd.Parameters.AddWithValue("@brPoste", obj.brPoste);
                cmd.Parameters.AddWithValue("@adresa", obj.adresa);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in OsobaController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Osoba> ReadAll()
        {
            var result = new List<Osoba>();
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
                    result.Add(new Osoba()
                    {
                        JMB = reader.GetString(0),
                        ime = reader.GetString(1),
                        prezime = reader.GetString(2),
                        brTelefona = reader.GetString(3),
                        pol = reader.GetBoolean(4),
                        brPoste = reader.GetString(5),
                        adresa = reader.GetString(6)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in OsobaController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
