using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormAdatbazisAutok
{
    class Adatbazis
    {
        public MySqlConnection connection = null;
        public MySqlCommand cmd = null;

        public Adatbazis(string server = "localhost", string database = "autok", string userID = "root", string password = "")
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = server;
            sb.Database = database;
            sb.UserID = userID;
            sb.Password = password;
            connection = new MySqlConnection(sb.ConnectionString);
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nSikertelen kapcsolat felépítés\nA program leáll");
                Environment.Exit(0);
            }
        }

        public List<Auto> osszesAuto()
        {
            List<Auto> osszes = new List<Auto>();
            cmd.CommandText = "SELECT `id`, `rendszam`, `marka`, `forgalombaHelyezes` FROM `autok`;";
            try
            {
                connection.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Auto ujAuto = new Auto(dr.GetUInt64("id"), dr.GetString("rendszam"), dr.GetString("marka"), dr.GetDateTime("forgalombaHelyezes"));
                        osszes.Add(ujAuto);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nLista hiba\nA program leáll");
                Environment.Exit(0);
            }
            return osszes;
        }


        public void autoINSERT(Auto auto)
        {
            try
            {
                connection.Open();
                cmd.CommandText = $"INSERT INTO `autok`(`id`, `rendszam`, `marka`, `forgalombaHelyezes`) VALUES ('{auto.Id}','{auto.Rendszam}','{auto.Marka}','{auto.ForgalombaHelyezes.ToString("u")}');";
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);   
            }

        }


        public void autoUPDATE(Auto auto)        
        {
            try
            {
                connection.Open();
                cmd.CommandText = $"UPDATE `autok` SET `rendszam`='{auto.Rendszam}',`marka`='{auto.Marka}',`forgalombaHelyezes`='{auto.ForgalombaHelyezes.ToString("u")}' WHERE `id`='{auto.Id}';";
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void autoDELETE(Auto auto)
        
        {
            try
            {
                connection.Open();
                cmd.CommandText = $"DELETE FROM `autok` WHERE id = {auto.Id};";
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }





    }
}
