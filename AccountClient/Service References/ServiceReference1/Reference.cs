﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/AccountDomain.Entity")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AccountClient.ServiceReference1.Order[] OrdersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AccountClient.ServiceReference1.Order[] Orders {
            get {
                return this.OrdersField;
            }
            set {
                if ((object.ReferenceEquals(this.OrdersField, value) != true)) {
                    this.OrdersField = value;
                    this.RaisePropertyChanged("Orders");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/AccountDomain.Entity")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getCustomer", ReplyAction="http://tempuri.org/IAccountService/getCustomerResponse")]
        AccountClient.ServiceReference1.Customer getCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getCustomer", ReplyAction="http://tempuri.org/IAccountService/getCustomerResponse")]
        System.Threading.Tasks.Task<AccountClient.ServiceReference1.Customer> getCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getCustomerList", ReplyAction="http://tempuri.org/IAccountService/getCustomerListResponse")]
        AccountClient.ServiceReference1.Customer[] getCustomerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getCustomerList", ReplyAction="http://tempuri.org/IAccountService/getCustomerListResponse")]
        System.Threading.Tasks.Task<AccountClient.ServiceReference1.Customer[]> getCustomerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/addCustomer", ReplyAction="http://tempuri.org/IAccountService/addCustomerResponse")]
        void addCustomer(AccountClient.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/addCustomer", ReplyAction="http://tempuri.org/IAccountService/addCustomerResponse")]
        System.Threading.Tasks.Task addCustomerAsync(AccountClient.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/deleteCustomer", ReplyAction="http://tempuri.org/IAccountService/deleteCustomerResponse")]
        void deleteCustomer(AccountClient.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/deleteCustomer", ReplyAction="http://tempuri.org/IAccountService/deleteCustomerResponse")]
        System.Threading.Tasks.Task deleteCustomerAsync(AccountClient.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/addOrder", ReplyAction="http://tempuri.org/IAccountService/addOrderResponse")]
        void addOrder(AccountClient.ServiceReference1.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/addOrder", ReplyAction="http://tempuri.org/IAccountService/addOrderResponse")]
        System.Threading.Tasks.Task addOrderAsync(AccountClient.ServiceReference1.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/deleteOrder", ReplyAction="http://tempuri.org/IAccountService/deleteOrderResponse")]
        void deleteOrder(AccountClient.ServiceReference1.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/deleteOrder", ReplyAction="http://tempuri.org/IAccountService/deleteOrderResponse")]
        System.Threading.Tasks.Task deleteOrderAsync(AccountClient.ServiceReference1.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getOrders", ReplyAction="http://tempuri.org/IAccountService/getOrdersResponse")]
        AccountClient.ServiceReference1.Order[] getOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getOrders", ReplyAction="http://tempuri.org/IAccountService/getOrdersResponse")]
        System.Threading.Tasks.Task<AccountClient.ServiceReference1.Order[]> getOrdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : AccountClient.ServiceReference1.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<AccountClient.ServiceReference1.IAccountService>, AccountClient.ServiceReference1.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AccountClient.ServiceReference1.Customer getCustomer(int id) {
            return base.Channel.getCustomer(id);
        }
        
        public System.Threading.Tasks.Task<AccountClient.ServiceReference1.Customer> getCustomerAsync(int id) {
            return base.Channel.getCustomerAsync(id);
        }
        
        public AccountClient.ServiceReference1.Customer[] getCustomerList() {
            return base.Channel.getCustomerList();
        }
        
        public System.Threading.Tasks.Task<AccountClient.ServiceReference1.Customer[]> getCustomerListAsync() {
            return base.Channel.getCustomerListAsync();
        }
        
        public void addCustomer(AccountClient.ServiceReference1.Customer customer) {
            base.Channel.addCustomer(customer);
        }
        
        public System.Threading.Tasks.Task addCustomerAsync(AccountClient.ServiceReference1.Customer customer) {
            return base.Channel.addCustomerAsync(customer);
        }
        
        public void deleteCustomer(AccountClient.ServiceReference1.Customer customer) {
            base.Channel.deleteCustomer(customer);
        }
        
        public System.Threading.Tasks.Task deleteCustomerAsync(AccountClient.ServiceReference1.Customer customer) {
            return base.Channel.deleteCustomerAsync(customer);
        }
        
        public void addOrder(AccountClient.ServiceReference1.Order order) {
            base.Channel.addOrder(order);
        }
        
        public System.Threading.Tasks.Task addOrderAsync(AccountClient.ServiceReference1.Order order) {
            return base.Channel.addOrderAsync(order);
        }
        
        public void deleteOrder(AccountClient.ServiceReference1.Order order) {
            base.Channel.deleteOrder(order);
        }
        
        public System.Threading.Tasks.Task deleteOrderAsync(AccountClient.ServiceReference1.Order order) {
            return base.Channel.deleteOrderAsync(order);
        }
        
        public AccountClient.ServiceReference1.Order[] getOrders() {
            return base.Channel.getOrders();
        }
        
        public System.Threading.Tasks.Task<AccountClient.ServiceReference1.Order[]> getOrdersAsync() {
            return base.Channel.getOrdersAsync();
        }
    }
}
