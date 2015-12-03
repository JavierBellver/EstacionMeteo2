﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace InterfazEstacion.EstMeteo {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EstacionMeteoSoap11Binding", Namespace="http://estacion")]
    public partial class EstacionMeteo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getPantallaOperationCompleted;
        
        private System.Threading.SendOrPostCallback ModificaOperationCompleted;
        
        private System.Threading.SendOrPostCallback setTemperaturaOperationCompleted;
        
        private System.Threading.SendOrPostCallback LecturaOperationCompleted;
        
        private System.Threading.SendOrPostCallback getHumedadOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTemperaturaOperationCompleted;
        
        private System.Threading.SendOrPostCallback setLuminosidadOperationCompleted;
        
        private System.Threading.SendOrPostCallback muestraContenidoOperationCompleted;
        
        private System.Threading.SendOrPostCallback getLuminosidadOperationCompleted;
        
        private System.Threading.SendOrPostCallback setMsgOperationCompleted;
        
        private System.Threading.SendOrPostCallback setHumedadOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EstacionMeteo() {
  
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
        public event getPantallaCompletedEventHandler getPantallaCompleted;
        
        /// <remarks/>
        public event ModificaCompletedEventHandler ModificaCompleted;
        
        /// <remarks/>
        public event setTemperaturaCompletedEventHandler setTemperaturaCompleted;
        
        /// <remarks/>
        public event LecturaCompletedEventHandler LecturaCompleted;
        
        /// <remarks/>
        public event getHumedadCompletedEventHandler getHumedadCompleted;
        
        /// <remarks/>
        public event getTemperaturaCompletedEventHandler getTemperaturaCompleted;
        
        /// <remarks/>
        public event setLuminosidadCompletedEventHandler setLuminosidadCompleted;
        
        /// <remarks/>
        public event muestraContenidoCompletedEventHandler muestraContenidoCompleted;
        
        /// <remarks/>
        public event getLuminosidadCompletedEventHandler getLuminosidadCompleted;
        
        /// <remarks/>
        public event setMsgCompletedEventHandler setMsgCompleted;
        
        /// <remarks/>
        public event setHumedadCompletedEventHandler setHumedadCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getPantalla", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getPantalla() {
            object[] results = this.Invoke("getPantalla", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getPantallaAsync() {
            this.getPantallaAsync(null);
        }
        
        /// <remarks/>
        public void getPantallaAsync(object userState) {
            if ((this.getPantallaOperationCompleted == null)) {
                this.getPantallaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPantallaOperationCompleted);
            }
            this.InvokeAsync("getPantalla", new object[0], this.getPantallaOperationCompleted, userState);
        }
        
        private void OngetPantallaOperationCompleted(object arg) {
            if ((this.getPantallaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPantallaCompleted(this, new getPantallaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:Modifica", RequestNamespace="http://estacion", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Modifica([System.Xml.Serialization.XmlElementAttribute("valores")] int[] valores) {
            this.Invoke("Modifica", new object[] {
                        valores});
        }
        
        /// <remarks/>
        public void ModificaAsync(int[] valores) {
            this.ModificaAsync(valores, null);
        }
        
        /// <remarks/>
        public void ModificaAsync(int[] valores, object userState) {
            if ((this.ModificaOperationCompleted == null)) {
                this.ModificaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnModificaOperationCompleted);
            }
            this.InvokeAsync("Modifica", new object[] {
                        valores}, this.ModificaOperationCompleted, userState);
        }
        
        private void OnModificaOperationCompleted(object arg) {
            if ((this.ModificaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ModificaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setTemperatura", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setTemperatura(int newTemp, [System.Xml.Serialization.XmlIgnoreAttribute()] bool newTempSpecified) {
            object[] results = this.Invoke("setTemperatura", new object[] {
                        newTemp,
                        newTempSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setTemperaturaAsync(int newTemp, bool newTempSpecified) {
            this.setTemperaturaAsync(newTemp, newTempSpecified, null);
        }
        
        /// <remarks/>
        public void setTemperaturaAsync(int newTemp, bool newTempSpecified, object userState) {
            if ((this.setTemperaturaOperationCompleted == null)) {
                this.setTemperaturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetTemperaturaOperationCompleted);
            }
            this.InvokeAsync("setTemperatura", new object[] {
                        newTemp,
                        newTempSpecified}, this.setTemperaturaOperationCompleted, userState);
        }
        
        private void OnsetTemperaturaOperationCompleted(object arg) {
            if ((this.setTemperaturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setTemperaturaCompleted(this, new setTemperaturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:Lectura", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public int[] Lectura([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Atributo, int nValor, [System.Xml.Serialization.XmlIgnoreAttribute()] bool nValorSpecified) {
            object[] results = this.Invoke("Lectura", new object[] {
                        Atributo,
                        nValor,
                        nValorSpecified});
            return ((int[])(results[0]));
        }
        
        /// <remarks/>
        public void LecturaAsync(string Atributo, int nValor, bool nValorSpecified) {
            this.LecturaAsync(Atributo, nValor, nValorSpecified, null);
        }
        
        /// <remarks/>
        public void LecturaAsync(string Atributo, int nValor, bool nValorSpecified, object userState) {
            if ((this.LecturaOperationCompleted == null)) {
                this.LecturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLecturaOperationCompleted);
            }
            this.InvokeAsync("Lectura", new object[] {
                        Atributo,
                        nValor,
                        nValorSpecified}, this.LecturaOperationCompleted, userState);
        }
        
        private void OnLecturaOperationCompleted(object arg) {
            if ((this.LecturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LecturaCompleted(this, new LecturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getHumedad", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getHumedad(out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified) {
            object[] results = this.Invoke("getHumedad", new object[0]);
            @return = ((int)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getHumedadAsync() {
            this.getHumedadAsync(null);
        }
        
        /// <remarks/>
        public void getHumedadAsync(object userState) {
            if ((this.getHumedadOperationCompleted == null)) {
                this.getHumedadOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHumedadOperationCompleted);
            }
            this.InvokeAsync("getHumedad", new object[0], this.getHumedadOperationCompleted, userState);
        }
        
        private void OngetHumedadOperationCompleted(object arg) {
            if ((this.getHumedadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getHumedadCompleted(this, new getHumedadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getTemperatura", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getTemperatura(out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified) {
            object[] results = this.Invoke("getTemperatura", new object[0]);
            @return = ((int)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getTemperaturaAsync() {
            this.getTemperaturaAsync(null);
        }
        
        /// <remarks/>
        public void getTemperaturaAsync(object userState) {
            if ((this.getTemperaturaOperationCompleted == null)) {
                this.getTemperaturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTemperaturaOperationCompleted);
            }
            this.InvokeAsync("getTemperatura", new object[0], this.getTemperaturaOperationCompleted, userState);
        }
        
        private void OngetTemperaturaOperationCompleted(object arg) {
            if ((this.getTemperaturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTemperaturaCompleted(this, new getTemperaturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setLuminosidad", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setLuminosidad(int newLum, [System.Xml.Serialization.XmlIgnoreAttribute()] bool newLumSpecified) {
            object[] results = this.Invoke("setLuminosidad", new object[] {
                        newLum,
                        newLumSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setLuminosidadAsync(int newLum, bool newLumSpecified) {
            this.setLuminosidadAsync(newLum, newLumSpecified, null);
        }
        
        /// <remarks/>
        public void setLuminosidadAsync(int newLum, bool newLumSpecified, object userState) {
            if ((this.setLuminosidadOperationCompleted == null)) {
                this.setLuminosidadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetLuminosidadOperationCompleted);
            }
            this.InvokeAsync("setLuminosidad", new object[] {
                        newLum,
                        newLumSpecified}, this.setLuminosidadOperationCompleted, userState);
        }
        
        private void OnsetLuminosidadOperationCompleted(object arg) {
            if ((this.setLuminosidadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setLuminosidadCompleted(this, new setLuminosidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:muestraContenido", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public int[] muestraContenido([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string archivo) {
            object[] results = this.Invoke("muestraContenido", new object[] {
                        archivo});
            return ((int[])(results[0]));
        }
        
        /// <remarks/>
        public void muestraContenidoAsync(string archivo) {
            this.muestraContenidoAsync(archivo, null);
        }
        
        /// <remarks/>
        public void muestraContenidoAsync(string archivo, object userState) {
            if ((this.muestraContenidoOperationCompleted == null)) {
                this.muestraContenidoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmuestraContenidoOperationCompleted);
            }
            this.InvokeAsync("muestraContenido", new object[] {
                        archivo}, this.muestraContenidoOperationCompleted, userState);
        }
        
        private void OnmuestraContenidoOperationCompleted(object arg) {
            if ((this.muestraContenidoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.muestraContenidoCompleted(this, new muestraContenidoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getLuminosidad", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getLuminosidad(out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified) {
            object[] results = this.Invoke("getLuminosidad", new object[0]);
            @return = ((int)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getLuminosidadAsync() {
            this.getLuminosidadAsync(null);
        }
        
        /// <remarks/>
        public void getLuminosidadAsync(object userState) {
            if ((this.getLuminosidadOperationCompleted == null)) {
                this.getLuminosidadOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLuminosidadOperationCompleted);
            }
            this.InvokeAsync("getLuminosidad", new object[0], this.getLuminosidadOperationCompleted, userState);
        }
        
        private void OngetLuminosidadOperationCompleted(object arg) {
            if ((this.getLuminosidadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLuminosidadCompleted(this, new getLuminosidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setMsg", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setMsg([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string newMsg) {
            object[] results = this.Invoke("setMsg", new object[] {
                        newMsg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setMsgAsync(string newMsg) {
            this.setMsgAsync(newMsg, null);
        }
        
        /// <remarks/>
        public void setMsgAsync(string newMsg, object userState) {
            if ((this.setMsgOperationCompleted == null)) {
                this.setMsgOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetMsgOperationCompleted);
            }
            this.InvokeAsync("setMsg", new object[] {
                        newMsg}, this.setMsgOperationCompleted, userState);
        }
        
        private void OnsetMsgOperationCompleted(object arg) {
            if ((this.setMsgCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setMsgCompleted(this, new setMsgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setHumedad", RequestNamespace="http://estacion", ResponseNamespace="http://estacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setHumedad(int newHum, [System.Xml.Serialization.XmlIgnoreAttribute()] bool newHumSpecified) {
            object[] results = this.Invoke("setHumedad", new object[] {
                        newHum,
                        newHumSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setHumedadAsync(int newHum, bool newHumSpecified) {
            this.setHumedadAsync(newHum, newHumSpecified, null);
        }
        
        /// <remarks/>
        public void setHumedadAsync(int newHum, bool newHumSpecified, object userState) {
            if ((this.setHumedadOperationCompleted == null)) {
                this.setHumedadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetHumedadOperationCompleted);
            }
            this.InvokeAsync("setHumedad", new object[] {
                        newHum,
                        newHumSpecified}, this.setHumedadOperationCompleted, userState);
        }
        
        private void OnsetHumedadOperationCompleted(object arg) {
            if ((this.setHumedadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setHumedadCompleted(this, new setHumedadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void getPantallaCompletedEventHandler(object sender, getPantallaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPantallaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPantallaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ModificaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void setTemperaturaCompletedEventHandler(object sender, setTemperaturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setTemperaturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setTemperaturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void LecturaCompletedEventHandler(object sender, LecturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LecturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LecturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void getHumedadCompletedEventHandler(object sender, getHumedadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getHumedadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getHumedadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int @return {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void getTemperaturaCompletedEventHandler(object sender, getTemperaturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTemperaturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTemperaturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int @return {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void setLuminosidadCompletedEventHandler(object sender, setLuminosidadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setLuminosidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setLuminosidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void muestraContenidoCompletedEventHandler(object sender, muestraContenidoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class muestraContenidoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal muestraContenidoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void getLuminosidadCompletedEventHandler(object sender, getLuminosidadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLuminosidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getLuminosidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int @return {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void setMsgCompletedEventHandler(object sender, setMsgCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setMsgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setMsgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void setHumedadCompletedEventHandler(object sender, setHumedadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setHumedadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setHumedadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591