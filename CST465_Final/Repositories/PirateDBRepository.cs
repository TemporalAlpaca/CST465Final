using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using CST465_Final;
using CST465_Final.Models;
using Microsoft.Extensions.Configuration;

namespace Assignment1.Repositories
{
    public class PirateDBRepository : IPirateRepository
    {
        public string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Startup>();

            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("CST465Final_DB");

            return connectionString;
        }
        public void Delete(PirateModel pirate)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Pirates_Delete";
                command.Parameters.AddWithValue("@Id", pirate.id);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public List<PirateModel> GetPirates()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            DataSet ds = new DataSet("PirateList");
            List<PirateModel> PirateList = new List<PirateModel>();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Pirates_GetList";


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    PirateList.Add(new PirateModel(
                        (int)row["Id"],
                        (string)row["Name"],
                        (string)row["BeardColor"],
                        (string)row["CatchPhrase"],
                        (int)row["NumLegs"],
                        (bool)row["HasHat"],
                        (bool)row["HasEyepatch"]
                        ));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return PirateList;
        }

        public void Insert(PirateModel pirate)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Pirates_Insert";
                command.Parameters.AddWithValue("@Name", pirate.name);
                command.Parameters.AddWithValue("@BeardColor", pirate.beardColor);
                command.Parameters.AddWithValue("@CatchPhrase", pirate.catchPhrase);
                command.Parameters.AddWithValue("@HasHat", pirate.hasHat);
                command.Parameters.AddWithValue("@HasEyepatch", pirate.hasEyepatch);
                command.Parameters.AddWithValue("@NumLegs", pirate.numLegs);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
