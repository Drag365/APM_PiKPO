using APM_PiKPO.DAL;
using APM_PiKPO.Repository;
using APM_PiKPO.Сontroller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APM_PiKPO
{
    public partial class PhotoCenterForm : Form
    {
        private List<Clients> _clientsList;
        private List<Orders> _ordersList;
        private List<Services> _servicesList;
        IDataManager dataManager;
        IRepositoryService repositoryService;
        private bool _newRow;
        private string who;
        string sorting = "byNameUp";
        string idSearchKey = "";
        public PhotoCenterForm()
        {
            InitializeComponent();
            who = "Clients";
            _clientsList = new List<Clients>();
            _ordersList = new List<Orders>();
            _servicesList = new List<Services>();
            dataManager = new DataManagerImpl();
            repositoryService = new RepositoryServiceImpl();
            bsUser.DataSource = _clientsList;
            dataGridView1.AutoGenerateColumns = true;
            clientsEdit1.Client = new Clients { ProfileCreateDate = DateTime.Now.Date };
            refreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            cbClientFilter.DataSource = repositoryService.getSortedClientsByNameUp();
            cbClientFilter.DisplayMember = "FullName";
            cbClientFilter.ValueMember = "ID";
            if (who == "Clients")
            {
                _clientsList.Clear();
                bsUser.DataSource = _clientsList;
                var sortingFunction = repositoryService._clientsSortingFunctions[sorting];
                List<Clients> list = sortingFunction();
                _clientsList.AddRange(list);
                bsUser.ResetBindings(false);
            }
            else if (who == "Orders")
            {
                _ordersList.Clear();
                bsUser.DataSource = _ordersList;
                List<Orders> list;
                if (sorting == "ID")
                {
                    list = repositoryService.getFilterOrdersByClient(idSearchKey);
                    _ordersList.AddRange(list);
                }
                else
                {
                    var sortingFunction = repositoryService._ordersSortingFunctions[sorting];
                    list = sortingFunction();
                    _ordersList.AddRange(list);
                }

                bsUser.ResetBindings(false);
            }

            else if (who == "Services")
            {
                _servicesList.Clear();
                bsUser.DataSource = _servicesList;
                List<Services> list = repositoryService.getSortedServicesByNameUp();
                _servicesList.AddRange(list);
                bsUser.ResetBindings(false);
            }

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (who == "Clients")
            {
                var client = (Clients)bsUser.Current;
                clientsEdit1.Client = client;
                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].Visible = false;
                }
                if (dataGridView1.Columns.Contains("FullName"))
                {
                    dataGridView1.Columns["FullName"].Visible = false;
                }
                
            }
            else  if (who == "Orders")
            {
                var order = (Orders)bsUser.Current;
                ordersEdit1.Order = order;
                if (dataGridView1.Columns.Contains("ServiceId"))
                {
                    dataGridView1.Columns["ServiceId"].Visible = false;
                }

            }
            else if (who == "Services")
            {
                var service = (Services)bsUser.Current;
                sevicesEdit1.Service = service;
                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            sorting = "byNameUp";
            SwitchViews(true, false, false, "Clients");
            
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            sorting = "byNameUp";
            SwitchViews(false, true, false, "Orders");
        }

        private void btnServices_CheckedChanged(object sender, EventArgs e)
        {
            SwitchViews(false, false, true, "Services");
        }

        private void SwitchViews(bool showClients, bool showOrders,  bool showServices, string who)
        {
            clientsEdit1.Visible = showClients;
            ordersEdit1.Visible = showOrders;
            sevicesEdit1.Visible = showServices;
            btnAddClient.Visible = showClients;
            btnAddOrder.Visible = showOrders;
            btnAddService.Visible = showServices;
            btnDelClient.Visible = showClients;
            btnDelOrder.Visible = showOrders;
            btnDelService.Visible = showServices;
            btnSaveClient.Visible = showClients;
            btnSaveOrder.Visible = showOrders;
            btnSaveService.Visible = showServices;
            btnClientsSortByName.Visible = showClients;
            btnSortByDate.Visible = showClients;
            btnSortByClients.Visible = showOrders;
            btnSortByDate.Visible = showOrders || showClients;
            btnSortByStatus.Visible = showOrders;
            btnSearch.Visible = showOrders;
            cbClientFilter.Visible = showOrders;
            btnShowAll.Visible = showOrders;
            label1.Visible = showOrders;
            btnStatusNotiffication.Visible = showOrders;
            this.who = who;
            refreshTable();
            _newRow = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.AutoResizeRows();
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clientsEdit1.Client = new Clients { ProfileCreateDate = DateTime.Now.Date };
            _newRow = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            ordersEdit1.Order = new Orders { Date = DateTime.Now.Date };
            _newRow = true;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            sevicesEdit1.Service = new Services { };
            _newRow = true;
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (_newRow)
            {
                dataManager.addOrder(ordersEdit1.Order);
                _newRow = false;
            }
            else
            {
                dataManager.saveOrder(ordersEdit1.Order);
            }
            refreshTable();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (_newRow)
            {
                dataManager.addClient(clientsEdit1.Client);
                _newRow = false;
            }
            else
            {
                dataManager.saveClient(clientsEdit1.Client);
            }
            refreshTable();
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            if (_newRow)
            {
                dataManager.addService(sevicesEdit1.Service);
                _newRow = false;
            }
            else
            {
                dataManager.saveService(sevicesEdit1.Service);
            }
            refreshTable();
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            dataManager.deleteService(id: sevicesEdit1.Service?.Id ?? 0);
            refreshTable();
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            dataManager.deleteOrder(id: ordersEdit1.Order?.ID ?? 0);
            refreshTable();
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            dataManager.deleteClient(id: clientsEdit1.Client?.ID ?? 0);
            refreshTable();
        }
        private void btnSortByClients_Click(object sender, EventArgs e)
        {
            if (sorting == "byNameUp")
                sorting = "byNameDown";
            else
                sorting = "byNameUp";
            refreshTable();
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            if (sorting == "byDateDown")
                sorting = "byDateUp";
            else
                sorting = "byDateDown";
            refreshTable();
        }

        private void btnSortByStatus_Click(object sender, EventArgs e)
        {
            if (sorting == "byStatusUp")
                sorting = "byStatusDown";
            else
                sorting = "byStatusUp";
            refreshTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sorting = "ID";
            idSearchKey = cbClientFilter.SelectedValue.ToString();
            refreshTable();
        }

        private void btnStatusNotiffication_Click(object sender, EventArgs e)
        {
            string message = ordersEdit1.getSelectedClientNumber();
            MessageBox.Show("Сообщение о готовности заказа отправлено на номер " + message);
        }
    }
}
