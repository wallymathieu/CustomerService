﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace Customers
{
    [ServiceContract(Namespace = "http://www.galasoft.ch")]
    public interface ICustomerService
    {
        [WebInvoke(Method = "GET",
 BodyStyle = WebMessageBodyStyle.WrappedRequest,
 ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract(Action = "http://www.galasoft.ch/CustomerService/GetCustomers", ReplyAction = "http://www.galasoft.ch/CustomerService/GetCustomersResponse")]
        Customers.Customer[] GetCustomers(string lastName);

        [WebInvoke(Method = "GET",
BodyStyle = WebMessageBodyStyle.WrappedRequest,
ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract(Action = "http://www.galasoft.ch/CustomerService/GetCustomerByAccountNumber", ReplyAction = "http://www.galasoft.ch/CustomerService/GetCustomerByAccountNumberResponse")]
        Customers.Customer GetCustomerByAccountNumber(int accountNumber);

        [WebInvoke(Method = "GET",
 BodyStyle = WebMessageBodyStyle.WrappedRequest,
 ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract(Action = "http://www.galasoft.ch/CustomerService/GetAllCustomers", ReplyAction = "http://www.galasoft.ch/CustomerService/GetAllCustomersResponse")]
        Customers.Customer[] GetAllCustomers();

        [WebInvoke(Method = "POST",
BodyStyle = WebMessageBodyStyle.WrappedRequest,
ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract(Action = "http://www.galasoft.ch/CustomerService/SaveCustomer", ReplyAction = "http://www.galasoft.ch/CustomerService/SaveCustomerResponse")]
        bool SaveCustomer(Customers.Customer editedCustomer);

        [WebInvoke(Method = "POST",
BodyStyle = WebMessageBodyStyle.WrappedRequest,
ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract(Action = "http://www.galasoft.ch/CustomerService/SaveCustomerLastName", ReplyAction = "http://www.galasoft.ch/CustomerService/SaveCustomerLastNameResponse")]
        bool SaveCustomerLastName(string accountNumber, string newName);
    }
}