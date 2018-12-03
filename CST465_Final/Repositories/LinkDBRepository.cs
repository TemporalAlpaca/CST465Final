using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using CST465_Final;
using CST465_Final.Repositories;
using Microsoft.Extensions.Configuration;

namespace Assignment1.Repositories
{
    public class LinkDBRepository : ILinkRepository
    {
        public string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<Startup>();

            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("CST465Final_DB");

            return connectionString;
        }

        public void Delete(LinkModel link)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Links_Delete";
                command.Parameters.AddWithValue("@Id", link.Id);

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

        public List<LinkModel> GetLinks()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            DataSet ds = new DataSet("LinkList");
            List<LinkModel> LinkList = new List<LinkModel>();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Links_GetList";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    LinkList.Add(new LinkModel(
                        (int)row["Id"],
                        (string)row["LinkAddress"],
                        (string)row["LinkName"],
                        (int)row["PLevel"]
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

            return LinkList;
        }

        public void Insert(LinkModel link)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Links_Insert";
                command.Parameters.AddWithValue("@LinkAddress", link.linkAddress);
                command.Parameters.AddWithValue("@LinkName", link.linkName);
                command.Parameters.AddWithValue("@PLevel", link.pLevel);

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
