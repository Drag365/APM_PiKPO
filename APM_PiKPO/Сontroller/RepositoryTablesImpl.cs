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

        override public List<Clients> getClients()
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
                                    ID = rdr.GetInt32(0),
                                    FirstName = rdr.GetString(1),
                                    Surname = rdr.GetString(2),
                                    PhoneNumber = rdr.GetString(3),
                                    Mail = rdr.GetString(4),
                                    ProfileCreateDate = rdr.GetDateTime(5)
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

        override public List<Orders> getOrders()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id;", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Orders> orders = new List<Orders>();
                            while (rdr.Read())
                            {
                                string clientName = string.Format("{0} {1}", rdr.GetString(2), rdr.GetString(3));
                                orders.Add(new Orders
                                {
                                    ID = rdr.GetInt32(0),
                                    ClientId = rdr.GetInt32(1),
                                    ClientName = clientName,
                                    ServiceId = rdr.GetInt32(4),
                                    ServiceName = rdr.GetString(5),
                                    totalAmount = rdr.GetInt32(6),
                                    Date = rdr.GetDateTime(7),
                                    Status = rdr.GetString(8)
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

        override public List<Services> getServices()
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
                                    ServiceName = rdr.GetString(1),
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

        override public bool addClient(Clients client)
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
                        '{client.FirstName}',
                        '{client.Surname}',
                        '{client.PhoneNumber}',
                        '{client.Mail}',
                        '{client.ProfileCreateDate:yyyy-MM-dd}'
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

        override public bool deleteClient(int id)
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

        override public bool saveClient(Clients client)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    
                    using (var cmd = new SQLiteCommand($@"UPDATE clients 
SET
name = '{client.FirstName}',
surname = '{client.Surname}',
PhoneNumber = '{client.PhoneNumber}',
Mail = '{client.Mail}',
date_created = '{client.ProfileCreateDate:yyyy-MM-dd}'
WHERE id = {client.ID};", connection))
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

        override public bool saveOrder(Orders order)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand($@"UPDATE orders 
SET
clientId = '{order.ClientId}',
serviceId = '{order.ServiceId}',
orderDate = '{order.Date:yyyy-MM-dd}',
status = '{order.Status}',
totalAmount = '{order.totalAmount}'
WHERE id = {order.ID};", connection))
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

        override public bool saveService(Services service)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand($@"UPDATE services 
SET
name = '{service.ServiceName}',
description = '{service.Description}',
price = '{service.Price}'
WHERE id = {service.Id};", connection))
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

        override public bool addOrder(Orders order)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand($@"INSERT INTO orders (
                        clientId,
                        serviceId,
                       orderDate,
                       status,
                       totalAmount
                    )
                    VALUES (
                        '{order.ClientId}',
                        '{order.ServiceId}',
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

        override public bool deleteOrder(int id)
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

        

        override public bool addService(Services service)
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
                        '{service.ServiceName}',
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

        override public bool deleteService(int id)
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
