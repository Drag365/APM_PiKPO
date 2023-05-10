using APM_PiKPO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_PiKPO.Сontroller
{
    public abstract class IRepositoryService
    {

        public Dictionary<string, Func<List<Orders>>> _ordersSortingFunctions;
        public Dictionary<string, Func<List<Clients>>> _clientsSortingFunctions;
        public IRepositoryService()
        {
            _ordersSortingFunctions = new Dictionary<string, Func<List<Orders>>>
            {
                {"byNameUp", getSortedOrdersByNameUp},
                {"byNameDown", getSortedOrdersByNameDown},
                {"byDateUp", getSortedOrdersByDateUp},
                {"byDateDown", getSortedOrdersByDateDown},
                {"byStatusUp", getSortedOrdersByStatusUp},
                {"byStatusDown", getSortedOrdersByStatusDown},
            };

            _clientsSortingFunctions = new Dictionary<string, Func<List<Clients>>>
            {
                {"byNameUp", getSortedClientsByNameUp},
                {"byNameDown", getSortedClientsByNameDown},
                {"byDateUp", getSortedClientsByDateUp},
                {"byDateDown", getSortedClientsByDateDown},
            };
        }
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

        public abstract List<Services> getSortedServicesByNameUp();

        public abstract List<Orders> getFilterOrdersByClient(string ID);

        public abstract string getClientNumber(string ID);



    }
}
