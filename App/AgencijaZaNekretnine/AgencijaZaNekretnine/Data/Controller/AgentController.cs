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
    class AgentController
    {
        private static readonly string READ = "select * from Agent where JMB=@JMB;";
        private static readonly string INSERT = "insert into Agent (JMB,Plata,idAgencija) " +
                                                "values (@JMB,@plata,@idAgencija);";
        private static readonly string READ_ALL = "select * from Agent;";

        public static Agent Read(string JMB)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Agent agent = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@JMB", JMB);
                reader = cmd.ExecuteReader();
                reader.Read();
                agent = new Agent()
                {
                    JMB = reader.GetString(0),
                    plata = reader.GetDouble(7),
                    idAgencija = reader.GetInt32(8)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in AgentController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return agent;
        }

        public static long Insert(Agent obj)
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
                cmd.Parameters.AddWithValue("@plata", obj.plata);
                cmd.Parameters.AddWithValue("@idAgencija", obj.idAgencija);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in AgentController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }

        public static List<Agent> ReadAll()
        {
            var result = new List<Agent>();
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
                    result.Add(new Agent()
                    {
                        JMB = reader.GetString(0),
                        plata = reader.GetDouble(7),
                        idAgencija = reader.GetInt32(8)
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in AgentController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
