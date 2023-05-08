using APM_PiKPO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.Сontroller
{
    public abstract class ICLientSorter
    {
        public abstract List<Orders> getSortedOrdersByNameUp();
        public abstract List<Orders> getSortedOrdersByNameDown();

        public abstract List<Orders> getSortedOrdersByDateUp();
        public abstract List<Orders> getSortedOrdersByDateDown();

        public abstract List<Orders> getSortedOrdersByStatusUp();
        public abstract List<Orders> getSortedOrdersByStatusDown();

        public abstract List<Clients> getSortedClientsByNameUp();
        public abstract List<Clients> getSortedClientsByNameDown();

        public abstract List<Clients> getSortedClientsByDateUp();
        public abstract List<Clients> getSortedClientsByDateDown();

        public abstract List<Orders> getFilterOrdersByClient(string ID);
    }
}
