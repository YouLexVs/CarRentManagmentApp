using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace CarRentalApp
{
    public class SqliteDataAccess
    {
        public static List<CustomerModel> LoadCustomers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>("select * from Customers", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<CarModels> LoadCars()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CarModels>("select * from Cars", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customers (firstName, lastName, birthDate, currentCar) values (@FirstName, @LastName, @BirthDate, NULL)", customer);
            }
        }
        public static void SaveCar(CarModels car)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Cars (licensePlate, carModel, power, inRent) values (@LicensePlate, @CarModel, @Power, @InRent)", car);
            }
        }
        public static void UpdateCar(int carID, string action)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (action == "rent") {
                    cnn.Execute($"UPDATE Cars SET inRent = 1 WHERE id = {carID}");
                } else if(action == "free")
                {
                    cnn.Execute($"UPDATE Cars SET inRent = 0 WHERE id = {carID}");
                }
            }
        }
        public static void UpdateCustomer(int customerID, string licensePlate, string action)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if(action == "rent")
                {
                    cnn.Execute($"UPDATE Customers SET currentCar='{licensePlate}' WHERE id={customerID}");
                } else if (action == "free")
                {
                    cnn.Execute($"UPDATE Customers SET currentCar=NULL WHERE id={customerID}");
                }
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
