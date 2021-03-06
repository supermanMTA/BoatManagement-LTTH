﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoatManagement.ServiceBoatLostInfor {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BoatLostInfor", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class BoatLostInfor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        private System.Nullable<System.DateTime> LastConnectField;
        
        private System.Nullable<double> LongitudeField;
        
        private System.Nullable<double> LatitudeField;
        
        private System.Nullable<int> IDJourneyField;
        
        private System.Nullable<bool> StatusField;
        
        private System.Nullable<int> IDBoatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OceanField;
        
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
        public int ID {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> LastConnect {
            get {
                return this.LastConnectField;
            }
            set {
                if ((this.LastConnectField.Equals(value) != true)) {
                    this.LastConnectField = value;
                    this.RaisePropertyChanged("LastConnect");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<double> Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<double> Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<int> IDJourney {
            get {
                return this.IDJourneyField;
            }
            set {
                if ((this.IDJourneyField.Equals(value) != true)) {
                    this.IDJourneyField = value;
                    this.RaisePropertyChanged("IDJourney");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<bool> Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<int> IDBoat {
            get {
                return this.IDBoatField;
            }
            set {
                if ((this.IDBoatField.Equals(value) != true)) {
                    this.IDBoatField = value;
                    this.RaisePropertyChanged("IDBoat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Ocean {
            get {
                return this.OceanField;
            }
            set {
                if ((object.ReferenceEquals(this.OceanField, value) != true)) {
                    this.OceanField = value;
                    this.RaisePropertyChanged("Ocean");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBoatLostInfor.BoatLostInfor1Soap")]
    public interface BoatLostInfor1Soap {
        
        // CODEGEN: Generating message contract since element name AllBoatLoatInforResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AllBoatLoatInfor", ReplyAction="*")]
        BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponse AllBoatLoatInfor(BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AllBoatLoatInfor", ReplyAction="*")]
        System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponse> AllBoatLoatInforAsync(BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest request);
        
        // CODEGEN: Generating message contract since element name ocean from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        BoatManagement.ServiceBoatLostInfor.InsertResponse Insert(BoatManagement.ServiceBoatLostInfor.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.InsertResponse> InsertAsync(BoatManagement.ServiceBoatLostInfor.InsertRequest request);
        
        // CODEGEN: Generating message contract since element name ocean from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        BoatManagement.ServiceBoatLostInfor.UpdateResponse Update(BoatManagement.ServiceBoatLostInfor.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.UpdateResponse> UpdateAsync(BoatManagement.ServiceBoatLostInfor.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AllBoatLoatInforRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AllBoatLoatInfor", Namespace="http://tempuri.org/", Order=0)]
        public BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequestBody Body;
        
        public AllBoatLoatInforRequest() {
        }
        
        public AllBoatLoatInforRequest(BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AllBoatLoatInforRequestBody {
        
        public AllBoatLoatInforRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AllBoatLoatInforResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AllBoatLoatInforResponse", Namespace="http://tempuri.org/", Order=0)]
        public BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponseBody Body;
        
        public AllBoatLoatInforResponse() {
        }
        
        public AllBoatLoatInforResponse(BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AllBoatLoatInforResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BoatManagement.ServiceBoatLostInfor.BoatLostInfor[] AllBoatLoatInforResult;
        
        public AllBoatLoatInforResponseBody() {
        }
        
        public AllBoatLoatInforResponseBody(BoatManagement.ServiceBoatLostInfor.BoatLostInfor[] AllBoatLoatInforResult) {
            this.AllBoatLoatInforResult = AllBoatLoatInforResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public BoatManagement.ServiceBoatLostInfor.InsertRequestBody Body;
        
        public InsertRequest() {
        }
        
        public InsertRequest(BoatManagement.ServiceBoatLostInfor.InsertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime Lastconnect;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public float lat;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public float Long;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int ID_jouney;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public bool status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int ID_boat;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string ocean;
        
        public InsertRequestBody() {
        }
        
        public InsertRequestBody(System.DateTime Lastconnect, float lat, float Long, int ID_jouney, bool status, int ID_boat, string ocean) {
            this.Lastconnect = Lastconnect;
            this.lat = lat;
            this.Long = Long;
            this.ID_jouney = ID_jouney;
            this.status = status;
            this.ID_boat = ID_boat;
            this.ocean = ocean;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public BoatManagement.ServiceBoatLostInfor.InsertResponseBody Body;
        
        public InsertResponse() {
        }
        
        public InsertResponse(BoatManagement.ServiceBoatLostInfor.InsertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertResult;
        
        public InsertResponseBody() {
        }
        
        public InsertResponseBody(bool InsertResult) {
            this.InsertResult = InsertResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public BoatManagement.ServiceBoatLostInfor.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(BoatManagement.ServiceBoatLostInfor.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.DateTime timeconnect;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public float lat;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public float Long;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int ID_jouney;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ocean;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(int ID, System.DateTime timeconnect, float lat, float Long, int ID_jouney, string ocean) {
            this.ID = ID;
            this.timeconnect = timeconnect;
            this.lat = lat;
            this.Long = Long;
            this.ID_jouney = ID_jouney;
            this.ocean = ocean;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public BoatManagement.ServiceBoatLostInfor.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(BoatManagement.ServiceBoatLostInfor.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(bool UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BoatLostInfor1SoapChannel : BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BoatLostInfor1SoapClient : System.ServiceModel.ClientBase<BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap>, BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap {
        
        public BoatLostInfor1SoapClient() {
        }
        
        public BoatLostInfor1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BoatLostInfor1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoatLostInfor1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoatLostInfor1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponse BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap.AllBoatLoatInfor(BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest request) {
            return base.Channel.AllBoatLoatInfor(request);
        }
        
        public BoatManagement.ServiceBoatLostInfor.BoatLostInfor[] AllBoatLoatInfor() {
            BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest inValue = new BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest();
            inValue.Body = new BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequestBody();
            BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponse retVal = ((BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap)(this)).AllBoatLoatInfor(inValue);
            return retVal.Body.AllBoatLoatInforResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponse> BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap.AllBoatLoatInforAsync(BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest request) {
            return base.Channel.AllBoatLoatInforAsync(request);
        }
        
        public System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforResponse> AllBoatLoatInforAsync() {
            BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest inValue = new BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequest();
            inValue.Body = new BoatManagement.ServiceBoatLostInfor.AllBoatLoatInforRequestBody();
            return ((BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap)(this)).AllBoatLoatInforAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BoatManagement.ServiceBoatLostInfor.InsertResponse BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap.Insert(BoatManagement.ServiceBoatLostInfor.InsertRequest request) {
            return base.Channel.Insert(request);
        }
        
        public bool Insert(System.DateTime Lastconnect, float lat, float Long, int ID_jouney, bool status, int ID_boat, string ocean) {
            BoatManagement.ServiceBoatLostInfor.InsertRequest inValue = new BoatManagement.ServiceBoatLostInfor.InsertRequest();
            inValue.Body = new BoatManagement.ServiceBoatLostInfor.InsertRequestBody();
            inValue.Body.Lastconnect = Lastconnect;
            inValue.Body.lat = lat;
            inValue.Body.Long = Long;
            inValue.Body.ID_jouney = ID_jouney;
            inValue.Body.status = status;
            inValue.Body.ID_boat = ID_boat;
            inValue.Body.ocean = ocean;
            BoatManagement.ServiceBoatLostInfor.InsertResponse retVal = ((BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap)(this)).Insert(inValue);
            return retVal.Body.InsertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.InsertResponse> BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap.InsertAsync(BoatManagement.ServiceBoatLostInfor.InsertRequest request) {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.InsertResponse> InsertAsync(System.DateTime Lastconnect, float lat, float Long, int ID_jouney, bool status, int ID_boat, string ocean) {
            BoatManagement.ServiceBoatLostInfor.InsertRequest inValue = new BoatManagement.ServiceBoatLostInfor.InsertRequest();
            inValue.Body = new BoatManagement.ServiceBoatLostInfor.InsertRequestBody();
            inValue.Body.Lastconnect = Lastconnect;
            inValue.Body.lat = lat;
            inValue.Body.Long = Long;
            inValue.Body.ID_jouney = ID_jouney;
            inValue.Body.status = status;
            inValue.Body.ID_boat = ID_boat;
            inValue.Body.ocean = ocean;
            return ((BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BoatManagement.ServiceBoatLostInfor.UpdateResponse BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap.Update(BoatManagement.ServiceBoatLostInfor.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public bool Update(int ID, System.DateTime timeconnect, float lat, float Long, int ID_jouney, string ocean) {
            BoatManagement.ServiceBoatLostInfor.UpdateRequest inValue = new BoatManagement.ServiceBoatLostInfor.UpdateRequest();
            inValue.Body = new BoatManagement.ServiceBoatLostInfor.UpdateRequestBody();
            inValue.Body.ID = ID;
            inValue.Body.timeconnect = timeconnect;
            inValue.Body.lat = lat;
            inValue.Body.Long = Long;
            inValue.Body.ID_jouney = ID_jouney;
            inValue.Body.ocean = ocean;
            BoatManagement.ServiceBoatLostInfor.UpdateResponse retVal = ((BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap)(this)).Update(inValue);
            return retVal.Body.UpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.UpdateResponse> BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap.UpdateAsync(BoatManagement.ServiceBoatLostInfor.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<BoatManagement.ServiceBoatLostInfor.UpdateResponse> UpdateAsync(int ID, System.DateTime timeconnect, float lat, float Long, int ID_jouney, string ocean) {
            BoatManagement.ServiceBoatLostInfor.UpdateRequest inValue = new BoatManagement.ServiceBoatLostInfor.UpdateRequest();
            inValue.Body = new BoatManagement.ServiceBoatLostInfor.UpdateRequestBody();
            inValue.Body.ID = ID;
            inValue.Body.timeconnect = timeconnect;
            inValue.Body.lat = lat;
            inValue.Body.Long = Long;
            inValue.Body.ID_jouney = ID_jouney;
            inValue.Body.ocean = ocean;
            return ((BoatManagement.ServiceBoatLostInfor.BoatLostInfor1Soap)(this)).UpdateAsync(inValue);
        }
    }
}
