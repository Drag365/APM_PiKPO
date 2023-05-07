using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_PiKPO.DAL
{
    public class Services : IBindableComponent
    {
        ISite iSite;
        ControlBindingsCollection dataBindings;
        BindingContext bindingContext = new BindingContext();

        public Services()
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

        [DisplayName("ID")]
        //[Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Название услуги")]
        public string ServiceName { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
    }
}
