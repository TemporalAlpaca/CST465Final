using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CST465_Final.Models;
using Microsoft.Extensions.Configuration;

namespace CST465_Final.Repositories
{
    public class PirateAnimalDBRepository : IPirateAnimalRepository
    {
        public string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Startup>();

            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("CST465Final_DB");

            return connectionString;
        }
        public void Delete(PirateAnimalModel pirateAnimal)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "PirateAnimals_Delete";
                command.Parameters.AddWithValue("@Id", pirateAnimal.id);

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

        public List<PirateAnimalModel> GetPirateAnimals()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            DataSet ds = new DataSet("PirateAnimalList");
            List<PirateAnimalModel> PirateAnimalList = new List<PirateAnimalModel>();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "PirateAnimals_GetList";


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    PirateAnimalList.Add(new PirateAnimalModel(
                        (int)row["Id"],
                        (string)row["Name"],
                        (string)row["AnimalType"],
                        (int)row["Age"],
                        (bool)row["SpeaksEnglish"]
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

            return PirateAnimalList;
        }

        public void Insert(PirateAnimalModel pirateAnimal)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "PirateAnimals_Insert";
                command.Parameters.AddWithValue("@Name", pirateAnimal.name);
                command.Parameters.AddWithValue("@AnimalType", pirateAnimal.animalType);
                command.Parameters.AddWithValue("@Age", pirateAnimal.age);
                command.Parameters.AddWithValue("@SpeaksEnglish", pirateAnimal.speaksEnglish);

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
