using APM_PiKPO.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_PiKPO
{
    public partial class OrdersEdit : UserControl
    {
        private Orders order;
        RepositoryTablesImpl repository;
        public Orders Order { get => order; set { order = value; bind(); } }

        public OrdersEdit()
        {
            InitializeComponent();
            repository = new RepositoryTablesImpl();
        }
        private void bind()
        {
            if (order != null)
            {
                cbClients.DataBindings.Clear();
                cbClients.DataSource = repository.getClients();
                cbClients.DisplayMember = "FullName";
                cbClients.ValueMember = "ID";
                cbClients.DataBindings.Add("SelectedValue", order, "ClientId");

                cbService.DataBindings.Clear();
                cbService.DataSource = repository.getServices();
                cbService.DisplayMember = "ServiceName";
                cbService.ValueMember = "Id";
                cbService.DataBindings.Add("SelectedValue", order, "ServiceId");

                datePicker.DataBindings.Clear();
                datePicker.DataBindings.Add("Value", order, "Date");

                сbStatus.DataBindings.Clear();
                сbStatus.DataBindings.Add("SelectedItem", order, "Status");
            }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clients selectedClient = (Clients)cbClients.SelectedItem;
            if (selectedClient != null)
            {
                    order.ClientName = selectedClient.FullName;
            }
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            Services selectedService = (Services)cbService.SelectedItem;
            if (selectedService != null)
            {
                order.ServiceName = selectedService.ServiceName;
                order.totalAmount = selectedService.Price;
            }
        }
    }
}
