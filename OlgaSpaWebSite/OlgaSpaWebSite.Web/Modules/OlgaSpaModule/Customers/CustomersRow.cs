

namespace OlgaSpaWebSite.OlgaSpaModule.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Customers"), InstanceName("Customers"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    [LookupScript("OlgaSpaModule.Customers")]
    public sealed class CustomersRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Customer"), Column("id_customer"), Identity]
        public Int64? IdCustomer
        {
            get { return Fields.IdCustomer[this]; }
            set { Fields.IdCustomer[this] = value; }
        }

        [DisplayName("First Name Customer"), Column("first_name_customer"), Size(50), NotNull, QuickSearch]
        public String FirstNameCustomer
        {
            get { return Fields.FirstNameCustomer[this]; }
            set { Fields.FirstNameCustomer[this] = value; }
        }

        [DisplayName("Last Name Customer"), Column("last_name_customer"), Size(50)]
        public String LastNameCustomer
        {
            get { return Fields.LastNameCustomer[this]; }
            set { Fields.LastNameCustomer[this] = value; }
        }

        [DisplayName("Full Name"), Expression("(first_name_customer + ' ' + last_name_customer)"), QuickSearch]
        public String FullNameCustomer
        {
            get { return Fields.FullNameCustomer[this]; }
            set { Fields.FullNameCustomer[this] = value; }
        }

        [DisplayName("Email"), Column("email"), Size(60)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Address"), Column("address"), Size(100)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Contact Number1"), Column("contact_number1"), Size(24)]
        public String ContactNumber1
        {
            get { return Fields.ContactNumber1[this]; }
            set { Fields.ContactNumber1[this] = value; }
        }

        [DisplayName("Contact Number2"), Column("contact_number2"), Size(24)]
        public String ContactNumber2
        {
            get { return Fields.ContactNumber2[this]; }
            set { Fields.ContactNumber2[this] = value; }
        }

        [DisplayName("Country"), Column("country"), Size(15)]
        public String Country
        {
            get { return Fields.Country[this]; }
            set { Fields.Country[this] = value; }
        }

        [DisplayName("City"), Column("city"), Size(15)]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        [DisplayName("Registration Date"), Column("registration_date"), NotNull]
        public DateTime? RegistrationDate
        {
            get { return Fields.RegistrationDate[this]; }
            set { Fields.RegistrationDate[this] = value; }
        }

        [DisplayName("Modification Date"), Column("modification_date")]
        public DateTime? ModificationDate
        {
            get { return Fields.ModificationDate[this]; }
            set { Fields.ModificationDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdCustomer; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FullNameCustomer; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field IdCustomer;
            public StringField FirstNameCustomer;
            public StringField LastNameCustomer;
            public StringField FullNameCustomer;
            public StringField Email;
            public StringField Address;
            public StringField ContactNumber1;
            public StringField ContactNumber2;
            public StringField Country;
            public StringField City;
            public DateTimeField RegistrationDate;
            public DateTimeField ModificationDate;

            public RowFields()
                : base("[dbo].[Customers]")
            {
                LocalTextPrefix = "OlgaSpaModule.Customers";
            }
        }
    }
}