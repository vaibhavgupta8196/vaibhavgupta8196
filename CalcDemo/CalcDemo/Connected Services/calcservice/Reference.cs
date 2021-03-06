﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalcDemo.calcservice {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="calcservice.CalcServiceSoap")]
    public interface CalcServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add", ReplyAction="*")]
        double add(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add", ReplyAction="*")]
        System.Threading.Tasks.Task<double> addAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sub", ReplyAction="*")]
        double sub(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sub", ReplyAction="*")]
        System.Threading.Tasks.Task<double> subAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiply", ReplyAction="*")]
        double multiply(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<double> multiplyAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/division", ReplyAction="*")]
        double division(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/division", ReplyAction="*")]
        System.Threading.Tasks.Task<double> divisionAsync(double x, double y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalcServiceSoapChannel : CalcDemo.calcservice.CalcServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceSoapClient : System.ServiceModel.ClientBase<CalcDemo.calcservice.CalcServiceSoap>, CalcDemo.calcservice.CalcServiceSoap {
        
        public CalcServiceSoapClient() {
        }
        
        public CalcServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double add(double x, double y) {
            return base.Channel.add(x, y);
        }
        
        public System.Threading.Tasks.Task<double> addAsync(double x, double y) {
            return base.Channel.addAsync(x, y);
        }
        
        public double sub(double x, double y) {
            return base.Channel.sub(x, y);
        }
        
        public System.Threading.Tasks.Task<double> subAsync(double x, double y) {
            return base.Channel.subAsync(x, y);
        }
        
        public double multiply(double x, double y) {
            return base.Channel.multiply(x, y);
        }
        
        public System.Threading.Tasks.Task<double> multiplyAsync(double x, double y) {
            return base.Channel.multiplyAsync(x, y);
        }
        
        public double division(double x, double y) {
            return base.Channel.division(x, y);
        }
        
        public System.Threading.Tasks.Task<double> divisionAsync(double x, double y) {
            return base.Channel.divisionAsync(x, y);
        }
    }
}
