﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDP_Clinic.EDP_DBReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/DBService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DBService.Entity")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VerifiedField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Verified {
            get {
                return this.VerifiedField;
            }
            set {
                if ((object.ReferenceEquals(this.VerifiedField, value) != true)) {
                    this.VerifiedField = value;
                    this.RaisePropertyChanged("Verified");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="displayUser", Namespace="http://schemas.datacontract.org/2004/07/DBService.Entity")]
    [System.SerializableAttribute()]
    public partial class displayUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VerifiedField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
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
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Verified {
            get {
                return this.VerifiedField;
            }
            set {
                if ((object.ReferenceEquals(this.VerifiedField, value) != true)) {
                    this.VerifiedField = value;
                    this.RaisePropertyChanged("Verified");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CardInfo", Namespace="http://schemas.datacontract.org/2004/07/DBService.Entity")]
    [System.SerializableAttribute()]
    public partial class CardInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CVVNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CardExpiryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] IVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StillValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UniqueIdentifierField;
        
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
        public string CVVNumber {
            get {
                return this.CVVNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CVVNumberField, value) != true)) {
                    this.CVVNumberField = value;
                    this.RaisePropertyChanged("CVVNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CardExpiry {
            get {
                return this.CardExpiryField;
            }
            set {
                if ((this.CardExpiryField.Equals(value) != true)) {
                    this.CardExpiryField = value;
                    this.RaisePropertyChanged("CardExpiry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardName {
            get {
                return this.CardNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNameField, value) != true)) {
                    this.CardNameField = value;
                    this.RaisePropertyChanged("CardName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardNumber {
            get {
                return this.CardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNumberField, value) != true)) {
                    this.CardNumberField = value;
                    this.RaisePropertyChanged("CardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] IV {
            get {
                return this.IVField;
            }
            set {
                if ((object.ReferenceEquals(this.IVField, value) != true)) {
                    this.IVField = value;
                    this.RaisePropertyChanged("IV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool StillValid {
            get {
                return this.StillValidField;
            }
            set {
                if ((this.StillValidField.Equals(value) != true)) {
                    this.StillValidField = value;
                    this.RaisePropertyChanged("StillValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UniqueIdentifier {
            get {
                return this.UniqueIdentifierField;
            }
            set {
                if ((object.ReferenceEquals(this.UniqueIdentifierField, value) != true)) {
                    this.UniqueIdentifierField = value;
                    this.RaisePropertyChanged("UniqueIdentifier");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EDP_DBReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        EDP_Clinic.EDP_DBReference.CompositeType GetDataUsingDataContract(EDP_Clinic.EDP_DBReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.CompositeType> GetDataUsingDataContractAsync(EDP_Clinic.EDP_DBReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneUser", ReplyAction="http://tempuri.org/IService1/GetOneUserResponse")]
        EDP_Clinic.EDP_DBReference.User GetOneUser(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneUser", ReplyAction="http://tempuri.org/IService1/GetOneUserResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User> GetOneUserAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditOneUser", ReplyAction="http://tempuri.org/IService1/EditOneUserResponse")]
        int EditOneUser(string id, string name, string email, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditOneUser", ReplyAction="http://tempuri.org/IService1/EditOneUserResponse")]
        System.Threading.Tasks.Task<int> EditOneUserAsync(string id, string name, string email, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOneUser", ReplyAction="http://tempuri.org/IService1/DeleteOneUserResponse")]
        int DeleteOneUser(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOneUser", ReplyAction="http://tempuri.org/IService1/DeleteOneUserResponse")]
        System.Threading.Tasks.Task<int> DeleteOneUserAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckOneUser", ReplyAction="http://tempuri.org/IService1/CheckOneUserResponse")]
        int CheckOneUser(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckOneUser", ReplyAction="http://tempuri.org/IService1/CheckOneUserResponse")]
        System.Threading.Tasks.Task<int> CheckOneUserAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneUserByEmail", ReplyAction="http://tempuri.org/IService1/GetOneUserByEmailResponse")]
        EDP_Clinic.EDP_DBReference.User GetOneUserByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneUserByEmail", ReplyAction="http://tempuri.org/IService1/GetOneUserByEmailResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User> GetOneUserByEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllUsers", ReplyAction="http://tempuri.org/IService1/GetAllUsersResponse")]
        EDP_Clinic.EDP_DBReference.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllUsers", ReplyAction="http://tempuri.org/IService1/GetAllUsersResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPatients", ReplyAction="http://tempuri.org/IService1/GetAllPatientsResponse")]
        EDP_Clinic.EDP_DBReference.User[] GetAllPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPatients", ReplyAction="http://tempuri.org/IService1/GetAllPatientsResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User[]> GetAllPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployees", ReplyAction="http://tempuri.org/IService1/GetAllEmployeesResponse")]
        EDP_Clinic.EDP_DBReference.User[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployees", ReplyAction="http://tempuri.org/IService1/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowOneUser", ReplyAction="http://tempuri.org/IService1/ShowOneUserResponse")]
        EDP_Clinic.EDP_DBReference.displayUser ShowOneUser(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowOneUser", ReplyAction="http://tempuri.org/IService1/ShowOneUserResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser> ShowOneUserAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllUsers", ReplyAction="http://tempuri.org/IService1/ShowAllUsersResponse")]
        EDP_Clinic.EDP_DBReference.displayUser[] ShowAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllUsers", ReplyAction="http://tempuri.org/IService1/ShowAllUsersResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser[]> ShowAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllPatients", ReplyAction="http://tempuri.org/IService1/ShowAllPatientsResponse")]
        EDP_Clinic.EDP_DBReference.displayUser[] ShowAllPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllPatients", ReplyAction="http://tempuri.org/IService1/ShowAllPatientsResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser[]> ShowAllPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllEmployees", ReplyAction="http://tempuri.org/IService1/ShowAllEmployeesResponse")]
        EDP_Clinic.EDP_DBReference.displayUser[] ShowAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllEmployees", ReplyAction="http://tempuri.org/IService1/ShowAllEmployeesResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser[]> ShowAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCardInfo", ReplyAction="http://tempuri.org/IService1/CreateCardInfoResponse")]
        int CreateCardInfo(string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber, byte[] iv, byte[] key, bool stillValid, string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCardInfo", ReplyAction="http://tempuri.org/IService1/CreateCardInfoResponse")]
        System.Threading.Tasks.Task<int> CreateCardInfoAsync(string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber, byte[] iv, byte[] key, bool stillValid, string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCardByCardNumber", ReplyAction="http://tempuri.org/IService1/GetCardByCardNumberResponse")]
        EDP_Clinic.EDP_DBReference.CardInfo GetCardByCardNumber(string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCardByCardNumber", ReplyAction="http://tempuri.org/IService1/GetCardByCardNumberResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.CardInfo> GetCardByCardNumberAsync(string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCards", ReplyAction="http://tempuri.org/IService1/GetAllCardsResponse")]
        EDP_Clinic.EDP_DBReference.CardInfo[] GetAllCards();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCards", ReplyAction="http://tempuri.org/IService1/GetAllCardsResponse")]
        System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.CardInfo[]> GetAllCardsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteByCardNumber", ReplyAction="http://tempuri.org/IService1/DeleteByCardNumberResponse")]
        int DeleteByCardNumber(string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteByCardNumber", ReplyAction="http://tempuri.org/IService1/DeleteByCardNumberResponse")]
        System.Threading.Tasks.Task<int> DeleteByCardNumberAsync(string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckCardByCardNumber", ReplyAction="http://tempuri.org/IService1/CheckCardByCardNumberResponse")]
        bool CheckCardByCardNumber(string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckCardByCardNumber", ReplyAction="http://tempuri.org/IService1/CheckCardByCardNumberResponse")]
        System.Threading.Tasks.Task<bool> CheckCardByCardNumberAsync(string uniqueIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateByCardNumber", ReplyAction="http://tempuri.org/IService1/UpdateByCardNumberResponse")]
        int UpdateByCardNumber(string previousCardNumber, string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateByCardNumber", ReplyAction="http://tempuri.org/IService1/UpdateByCardNumberResponse")]
        System.Threading.Tasks.Task<int> UpdateByCardNumberAsync(string previousCardNumber, string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateReceipt", ReplyAction="http://tempuri.org/IService1/CreateReceiptResponse")]
        int CreateReceipt(System.DateTime dateSale, double totalSum, bool isPaid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateReceipt", ReplyAction="http://tempuri.org/IService1/CreateReceiptResponse")]
        System.Threading.Tasks.Task<int> CreateReceiptAsync(System.DateTime dateSale, double totalSum, bool isPaid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EDP_Clinic.EDP_DBReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EDP_Clinic.EDP_DBReference.IService1>, EDP_Clinic.EDP_DBReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public EDP_Clinic.EDP_DBReference.CompositeType GetDataUsingDataContract(EDP_Clinic.EDP_DBReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.CompositeType> GetDataUsingDataContractAsync(EDP_Clinic.EDP_DBReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public EDP_Clinic.EDP_DBReference.User GetOneUser(string id) {
            return base.Channel.GetOneUser(id);
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User> GetOneUserAsync(string id) {
            return base.Channel.GetOneUserAsync(id);
        }
        
        public int EditOneUser(string id, string name, string email, string mobile) {
            return base.Channel.EditOneUser(id, name, email, mobile);
        }
        
        public System.Threading.Tasks.Task<int> EditOneUserAsync(string id, string name, string email, string mobile) {
            return base.Channel.EditOneUserAsync(id, name, email, mobile);
        }
        
        public int DeleteOneUser(string id) {
            return base.Channel.DeleteOneUser(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteOneUserAsync(string id) {
            return base.Channel.DeleteOneUserAsync(id);
        }
        
        public int CheckOneUser(string email) {
            return base.Channel.CheckOneUser(email);
        }
        
        public System.Threading.Tasks.Task<int> CheckOneUserAsync(string email) {
            return base.Channel.CheckOneUserAsync(email);
        }
        
        public EDP_Clinic.EDP_DBReference.User GetOneUserByEmail(string email) {
            return base.Channel.GetOneUserByEmail(email);
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User> GetOneUserByEmailAsync(string email) {
            return base.Channel.GetOneUserByEmailAsync(email);
        }
        
        public EDP_Clinic.EDP_DBReference.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public EDP_Clinic.EDP_DBReference.User[] GetAllPatients() {
            return base.Channel.GetAllPatients();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User[]> GetAllPatientsAsync() {
            return base.Channel.GetAllPatientsAsync();
        }
        
        public EDP_Clinic.EDP_DBReference.User[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.User[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public EDP_Clinic.EDP_DBReference.displayUser ShowOneUser(string id) {
            return base.Channel.ShowOneUser(id);
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser> ShowOneUserAsync(string id) {
            return base.Channel.ShowOneUserAsync(id);
        }
        
        public EDP_Clinic.EDP_DBReference.displayUser[] ShowAllUsers() {
            return base.Channel.ShowAllUsers();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser[]> ShowAllUsersAsync() {
            return base.Channel.ShowAllUsersAsync();
        }
        
        public EDP_Clinic.EDP_DBReference.displayUser[] ShowAllPatients() {
            return base.Channel.ShowAllPatients();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser[]> ShowAllPatientsAsync() {
            return base.Channel.ShowAllPatientsAsync();
        }
        
        public EDP_Clinic.EDP_DBReference.displayUser[] ShowAllEmployees() {
            return base.Channel.ShowAllEmployees();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.displayUser[]> ShowAllEmployeesAsync() {
            return base.Channel.ShowAllEmployeesAsync();
        }
        
        public int CreateCardInfo(string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber, byte[] iv, byte[] key, bool stillValid, string uniqueIdentifier) {
            return base.Channel.CreateCardInfo(cardName, cardNumber, cardExpiry, cvvNumber, iv, key, stillValid, uniqueIdentifier);
        }
        
        public System.Threading.Tasks.Task<int> CreateCardInfoAsync(string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber, byte[] iv, byte[] key, bool stillValid, string uniqueIdentifier) {
            return base.Channel.CreateCardInfoAsync(cardName, cardNumber, cardExpiry, cvvNumber, iv, key, stillValid, uniqueIdentifier);
        }
        
        public EDP_Clinic.EDP_DBReference.CardInfo GetCardByCardNumber(string uniqueIdentifier) {
            return base.Channel.GetCardByCardNumber(uniqueIdentifier);
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.CardInfo> GetCardByCardNumberAsync(string uniqueIdentifier) {
            return base.Channel.GetCardByCardNumberAsync(uniqueIdentifier);
        }
        
        public EDP_Clinic.EDP_DBReference.CardInfo[] GetAllCards() {
            return base.Channel.GetAllCards();
        }
        
        public System.Threading.Tasks.Task<EDP_Clinic.EDP_DBReference.CardInfo[]> GetAllCardsAsync() {
            return base.Channel.GetAllCardsAsync();
        }
        
        public int DeleteByCardNumber(string uniqueIdentifier) {
            return base.Channel.DeleteByCardNumber(uniqueIdentifier);
        }
        
        public System.Threading.Tasks.Task<int> DeleteByCardNumberAsync(string uniqueIdentifier) {
            return base.Channel.DeleteByCardNumberAsync(uniqueIdentifier);
        }
        
        public bool CheckCardByCardNumber(string uniqueIdentifier) {
            return base.Channel.CheckCardByCardNumber(uniqueIdentifier);
        }
        
        public System.Threading.Tasks.Task<bool> CheckCardByCardNumberAsync(string uniqueIdentifier) {
            return base.Channel.CheckCardByCardNumberAsync(uniqueIdentifier);
        }
        
        public int UpdateByCardNumber(string previousCardNumber, string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber) {
            return base.Channel.UpdateByCardNumber(previousCardNumber, cardName, cardNumber, cardExpiry, cvvNumber);
        }
        
        public System.Threading.Tasks.Task<int> UpdateByCardNumberAsync(string previousCardNumber, string cardName, string cardNumber, System.DateTime cardExpiry, string cvvNumber) {
            return base.Channel.UpdateByCardNumberAsync(previousCardNumber, cardName, cardNumber, cardExpiry, cvvNumber);
        }
        
        public int CreateReceipt(System.DateTime dateSale, double totalSum, bool isPaid) {
            return base.Channel.CreateReceipt(dateSale, totalSum, isPaid);
        }
        
        public System.Threading.Tasks.Task<int> CreateReceiptAsync(System.DateTime dateSale, double totalSum, bool isPaid) {
            return base.Channel.CreateReceiptAsync(dateSale, totalSum, isPaid);
        }
    }
}
