﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.RegisterViaNECCardService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UPRNType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private UPRNTypeUPRNType uPRNType1Field;
        
        private bool uPRNType1FieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UPRNType")]
        public UPRNTypeUPRNType UPRNType1 {
            get {
                return this.uPRNType1Field;
            }
            set {
                this.uPRNType1Field = value;
                this.RaisePropertyChanged("UPRNType1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UPRNType1Specified {
            get {
                return this.uPRNType1FieldSpecified;
            }
            set {
                this.uPRNType1FieldSpecified = value;
                this.RaisePropertyChanged("UPRNType1Specified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum UPRNTypeUPRNType {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        T,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UCRNType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private UCRNTypeUCRNType uCRNType1Field;
        
        private bool uCRNType1FieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UCRNType")]
        public UCRNTypeUCRNType UCRNType1 {
            get {
                return this.uCRNType1Field;
            }
            set {
                this.uCRNType1Field = value;
                this.RaisePropertyChanged("UCRNType1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UCRNType1Specified {
            get {
                return this.uCRNType1FieldSpecified;
            }
            set {
                this.uCRNType1FieldSpecified = value;
                this.RaisePropertyChanged("UCRNType1Specified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum UCRNTypeUCRNType {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        PU,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegisterViaNecCardTypes")]
    public partial class ResponseBody : object, System.ComponentModel.INotifyPropertyChanged {
        
        private UCRNType uCRNField;
        
        private UPRNType uPRNField;
        
        private long nECCardNumberField;
        
        private bool nECCardNumberFieldSpecified;
        
        private string usernameField;
        
        private string emailAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public UCRNType UCRN {
            get {
                return this.uCRNField;
            }
            set {
                this.uCRNField = value;
                this.RaisePropertyChanged("UCRN");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public UPRNType UPRN {
            get {
                return this.uPRNField;
            }
            set {
                this.uPRNField = value;
                this.RaisePropertyChanged("UPRN");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long NECCardNumber {
            get {
                return this.nECCardNumberField;
            }
            set {
                this.nECCardNumberField = value;
                this.RaisePropertyChanged("NECCardNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NECCardNumberSpecified {
            get {
                return this.nECCardNumberFieldSpecified;
            }
            set {
                this.nECCardNumberFieldSpecified = value;
                this.RaisePropertyChanged("NECCardNumberSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
                this.RaisePropertyChanged("EmailAddress");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class ResponseHead : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string responseCodeField;
        
        private string responseMessageField;
        
        private bool resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ResponseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
                this.RaisePropertyChanged("ResponseCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ResponseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                this.responseMessageField = value;
                this.RaisePropertyChanged("ResponseMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegisterViaNecCardTypes")]
    public partial class RegisterViaNECCardResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ResponseHead responseHeadField;
        
        private ResponseBody responseBodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResponseHead ResponseHead {
            get {
                return this.responseHeadField;
            }
            set {
                this.responseHeadField = value;
                this.RaisePropertyChanged("ResponseHead");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ResponseBody ResponseBody {
            get {
                return this.responseBodyField;
            }
            set {
                this.responseBodyField = value;
                this.RaisePropertyChanged("ResponseBody");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService")]
    public partial class addNewUserNecResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RegisterViaNECCardResponse registerViaNECCardResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RegisterViaNECCardResponse RegisterViaNECCardResponse {
            get {
                return this.registerViaNECCardResponseField;
            }
            set {
                this.registerViaNECCardResponseField = value;
                this.RaisePropertyChanged("RegisterViaNECCardResponse");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegisterViaNecCardTypes")]
    public partial class RequestBody : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long nECCardNumberField;
        
        private string postCodeField;
        
        private string emailAddressField;
        
        private string mobileNumberField;
        
        private string usernameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long NECCardNumber {
            get {
                return this.nECCardNumberField;
            }
            set {
                this.nECCardNumberField = value;
                this.RaisePropertyChanged("NECCardNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
                this.RaisePropertyChanged("EmailAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string MobileNumber {
            get {
                return this.mobileNumberField;
            }
            set {
                this.mobileNumberField = value;
                this.RaisePropertyChanged("MobileNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegisterViaNecCardTypes")]
    public partial class RegisterViaNECCardRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RequestBody requestBodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RequestBody RequestBody {
            get {
                return this.requestBodyField;
            }
            set {
                this.requestBodyField = value;
                this.RaisePropertyChanged("RequestBody");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService")]
    public partial class addNewUserNec : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RegisterViaNECCardRequest registerViaNECCardRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RegisterViaNECCardRequest registerViaNECCardRequest {
            get {
                return this.registerViaNECCardRequestField;
            }
            set {
                this.registerViaNECCardRequestField = value;
                this.RaisePropertyChanged("registerViaNECCardRequest");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService")]
    public partial class ServiceException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string exceptionStackTraceField;
        
        private string messageField;
        
        private string messageIdField;
        
        private string[] placeHolderValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string exceptionStackTrace {
            get {
                return this.exceptionStackTraceField;
            }
            set {
                this.exceptionStackTraceField = value;
                this.RaisePropertyChanged("exceptionStackTrace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string messageId {
            get {
                return this.messageIdField;
            }
            set {
                this.messageIdField = value;
                this.RaisePropertyChanged("messageId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("placeHolderValues", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string[] placeHolderValues {
            get {
                return this.placeHolderValuesField;
            }
            set {
                this.placeHolderValuesField = value;
                this.RaisePropertyChanged("placeHolderValues");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService", ConfigurationName="RegisterViaNECCardService.RegisterViaNECCardService")]
    public interface RegisterViaNECCardService {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.mycas.org.uk/services/AddNewUserNec", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsApplication1.RegisterViaNECCardService.Exception), Action="https://www.mycas.org.uk/services/AddNewUserNec", Name="Exception")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsApplication1.RegisterViaNECCardService.ServiceException), Action="https://www.mycas.org.uk/services/AddNewUserNec", Name="ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecResponse1 addNewUserNec(WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.mycas.org.uk/services/AddNewUserNec", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecResponse1> addNewUserNecAsync(WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addNewUserNecRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CallerToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService", Order=0)]
        public WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNec addNewUserNec;
        
        public addNewUserNecRequest() {
        }
        
        public addNewUserNecRequest(string CallerToken, WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNec addNewUserNec) {
            this.CallerToken = CallerToken;
            this.addNewUserNec = addNewUserNec;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addNewUserNecResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/RegisterViaNECCardService", Order=0)]
        public WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecResponse addNewUserNecResponse;
        
        public addNewUserNecResponse1() {
        }
        
        public addNewUserNecResponse1(WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecResponse addNewUserNecResponse) {
            this.addNewUserNecResponse = addNewUserNecResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegisterViaNECCardServiceChannel : WindowsFormsApplication1.RegisterViaNECCardService.RegisterViaNECCardService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegisterViaNECCardServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.RegisterViaNECCardService.RegisterViaNECCardService>, WindowsFormsApplication1.RegisterViaNECCardService.RegisterViaNECCardService {
        
        public RegisterViaNECCardServiceClient() {
        }
        
        public RegisterViaNECCardServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegisterViaNECCardServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegisterViaNECCardServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegisterViaNECCardServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecResponse1 addNewUserNec(WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecRequest request) {
            return base.Channel.addNewUserNec(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecResponse1> addNewUserNecAsync(WindowsFormsApplication1.RegisterViaNECCardService.addNewUserNecRequest request) {
            return base.Channel.addNewUserNecAsync(request);
        }
    }
}