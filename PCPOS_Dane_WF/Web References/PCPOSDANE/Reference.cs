﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PCPOS_Dane_WF.PCPOSDANE {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PCPOS_DataFromSqlSoap", Namespace="http://tempuri.org/")]
    public partial class PCPOS_DataFromSql : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback PcPosParagonyOperationCompleted;
        
        private System.Threading.SendOrPostCallback PcPosParDatyOperationCompleted;
        
        private System.Threading.SendOrPostCallback PcPosParItemsOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListaSklepowOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebMetOdczytajKonfigOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebMetOdczytajListęSklepówOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebMetDostępDBOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PCPOS_DataFromSql() {
            this.Url = global::PCPOS_Dane_WF.Properties.Settings.Default.PCPOS_Dane_WF_PCPOSDANE_PCPOS_DataFromSql;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event PcPosParagonyCompletedEventHandler PcPosParagonyCompleted;
        
        /// <remarks/>
        public event PcPosParDatyCompletedEventHandler PcPosParDatyCompleted;
        
        /// <remarks/>
        public event PcPosParItemsCompletedEventHandler PcPosParItemsCompleted;
        
        /// <remarks/>
        public event ListaSklepowCompletedEventHandler ListaSklepowCompleted;
        
        /// <remarks/>
        public event WebMetOdczytajKonfigCompletedEventHandler WebMetOdczytajKonfigCompleted;
        
        /// <remarks/>
        public event WebMetOdczytajListęSklepówCompletedEventHandler WebMetOdczytajListęSklepówCompleted;
        
        /// <remarks/>
        public event WebMetDostępDBCompletedEventHandler WebMetDostępDBCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PcPosParagony", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet PcPosParagony(string ip) {
            object[] results = this.Invoke("PcPosParagony", new object[] {
                        ip});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void PcPosParagonyAsync(string ip) {
            this.PcPosParagonyAsync(ip, null);
        }
        
        /// <remarks/>
        public void PcPosParagonyAsync(string ip, object userState) {
            if ((this.PcPosParagonyOperationCompleted == null)) {
                this.PcPosParagonyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPcPosParagonyOperationCompleted);
            }
            this.InvokeAsync("PcPosParagony", new object[] {
                        ip}, this.PcPosParagonyOperationCompleted, userState);
        }
        
        private void OnPcPosParagonyOperationCompleted(object arg) {
            if ((this.PcPosParagonyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PcPosParagonyCompleted(this, new PcPosParagonyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PcPosParDaty", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet PcPosParDaty(string ip, string DataStart, string DataStop) {
            object[] results = this.Invoke("PcPosParDaty", new object[] {
                        ip,
                        DataStart,
                        DataStop});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void PcPosParDatyAsync(string ip, string DataStart, string DataStop) {
            this.PcPosParDatyAsync(ip, DataStart, DataStop, null);
        }
        
        /// <remarks/>
        public void PcPosParDatyAsync(string ip, string DataStart, string DataStop, object userState) {
            if ((this.PcPosParDatyOperationCompleted == null)) {
                this.PcPosParDatyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPcPosParDatyOperationCompleted);
            }
            this.InvokeAsync("PcPosParDaty", new object[] {
                        ip,
                        DataStart,
                        DataStop}, this.PcPosParDatyOperationCompleted, userState);
        }
        
        private void OnPcPosParDatyOperationCompleted(object arg) {
            if ((this.PcPosParDatyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PcPosParDatyCompleted(this, new PcPosParDatyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PcPosParItems", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet PcPosParItems(string ip, int posid, int receiptid) {
            object[] results = this.Invoke("PcPosParItems", new object[] {
                        ip,
                        posid,
                        receiptid});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void PcPosParItemsAsync(string ip, int posid, int receiptid) {
            this.PcPosParItemsAsync(ip, posid, receiptid, null);
        }
        
        /// <remarks/>
        public void PcPosParItemsAsync(string ip, int posid, int receiptid, object userState) {
            if ((this.PcPosParItemsOperationCompleted == null)) {
                this.PcPosParItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPcPosParItemsOperationCompleted);
            }
            this.InvokeAsync("PcPosParItems", new object[] {
                        ip,
                        posid,
                        receiptid}, this.PcPosParItemsOperationCompleted, userState);
        }
        
        private void OnPcPosParItemsOperationCompleted(object arg) {
            if ((this.PcPosParItemsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PcPosParItemsCompleted(this, new PcPosParItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListaSklepow", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ListaSklepow() {
            this.Invoke("ListaSklepow", new object[0]);
        }
        
        /// <remarks/>
        public void ListaSklepowAsync() {
            this.ListaSklepowAsync(null);
        }
        
        /// <remarks/>
        public void ListaSklepowAsync(object userState) {
            if ((this.ListaSklepowOperationCompleted == null)) {
                this.ListaSklepowOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListaSklepowOperationCompleted);
            }
            this.InvokeAsync("ListaSklepow", new object[0], this.ListaSklepowOperationCompleted, userState);
        }
        
        private void OnListaSklepowOperationCompleted(object arg) {
            if ((this.ListaSklepowCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListaSklepowCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebMetOdczytajKonfig", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Information WebMetOdczytajKonfig() {
            object[] results = this.Invoke("WebMetOdczytajKonfig", new object[0]);
            return ((Information)(results[0]));
        }
        
        /// <remarks/>
        public void WebMetOdczytajKonfigAsync() {
            this.WebMetOdczytajKonfigAsync(null);
        }
        
        /// <remarks/>
        public void WebMetOdczytajKonfigAsync(object userState) {
            if ((this.WebMetOdczytajKonfigOperationCompleted == null)) {
                this.WebMetOdczytajKonfigOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebMetOdczytajKonfigOperationCompleted);
            }
            this.InvokeAsync("WebMetOdczytajKonfig", new object[0], this.WebMetOdczytajKonfigOperationCompleted, userState);
        }
        
        private void OnWebMetOdczytajKonfigOperationCompleted(object arg) {
            if ((this.WebMetOdczytajKonfigCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebMetOdczytajKonfigCompleted(this, new WebMetOdczytajKonfigCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebMetOdczytajListęSklepów", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet WebMetOdczytajListęSklepów() {
            object[] results = this.Invoke("WebMetOdczytajListęSklepów", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void WebMetOdczytajListęSklepówAsync() {
            this.WebMetOdczytajListęSklepówAsync(null);
        }
        
        /// <remarks/>
        public void WebMetOdczytajListęSklepówAsync(object userState) {
            if ((this.WebMetOdczytajListęSklepówOperationCompleted == null)) {
                this.WebMetOdczytajListęSklepówOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebMetOdczytajListęSklepówOperationCompleted);
            }
            this.InvokeAsync("WebMetOdczytajListęSklepów", new object[0], this.WebMetOdczytajListęSklepówOperationCompleted, userState);
        }
        
        private void OnWebMetOdczytajListęSklepówOperationCompleted(object arg) {
            if ((this.WebMetOdczytajListęSklepówCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebMetOdczytajListęSklepówCompleted(this, new WebMetOdczytajListęSklepówCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebMetDostępDB", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet WebMetDostępDB(string ipsrv) {
            object[] results = this.Invoke("WebMetDostępDB", new object[] {
                        ipsrv});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void WebMetDostępDBAsync(string ipsrv) {
            this.WebMetDostępDBAsync(ipsrv, null);
        }
        
        /// <remarks/>
        public void WebMetDostępDBAsync(string ipsrv, object userState) {
            if ((this.WebMetDostępDBOperationCompleted == null)) {
                this.WebMetDostępDBOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebMetDostępDBOperationCompleted);
            }
            this.InvokeAsync("WebMetDostępDB", new object[] {
                        ipsrv}, this.WebMetDostępDBOperationCompleted, userState);
        }
        
        private void OnWebMetDostępDBOperationCompleted(object arg) {
            if ((this.WebMetDostępDBCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebMetDostępDBCompleted(this, new WebMetDostępDBCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Information {
        
        private string sQLSRVField;
        
        private string dBNAMEField;
        
        private string userIdField;
        
        private string passwordField;
        
        /// <remarks/>
        public string SQLSRV {
            get {
                return this.sQLSRVField;
            }
            set {
                this.sQLSRVField = value;
            }
        }
        
        /// <remarks/>
        public string DBNAME {
            get {
                return this.dBNAMEField;
            }
            set {
                this.dBNAMEField = value;
            }
        }
        
        /// <remarks/>
        public string UserId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void PcPosParagonyCompletedEventHandler(object sender, PcPosParagonyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PcPosParagonyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PcPosParagonyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void PcPosParDatyCompletedEventHandler(object sender, PcPosParDatyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PcPosParDatyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PcPosParDatyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void PcPosParItemsCompletedEventHandler(object sender, PcPosParItemsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PcPosParItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PcPosParItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ListaSklepowCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void WebMetOdczytajKonfigCompletedEventHandler(object sender, WebMetOdczytajKonfigCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebMetOdczytajKonfigCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebMetOdczytajKonfigCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Information Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Information)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void WebMetOdczytajListęSklepówCompletedEventHandler(object sender, WebMetOdczytajListęSklepówCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebMetOdczytajListęSklepówCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebMetOdczytajListęSklepówCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void WebMetDostępDBCompletedEventHandler(object sender, WebMetDostępDBCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebMetDostępDBCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebMetDostępDBCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591