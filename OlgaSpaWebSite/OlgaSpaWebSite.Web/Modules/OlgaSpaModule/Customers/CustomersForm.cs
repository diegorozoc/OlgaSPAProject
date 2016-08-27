
namespace OlgaSpaWebSite.OlgaSpaModule.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("OlgaSpaModule.Customers")]
    [BasedOnRow(typeof(Entities.CustomersRow))]
    public class CustomersForm
    {
        public String FirstNameCustomer { get; set; }
        public String LastNameCustomer { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        public String Address { get; set; }
        public String ContactNumber1 { get; set; }
        public String ContactNumber2 { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}