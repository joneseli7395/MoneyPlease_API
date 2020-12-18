using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoneyPlease_API.Models;
using MoneyPlease_API.Utilities;
using Newtonsoft.Json;
using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace MoneyPlease_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        public List<Household> GetAllHouseholds(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allHouseholds = new List<Household>();

            using (var cmd = new NpgsqlCommand("getallhouseholds", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allHouseholds.AddRange((List<Household>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Household>)));
                    }
                }
                connString.Close();
            }
            return allHouseholds;
        }

        public List<FPUser> GetAllUsers(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allUsers = new List<FPUser>();

            using (var cmd = new NpgsqlCommand("getallusers", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allUsers.AddRange((List<FPUser>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<FPUser>)));
                    }
                }
                connString.Close();
            }
            return allUsers;
        }

        public List<Category> GetAllCategories(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allCategories = new List<Category>();

            using (var cmd = new NpgsqlCommand("getallcategories", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allCategories.AddRange((List<Category>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Category>)));
                    }
                }
                connString.Close();
            }
            return allCategories;
        }

        public List<CategoryItem> GetAllItems(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allItems = new List<CategoryItem>();

            using (var cmd = new NpgsqlCommand("getallcategoryitems", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allItems.AddRange((List<CategoryItem>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<CategoryItem>)));
                    }
                }
                connString.Close();
            }
            return allItems;
        }

        public List<BankAccount> GetAllAccounts(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allAccounts = new List<BankAccount>();

            using (var cmd = new NpgsqlCommand("getallaccounts", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allAccounts.AddRange((List<BankAccount>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<BankAccount>)));
                    }
                }
                connString.Close();
            }
            return allAccounts;
        }

        public List<Transaction> GetAllTransactions(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allTransactions = new List<Transaction>();

            using (var cmd = new NpgsqlCommand("getalltransactions", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allTransactions.AddRange((List<Transaction>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Transaction>)));
                    }
                }
                connString.Close();
            }
            return allTransactions;
        }

        public List<Notification> GetAllNotifications(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allNotifications = new List<Notification>();

            using (var cmd = new NpgsqlCommand("getallnotifications", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allNotifications.AddRange((List<Notification>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Notification>)));
                    }
                }
                connString.Close();
            }
            return allNotifications;
        }

        public List<Attachment> GetAllAttachments(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(ConnectionService.GetConnectionString(configuration));
            connString.Open();

            var allAttachments = new List<Attachment>();

            using (var cmd = new NpgsqlCommand("getallattachments", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);
                        allAttachments.AddRange((List<Attachment>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Attachment>)));
                    }
                }
                connString.Close();
            }
            return allAttachments;
        }

    }
}
