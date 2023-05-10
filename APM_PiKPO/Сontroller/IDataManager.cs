using APM_PiKPO.DAL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.Repository
{
    public abstract class IDataManager
    {

        public abstract bool addClient(Clients client);


        public abstract bool addOrder(Orders order);


        public abstract bool addService(Services service);


        public abstract bool deleteClient(int id);


        public abstract bool deleteOrder(int id);


        public abstract bool deleteService(int id);


        public abstract bool saveClient(Clients client);


        public abstract bool saveOrder(Orders order);


        public abstract bool saveService(Services service);

    }
}
