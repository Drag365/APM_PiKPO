using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_PiKPO.DAL
{
    public class Orders : IBindableComponent
    {
        ISite iSite;
        ControlBindingsCollection dataBindings;
        BindingContext bindingContext = new BindingContext();

        public Orders()
        {
            dataBindings = new ControlBindingsCollection(this);
        }
        [Browsable(false)]
        public event EventHandler Disposed;
        [Browsable(false)]
        public void Dispose()
        {
            //your code for disposing
        }
        [Browsable(false)]
        public BindingContext BindingContext
        {
            get { return bindingContext; }
            set { bindingContext = value; }
        }
        [Browsable(false)]
        public ControlBindingsCollection DataBindings
        {
            get { return dataBindings; }
        }
        [Browsable(false)]
        public ISite Site
        {
            get { return iSite; }
            set { iSite = value; }
        }

        [DisplayName("ID заказа")]
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Клиент")]
        public string Client { get; set; }
        [DisplayName("Дата заказа")]
        public DateTime Date { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Итоговая стоимость")]
        public int totalAmount { get; set; }
    }
}
