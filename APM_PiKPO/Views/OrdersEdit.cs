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

        public Orders Order { get => order; set { order = value; bind(); } }

        private void bind()
        {
            if (order != null)
            {
                cbClients.DataBindings.Clear();
                //numCLientID.DataBindings.Add("Value", order, "CliendId");
                numTotalAmount.DataBindings.Clear();
                numTotalAmount.DataBindings.Add("Value", order, "totalAmount");
                datePicker.DataBindings.Clear();
                datePicker.DataBindings.Add("Value", order, "Date");
                txtStatus.DataBindings.Clear();
                txtStatus.DataBindings.Add("Text", order, "Status");
                

            }
        }

        public OrdersEdit()
        {
            InitializeComponent();
        }

    }
}
