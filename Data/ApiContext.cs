﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Npgsql;
using RockApi.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Models;
using Microsoft.Extensions.Configuration;

namespace RockApi.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) 
            : base(options)
        {
        }

        public List<FPUser> GetAllUsers(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<FPUser>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getalluserdata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<FPUser>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<FPUser>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        // diff list type
        public List<HouseHold> GetAllHouseholds(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<HouseHold>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallhouseholddata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using(var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if(dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<HouseHold>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<HouseHold>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<BankAccount> GetAllBankAccounts(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<BankAccount>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallbankaccountdata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<BankAccount>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<BankAccount>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<History> GetAllBankAccountHistory(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<History>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallbankaccounthistory", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<History>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<History>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<Category> GetAllCategories(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<Category>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallcategorydata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<Category>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Category>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<CategoryItem> GetAllCategoryItems(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<CategoryItem>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallcategoryitemdata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<CategoryItem>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<CategoryItem>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<Invitation> GetAllInvitations(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<Invitation>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallinvitationdata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<Invitation>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Invitation>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<Notification> GetAllNotifications(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<Notification>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getallnotificationdata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<Notification>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Notification>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }

        public List<Transaction> GetAllTransactions(IConfiguration configuration)
        {
            var connString = new NpgsqlConnection(DataHelper.GetConnectionString(configuration));
            //var connString = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connString.Open();

            // diff list type
            var allHouseHolds = new List<Transaction>();
            //diff function name
            using (var cmd = new NpgsqlCommand("getalltransactiondata", connString))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        var serializedMyObjects = JsonConvert.SerializeObject(dataTable);

                        //diff list type
                        allHouseHolds.AddRange((List<Transaction>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Transaction>)));
                    }
                }
                connString.Close();
            }

            return allHouseHolds;
        }
    }
}
