﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GDSstaffingportal.GDSBMServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GDSBMServiceReference.SendBulkeMailSoap")]
    public interface SendBulkeMailSoap {
        
        // CODEGEN: Generating message contract since element name From from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GDSSendBulkeMail", ReplyAction="*")]
        GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponse GDSSendBulkeMail(GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GDSSendBulkeMail", ReplyAction="*")]
        System.IAsyncResult BeginGDSSendBulkeMail(GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest request, System.AsyncCallback callback, object asyncState);
        
        GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponse EndGDSSendBulkeMail(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GDSSendBulkeMailRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GDSSendBulkeMail", Namespace="http://tempuri.org/", Order=0)]
        public GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequestBody Body;
        
        public GDSSendBulkeMailRequest() {
        }
        
        public GDSSendBulkeMailRequest(GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GDSSendBulkeMailRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string From;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string To;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string BCC;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string CC;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Body;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Subject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string filePath;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string AppKey;
        
        public GDSSendBulkeMailRequestBody() {
        }
        
        public GDSSendBulkeMailRequestBody(string From, string To, string BCC, string CC, string Body, string Subject, string filePath, string AppKey) {
            this.From = From;
            this.To = To;
            this.BCC = BCC;
            this.CC = CC;
            this.Body = Body;
            this.Subject = Subject;
            this.filePath = filePath;
            this.AppKey = AppKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GDSSendBulkeMailResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GDSSendBulkeMailResponse", Namespace="http://tempuri.org/", Order=0)]
        public GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponseBody Body;
        
        public GDSSendBulkeMailResponse() {
        }
        
        public GDSSendBulkeMailResponse(GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GDSSendBulkeMailResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GDSSendBulkeMailResult;
        
        public GDSSendBulkeMailResponseBody() {
        }
        
        public GDSSendBulkeMailResponseBody(string GDSSendBulkeMailResult) {
            this.GDSSendBulkeMailResult = GDSSendBulkeMailResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendBulkeMailSoapChannel : GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GDSSendBulkeMailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GDSSendBulkeMailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendBulkeMailSoapClient : System.ServiceModel.ClientBase<GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap>, GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap {
        
        private BeginOperationDelegate onBeginGDSSendBulkeMailDelegate;
        
        private EndOperationDelegate onEndGDSSendBulkeMailDelegate;
        
        private System.Threading.SendOrPostCallback onGDSSendBulkeMailCompletedDelegate;
        
        public SendBulkeMailSoapClient() {
        }
        
        public SendBulkeMailSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendBulkeMailSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendBulkeMailSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendBulkeMailSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GDSSendBulkeMailCompletedEventArgs> GDSSendBulkeMailCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponse GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap.GDSSendBulkeMail(GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest request) {
            return base.Channel.GDSSendBulkeMail(request);
        }
        
        public string GDSSendBulkeMail(string From, string To, string BCC, string CC, string Body, string Subject, string filePath, string AppKey) {
            GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest inValue = new GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest();
            inValue.Body = new GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequestBody();
            inValue.Body.From = From;
            inValue.Body.To = To;
            inValue.Body.BCC = BCC;
            inValue.Body.CC = CC;
            inValue.Body.Body = Body;
            inValue.Body.Subject = Subject;
            inValue.Body.filePath = filePath;
            inValue.Body.AppKey = AppKey;
            GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponse retVal = ((GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap)(this)).GDSSendBulkeMail(inValue);
            return retVal.Body.GDSSendBulkeMailResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap.BeginGDSSendBulkeMail(GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGDSSendBulkeMail(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGDSSendBulkeMail(string From, string To, string BCC, string CC, string Body, string Subject, string filePath, string AppKey, System.AsyncCallback callback, object asyncState) {
            GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest inValue = new GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequest();
            inValue.Body = new GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailRequestBody();
            inValue.Body.From = From;
            inValue.Body.To = To;
            inValue.Body.BCC = BCC;
            inValue.Body.CC = CC;
            inValue.Body.Body = Body;
            inValue.Body.Subject = Subject;
            inValue.Body.filePath = filePath;
            inValue.Body.AppKey = AppKey;
            return ((GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap)(this)).BeginGDSSendBulkeMail(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponse GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap.EndGDSSendBulkeMail(System.IAsyncResult result) {
            return base.Channel.EndGDSSendBulkeMail(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGDSSendBulkeMail(System.IAsyncResult result) {
            GDSstaffingportal.GDSBMServiceReference.GDSSendBulkeMailResponse retVal = ((GDSstaffingportal.GDSBMServiceReference.SendBulkeMailSoap)(this)).EndGDSSendBulkeMail(result);
            return retVal.Body.GDSSendBulkeMailResult;
        }
        
        private System.IAsyncResult OnBeginGDSSendBulkeMail(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string From = ((string)(inValues[0]));
            string To = ((string)(inValues[1]));
            string BCC = ((string)(inValues[2]));
            string CC = ((string)(inValues[3]));
            string Body = ((string)(inValues[4]));
            string Subject = ((string)(inValues[5]));
            string filePath = ((string)(inValues[6]));
            string AppKey = ((string)(inValues[7]));
            return this.BeginGDSSendBulkeMail(From, To, BCC, CC, Body, Subject, filePath, AppKey, callback, asyncState);
        }
        
        private object[] OnEndGDSSendBulkeMail(System.IAsyncResult result) {
            string retVal = this.EndGDSSendBulkeMail(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGDSSendBulkeMailCompleted(object state) {
            if ((this.GDSSendBulkeMailCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GDSSendBulkeMailCompleted(this, new GDSSendBulkeMailCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GDSSendBulkeMailAsync(string From, string To, string BCC, string CC, string Body, string Subject, string filePath, string AppKey) {
            this.GDSSendBulkeMailAsync(From, To, BCC, CC, Body, Subject, filePath, AppKey, null);
        }
        
        public void GDSSendBulkeMailAsync(string From, string To, string BCC, string CC, string Body, string Subject, string filePath, string AppKey, object userState) {
            if ((this.onBeginGDSSendBulkeMailDelegate == null)) {
                this.onBeginGDSSendBulkeMailDelegate = new BeginOperationDelegate(this.OnBeginGDSSendBulkeMail);
            }
            if ((this.onEndGDSSendBulkeMailDelegate == null)) {
                this.onEndGDSSendBulkeMailDelegate = new EndOperationDelegate(this.OnEndGDSSendBulkeMail);
            }
            if ((this.onGDSSendBulkeMailCompletedDelegate == null)) {
                this.onGDSSendBulkeMailCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGDSSendBulkeMailCompleted);
            }
            base.InvokeAsync(this.onBeginGDSSendBulkeMailDelegate, new object[] {
                        From,
                        To,
                        BCC,
                        CC,
                        Body,
                        Subject,
                        filePath,
                        AppKey}, this.onEndGDSSendBulkeMailDelegate, this.onGDSSendBulkeMailCompletedDelegate, userState);
        }
    }
}