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
        public int ID { get; set; }
        
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Полное имя")]
        public string FullName
        {
            get { return string.Format("{1} {0}", FirstName, Surname); }
        }

        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
        [DisplayName("Электронная почта")]
        public string Mail { get; set; }
        [DisplayName("Дата создания")]
        public DateTime ProfileCreateDate { get; set; }

    }
}