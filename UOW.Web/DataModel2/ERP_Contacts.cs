//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOW.Web.DataModel2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ERP_Contacts
    {
        public int ID { get; set; }
        public string ContactName { get; set; }
        public string Organisation { get; set; }
        public Nullable<double> VAT { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public Nullable<System.DateTime> LastUse { get; set; }
        public string ProfilePix { get; set; }
        public Nullable<bool> AutoGenerated { get; set; }
        public int LanguageID { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Notes { get; set; }
        public Nullable<int> PaymentType { get; set; }
        public string CustomInput1 { get; set; }
        public string CustomInput2 { get; set; }
        public string CustomInput3 { get; set; }
        public Nullable<int> CustomSelection1 { get; set; }
        public Nullable<int> CustomSelection2 { get; set; }
        public Nullable<int> CustomSelection3 { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string CustomInput4 { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public string BillingName { get; set; }
        public string BillingStreetAddress { get; set; }
        public string BillingPostCode { get; set; }
        public string BillingCity { get; set; }
        public string NotesInternal { get; set; }
    }
}
