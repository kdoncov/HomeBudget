﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeBudgetWeb.HomeBudgetWebServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Korisnik", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Korisnik : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<long> IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrezimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<long> ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Prezime {
            get {
                return this.PrezimeField;
            }
            set {
                if ((object.ReferenceEquals(this.PrezimeField, value) != true)) {
                    this.PrezimeField = value;
                    this.RaisePropertyChanged("Prezime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap")]
    public interface HomeBudgetWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponse HelloWorld(HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponse> HelloWorldAsync(HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KorisnikLogIn", ReplyAction="*")]
        HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponse KorisnikLogIn(HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KorisnikLogIn", ReplyAction="*")]
        System.Threading.Tasks.Task<HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponse> KorisnikLogInAsync(HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KorisnikLogInRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KorisnikLogIn", Namespace="http://tempuri.org/", Order=0)]
        public HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequestBody Body;
        
        public KorisnikLogInRequest() {
        }
        
        public KorisnikLogInRequest(HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KorisnikLogInRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public KorisnikLogInRequestBody() {
        }
        
        public KorisnikLogInRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KorisnikLogInResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KorisnikLogInResponse", Namespace="http://tempuri.org/", Order=0)]
        public HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponseBody Body;
        
        public KorisnikLogInResponse() {
        }
        
        public KorisnikLogInResponse(HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KorisnikLogInResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public HomeBudgetWeb.HomeBudgetWebServiceReference.Korisnik KorisnikLogInResult;
        
        public KorisnikLogInResponseBody() {
        }
        
        public KorisnikLogInResponseBody(HomeBudgetWeb.HomeBudgetWebServiceReference.Korisnik KorisnikLogInResult) {
            this.KorisnikLogInResult = KorisnikLogInResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HomeBudgetWebServiceSoapChannel : HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HomeBudgetWebServiceSoapClient : System.ServiceModel.ClientBase<HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap>, HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap {
        
        public HomeBudgetWebServiceSoapClient() {
        }
        
        public HomeBudgetWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HomeBudgetWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HomeBudgetWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HomeBudgetWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponse HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap.HelloWorld(HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest inValue = new HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest();
            inValue.Body = new HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequestBody();
            HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponse retVal = ((HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponse> HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap.HelloWorldAsync(HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldResponse> HelloWorldAsync() {
            HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest inValue = new HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequest();
            inValue.Body = new HomeBudgetWeb.HomeBudgetWebServiceReference.HelloWorldRequestBody();
            return ((HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponse HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap.KorisnikLogIn(HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest request) {
            return base.Channel.KorisnikLogIn(request);
        }
        
        public HomeBudgetWeb.HomeBudgetWebServiceReference.Korisnik KorisnikLogIn(string email, string password) {
            HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest inValue = new HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest();
            inValue.Body = new HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponse retVal = ((HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap)(this)).KorisnikLogIn(inValue);
            return retVal.Body.KorisnikLogInResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponse> HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap.KorisnikLogInAsync(HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest request) {
            return base.Channel.KorisnikLogInAsync(request);
        }
        
        public System.Threading.Tasks.Task<HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInResponse> KorisnikLogInAsync(string email, string password) {
            HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest inValue = new HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequest();
            inValue.Body = new HomeBudgetWeb.HomeBudgetWebServiceReference.KorisnikLogInRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((HomeBudgetWeb.HomeBudgetWebServiceReference.HomeBudgetWebServiceSoap)(this)).KorisnikLogInAsync(inValue);
        }
    }
}
