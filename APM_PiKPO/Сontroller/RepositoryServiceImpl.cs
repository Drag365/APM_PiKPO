using APM_PiKPO.DAL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.Сontroller
{
    public class RepositoryServiceImpl : IRepositoryService
    {
        override public List<Orders> getSortedOrdersByNameUp()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id ORDER BY c.surname ASC;", connection))
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

        override public List<Orders> getSortedOrdersByNameDown()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id ORDER BY c.surname DESC;", connection))
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

        override public List<Orders> getSortedOrdersByDateUp()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id ORDER BY o.orderDate ASC;", connection))
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
        override public List<Orders> getSortedOrdersByDateDown()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id ORDER BY o.orderDate DESC;", connection))
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

        override public List<Orders> getSortedOrdersByStatusUp()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id ORDER BY o.status ASC;", connection))
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
        override public List<Orders> getSortedOrdersByStatusDown()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id ORDER BY o.status DESC;", connection))
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

        override public List<Clients> getSortedClientsByNameUp()
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
  FROM clients ORDER BY surname ASC;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Clients> users = new List<Clients>();
                            while (rdr.Read())
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

        override public List<Clients> getSortedClientsByNameDown()
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
  FROM clients ORDER BY surname DESC;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Clients> users = new List<Clients>();
                            while (rdr.Read())
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

        override public List<Clients> getSortedClientsByDateUp()
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
  FROM clients ORDER BY date_created ASC;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Clients> users = new List<Clients>();
                            while (rdr.Read())
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
        override public List<Clients> getSortedClientsByDateDown()
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
  FROM clients ORDER BY date_created DESC;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Clients> users = new List<Clients>();
                            while (rdr.Read())
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

        override public List<Orders> getFilterOrdersByClient(string ID)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand($@"SELECT o.id, o.clientId, c.surname, c.name, o.serviceId, s.name, s.price, o.orderDate, o.status
FROM orders o 
JOIN clients c ON o.clientId = c.id
JOIN services s ON o.serviceId = s.id WHERE clientId = {ID};
", connection))
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

        override public List<Services> getSortedServicesByNameUp()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {

                    using (var cmd = new SQLiteCommand(@"SELECT Id,
       name,
       description,
       price
  FROM services ORDER BY name DESC;", connection))
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

        override public string getClientNumber(string ID)
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PhotoCenter.sqlite;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand($@"SELECT name,
       surname,
       PhoneNumber
  FROM clients WHERE id = {ID};

;
", connection))
                    {
                        connection.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            string clientsData = "";
                            while (rdr.Read())
                            {
                                clientsData = rdr.GetString(2) + " клиенту " + rdr.GetString(1) + " " + rdr.GetString(0);
                            }
                            return clientsData;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }
    }
}
