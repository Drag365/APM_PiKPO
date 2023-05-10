using APM_PiKPO.Repository;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.DAL
{
    public class DataManagerImpl : IDataManager
    {
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
