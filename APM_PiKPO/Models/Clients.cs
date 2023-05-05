using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace APM_PiKPO
{
    public class Clients : IBindableComponent
    {
        ISite iSite;
        ControlBindingsCollection dataBindings;
        BindingContext bindingContext = new BindingContext();

        public Clients()
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
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
        [DisplayName("Электронная почта")]
        public string Mail { get; set; }
        [DisplayName("Дата создания")]
        public DateTime Date { get; set; }

    }
}