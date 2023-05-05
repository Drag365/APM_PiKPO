using APM_PiKPO.Repository;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.DAL
{
    public class RepositoryTablesImpl : IRepositoryTables
    {

        override public List<Clients> GetClients()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    
                    using (var cmd = new SQLiteCommand(@"SELECT id,
       name,
       surname,
       PhoneNumber,
       Mail,
       date_created
  FROM clients;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Clients> users = new List<Clients>();
                            while(rdr.Read())
                            {
                                users.Add(new Clients
                                {
                                    Id = rdr.GetInt32(0),
                                    Name = rdr.GetString(1),
                                    Surname = rdr.GetString(2),
                                    PhoneNumber = rdr.GetString(3),
                                    Mail = rdr.GetString(4),
                                    Date = rdr.GetDateTime(5)
                                });
                            }
                            return users;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        override public List<Orders> GetOrders()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand(@"SELECT id,
       clientId,
       orderDate,
       status,
       totalAmount
  FROM orders;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Orders> orders = new List<Orders>();
                            while (rdr.Read())
                            {
                                orders.Add(new Orders
                                {
                                    Id = rdr.GetInt32(0),
                                    //CliendId = rdr.GetInt32(1),
                                    Date = rdr.GetDateTime(2),
                                    Status = rdr.GetString(3),
                                    totalAmount = rdr.GetInt32(4),
                                    
                                });
                            }
                            return orders;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        override public List<Services> GetServices()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand(@"SELECT Id,
       name,
       description,
       price
  FROM services;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Services> services = new List<Services>();
                            while (rdr.Read())
                            {
                                services.Add(new Services
                                {
                                    Id = rdr.GetInt32(0),
                                    Name = rdr.GetString(1),
                                    Description = rdr.GetString(2),
                                    Price = rdr.GetInt32(3),

                                });
                            }
                            return services;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        override public bool AddClient(Clients client)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand($@"INSERT INTO clients (
                        name,
                        surname,
                        PhoneNumber,
                        Mail,
                        date_created
                    )
                    VALUES (
                        '{client.Name}',
                        '{client.Surname}',
                        '{client.PhoneNumber}',
                        '{client.Mail}',
                        '{client.Date:yyyy-MM-dd}'
                    );", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                            return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool DeleteClient(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    
                    using (var cmd = new SQLiteCommand($@"DELETE FROM clients  WHERE id = {id};", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool SaveClient(Clients client)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    
                    using (var cmd = new SQLiteCommand($@"UPDATE clients 
SET
name = '{client.Name}',
surname = '{client.Surname}',
PhoneNumber = '{client.PhoneNumber}',
Mail = '{client.Mail}',
date_created = '{client.Date:yyyy-MM-dd}'
WHERE id = {client.Id};", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool SaveOrder(Orders order)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand($@"UPDATE orders 
SET
orderDate = '{order.Date:yyyy-MM-dd}',
status = '{order.Status}',
totalAmount = '{order.totalAmount}'
WHERE id = {order.Id};", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool AddOrder(Orders order)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand($@"INSERT INTO orders (
                        clientId,
                       orderDate,
                       status,
                       totalAmount
                    )
                    VALUES (
                        '{order.Client}',
                        '{order.Date:yyyy-MM-dd}',
                        '{order.Status}',
                        '{order.totalAmount}'
                    );", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool DeleteOrder(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand($@"DELETE FROM orders  WHERE id = {id};", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        if (res > 0)
                            return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool SaveService(Services service)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand($@"UPDATE services 
SET
Id = '{service.Id}',
name = '{service.Name}',
description = '{service.Description}',
price = '{service.Price}'", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool AddService(Services service)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand($@"INSERT INTO services (
                         name,
                         description,
                         price
                     )
                    VALUES (
                        '{service.Name}',
                        '{service.Description}',
                        '{service.Price}'
                    );", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }

        override public bool DeleteService(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand($@"DELETE FROM services  WHERE id = {id};", connection))
                    {
                        connection.Open();
                        var res = cmd.ExecuteNonQuery();
                        if (res > 0)
                            return true;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
        }
    }

    
}
