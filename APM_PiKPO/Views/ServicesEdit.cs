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

namespace APM_PiKPO.TablesEditors
{
    public partial class ServicesEdit : UserControl
    {
        private Services service;

        public Services Service { get => service; set { service = value; bind(); } }

        private void bind()
        {
            if (service != null)
            {
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", service, "Name");
                txtDescription.DataBindings.Clear();
                txtDescription.DataBindings.Add("Text", service, "Description");
                numPrice.DataBindings.Clear();
                numPrice.DataBindings.Add("Value", service, "Price");

            }
        }

        public ServicesEdit()
        {
            InitializeComponent();
        }
    }
}
