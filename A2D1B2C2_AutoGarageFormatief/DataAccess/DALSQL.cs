using A2D1B2C2_AutoGarageFormatief.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.DataAccess
{
    /// <summary>
    /// Data access layer for SQL
    /// </summary>
    public class DALSQL
    {
        /// <summary>
        /// Servername
        /// </summary>
        private readonly string serverName;
        /// <summary>
        /// Databasename
        /// </summary>
        private readonly string databaseName;
        /// <summary>
        /// The generated connection string
        /// </summary>
        /// <returns></returns>
        private string ConnectionString() => $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";

        /// <summary>
        /// default constructor
        /// </summary>
        public DALSQL()
        {
            serverName = ".";
            databaseName = "A2D1B2C2_AutoGarageFormatief";
        }

        public List<CarOwner> ReadOwners()
        {
            List<CarOwner> Owners = new List<CarOwner>();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = ConnectionString();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = $"select id, name from carowner";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // will only iterate once but will prevent error when no results
                        while (reader.Read())
                        {
                            // prevent null reference warnings
                            var idString = reader[0].ToString() ?? "0";
                            var nameString = reader[1].ToString() ?? string.Empty;

                            CarOwner newOwner = new CarOwner(int.Parse(idString), nameString);

                            // get vehicles
                            newOwner.Vehicles = GetVehicles(newOwner);

                            // add to list
                            Owners.Add(newOwner);
                        }
                    }
                    connection.Close();
                }
            }
            return Owners;
        }

        public List<Vehicle> GetVehicles(CarOwner carOwner)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = ConnectionString();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = $"select id, description, LicensePlate, TowingWeight from vehicle where carownerid = @ownerid";
                    command.Parameters.AddWithValue("@ownerid", carOwner.Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // prevent null reference warnings
                            var idString = reader[0].ToString() ?? "0";
                            var descriptionString = reader[1].ToString() ?? string.Empty;
                            var licensePlateString = reader[2].ToString() ?? string.Empty;
                            var towingWeigtString = reader[3].ToString() ?? string.Empty;

                            Vehicle newVehicle;
                            if (String.IsNullOrEmpty(towingWeigtString))
                            {
                                newVehicle = new Vehicle(Int32.Parse(idString), licensePlateString, carOwner);
                            }
                            else
                            {
                                newVehicle = new CommercialVehicle(Int32.Parse(idString), licensePlateString, Int32.Parse(towingWeigtString), carOwner);
                            }
                            newVehicle.Description = descriptionString;
                            vehicles.Add(newVehicle);
                        }
                    }
                    return vehicles;
                }
            }
        }
    }
}
