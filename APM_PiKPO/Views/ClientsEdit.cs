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
    public partial class ClientsEdit : UserControl
    {
        private Clients client;

        public Clients Client { get => client; set { client = value; bind(); } }

        private void bind()
        {
            if (client != null)
            {
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", client, "Name");
                txtSecondName.DataBindings.Clear();
                txtSecondName.DataBindings.Add("Text", client, "Surname");
                txtPhoneNumber.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Add("Text", client, "PhoneNumber");
                txtMail.DataBindings.Clear();
                txtMail.DataBindings.Add("Text", client, "Mail");
                datePicker.DataBindings.Clear();
                datePicker.DataBindings.Add("Value", client, "Date");
            }
        }

        public ClientsEdit()
        {
            InitializeComponent();
        }
    }
}
