using APM_PiKPO.DAL;
using APM_PiKPO.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        RepositoryTablesImpl repository;
        private bool _newRow;
        private string who;

        public PhotoCenterForm()
        {
            InitializeComponent();
            who = "Clients";
            _clientsList = new List<Clients>();
            _ordersList = new List<Orders>();
            _servicesList = new List<Services>();
            repository = new RepositoryTablesImpl();
            bsUser.DataSource = _clientsList;
            dataGridView1.AutoGenerateColumns = true;
            clientsEdit1.Client = new Clients { Date = DateTime.Now.Date };
            refreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {     
            if (who == "Clients")
            {
                _clientsList.Clear();
                bsUser.DataSource = _clientsList;
                List<Clients> list = repository.GetClients();
                _clientsList.AddRange(list);
                bsUser.ResetBindings(false);
            }
            else if (who == "Orders")
            {
                _ordersList.Clear();
                bsUser.DataSource = _ordersList;
                List<Orders> list = repository.GetOrders();
                _ordersList.AddRange(list);
                bsUser.ResetBindings(false);
            }

            else if (who == "Services")
            {
                _servicesList.Clear();
                bsUser.DataSource = _servicesList;
                List<Services> list = repository.GetServices();
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
            }
            else  if (who == "Orders")
            {
                var order = (Orders)bsUser.Current;
                ordersEdit1.Order = order;
            }
            else if (who == "Services")
            {
                var service = (Services)bsUser.Current;
                sevicesEdit1.Service = service;
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            SwitchViews(true, false, false, "Clients");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
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
            dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clientsEdit1.Client = new Clients { Date = DateTime.Now.Date };
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
                repository.AddOrder(ordersEdit1.Order);
                _newRow = false;
            }
            else
            {
                repository.SaveOrder(ordersEdit1.Order);
            }
            refreshTable();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (_newRow)
            {
                repository.AddClient(clientsEdit1.Client);
                _newRow = false;
            }
            else
            {
                repository.SaveClient(clientsEdit1.Client);
            }
            refreshTable();
            
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            if (_newRow)
            {
                repository.AddService(sevicesEdit1.Service);
                _newRow = false;
            }
            else
            {
                repository.SaveService(sevicesEdit1.Service);
            }
            refreshTable();
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            repository.DeleteService(id: sevicesEdit1.Service?.Id ?? 0);
            refreshTable();
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            repository.DeleteOrder(id: ordersEdit1.Order?.Id ?? 0);
            refreshTable();
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            repository.DeleteClient(id: clientsEdit1.Client?.Id ?? 0);
            refreshTable();
        }
    }
}
