using APM_PiKPO.DAL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.Repository
{
    public abstract class IRepositoryTables
    {
        public abstract List<Clients> GetClients();

        public abstract List<Orders> GetOrders();


        public abstract List<Services> GetServices();


        public abstract bool AddClient(Clients client);


        public abstract bool AddOrder(Orders order);


        public abstract bool AddService(Services service);


        public abstract bool DeleteClient(int id);


        public abstract bool DeleteOrder(int id);


        public abstract bool DeleteService(int id);


        public abstract bool SaveClient(Clients client);


        public abstract bool SaveOrder(Orders order);


        public abstract bool SaveService(Services service);
    }
}
