

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

    [ConnectionKey("Default"), DisplayName("Appoinments"), InstanceName("Appoinments"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class AppoinmentsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Appointment"), Column("id_appointment"), Identity]
        public Int64? IdAppointment
        {
            get { return Fields.IdAppointment[this]; }
            set { Fields.IdAppointment[this] = value; }
        }

        [LookupEditor("OlgaSpaModule.Customers")]
        [DisplayName("Customer Name"), Column("id_customer"), NotNull, ForeignKey("[dbo].[Customers]", "id_customer"), LeftJoin("Customer")/*, TextualField("CustomerName")*/]
        public Int64? IdCustomer
        {
            get { return Fields.IdCustomer[this]; }
            set { Fields.IdCustomer[this] = value; }
        }

       /* [DisplayName("Customer Name"), Expression("Customer.[last_name_customer]")]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }*/

        [DisplayName("Id Package"), Column("id_package"), ForeignKey("[dbo].[Packages]", "id_package"), LeftJoin("jIdPackage"), TextualField("IdPackageDescriptionPackage")]
        public Int64? IdPackage
        {
            get { return Fields.IdPackage[this]; }
            set { Fields.IdPackage[this] = value; }
        }

        [DisplayName("Id Treatment"), Column("id_treatment"), ForeignKey("[dbo].[Treatments]", "id_treatment"), LeftJoin("jIdTreatment"), TextualField("IdTreatmentDescriptionTreatment")]
        public Int32? IdTreatment
        {
            get { return Fields.IdTreatment[this]; }
            set { Fields.IdTreatment[this] = value; }
        }

        [DisplayName("Start Date Dte Appointment"), Column("startDate_dte_appointment"), NotNull]
        public DateTime? StartDateDteAppointment
        {
            get { return Fields.StartDateDteAppointment[this]; }
            set { Fields.StartDateDteAppointment[this] = value; }
        }

        [DisplayName("End Date Dte Appointment"), Column("endDate_dte_appointment"), NotNull]
        public DateTime? EndDateDteAppointment
        {
            get { return Fields.EndDateDteAppointment[this]; }
            set { Fields.EndDateDteAppointment[this] = value; }
        }

        [DisplayName("Description Appoinment"), Column("description_appoinment"), QuickSearch]
        public String DescriptionAppoinment
        {
            get { return Fields.DescriptionAppoinment[this]; }
            set { Fields.DescriptionAppoinment[this] = value; }
        }

        /*[DisplayName("Id Customer First Name Customer"), Expression("jIdCustomer.[first_name_customer]")]
        public String IdCustomerFirstNameCustomer
        {
            get { return Fields.IdCustomerFirstNameCustomer[this]; }
            set { Fields.IdCustomerFirstNameCustomer[this] = value; }
        }

        [DisplayName("Id Customer Last Name Customer"), Expression("jIdCustomer.[last_name_customer]")]
        public String IdCustomerLastNameCustomer
        {
            get { return Fields.IdCustomerLastNameCustomer[this]; }
            set { Fields.IdCustomerLastNameCustomer[this] = value; }
        }

        [DisplayName("Id Customer Email"), Expression("jIdCustomer.[email]")]
        public String IdCustomerEmail
        {
            get { return Fields.IdCustomerEmail[this]; }
            set { Fields.IdCustomerEmail[this] = value; }
        }

        [DisplayName("Id Customer Address"), Expression("jIdCustomer.[address]")]
        public String IdCustomerAddress
        {
            get { return Fields.IdCustomerAddress[this]; }
            set { Fields.IdCustomerAddress[this] = value; }
        }

        [DisplayName("Id Customer Contact Number1"), Expression("jIdCustomer.[contact_number1]")]
        public String IdCustomerContactNumber1
        {
            get { return Fields.IdCustomerContactNumber1[this]; }
            set { Fields.IdCustomerContactNumber1[this] = value; }
        }

        [DisplayName("Id Customer Contact Number2"), Expression("jIdCustomer.[contact_number2]")]
        public String IdCustomerContactNumber2
        {
            get { return Fields.IdCustomerContactNumber2[this]; }
            set { Fields.IdCustomerContactNumber2[this] = value; }
        }

        [DisplayName("Id Customer Country"), Expression("jIdCustomer.[country]")]
        public String IdCustomerCountry
        {
            get { return Fields.IdCustomerCountry[this]; }
            set { Fields.IdCustomerCountry[this] = value; }
        }

        [DisplayName("Id Customer City"), Expression("jIdCustomer.[city]")]
        public String IdCustomerCity
        {
            get { return Fields.IdCustomerCity[this]; }
            set { Fields.IdCustomerCity[this] = value; }
        }

        [DisplayName("Id Customer Registration Date"), Expression("jIdCustomer.[registration_date]")]
        public DateTime? IdCustomerRegistrationDate
        {
            get { return Fields.IdCustomerRegistrationDate[this]; }
            set { Fields.IdCustomerRegistrationDate[this] = value; }
        }

        [DisplayName("Id Customer Modification Date"), Expression("jIdCustomer.[modification_date]")]
        public DateTime? IdCustomerModificationDate
        {
            get { return Fields.IdCustomerModificationDate[this]; }
            set { Fields.IdCustomerModificationDate[this] = value; }
        }

        [DisplayName("Id Package Description Package"), Expression("jIdPackage.[description_package]")]
        public String IdPackageDescriptionPackage
        {
            get { return Fields.IdPackageDescriptionPackage[this]; }
            set { Fields.IdPackageDescriptionPackage[this] = value; }
        }

        [DisplayName("Id Package Suggested Cost"), Expression("jIdPackage.[suggested_cost]")]
        public Decimal? IdPackageSuggestedCost
        {
            get { return Fields.IdPackageSuggestedCost[this]; }
            set { Fields.IdPackageSuggestedCost[this] = value; }
        }

        [DisplayName("Id Package Sessions"), Expression("jIdPackage.[Sessions]")]
        public Int32? IdPackageSessions
        {
            get { return Fields.IdPackageSessions[this]; }
            set { Fields.IdPackageSessions[this] = value; }
        }

        [DisplayName("Id Treatment Description Treatment"), Expression("jIdTreatment.[description_treatment]")]
        public String IdTreatmentDescriptionTreatment
        {
            get { return Fields.IdTreatmentDescriptionTreatment[this]; }
            set { Fields.IdTreatmentDescriptionTreatment[this] = value; }
        }*/

        IIdField IIdRow.IdField
        {
            get { return Fields.IdAppointment; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DescriptionAppoinment; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AppoinmentsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field IdAppointment;
            public Int64Field IdCustomer;
            /*public StringField CustomerName;*/
            public Int64Field IdPackage;
            public Int32Field IdTreatment;
            public DateTimeField StartDateDteAppointment;
            public DateTimeField EndDateDteAppointment;
            public StringField DescriptionAppoinment;

            /*public StringField IdCustomerFirstNameCustomer;
            public StringField IdCustomerLastNameCustomer;
            public StringField IdCustomerEmail;
            public StringField IdCustomerAddress;
            public StringField IdCustomerContactNumber1;
            public StringField IdCustomerContactNumber2;
            public StringField IdCustomerCountry;
            public StringField IdCustomerCity;
            public DateTimeField IdCustomerRegistrationDate;
            public DateTimeField IdCustomerModificationDate;

            public StringField IdPackageDescriptionPackage;
            public DecimalField IdPackageSuggestedCost;
            public Int32Field IdPackageSessions;

            public StringField IdTreatmentDescriptionTreatment;*/

            public RowFields()
                : base("[dbo].[Appoinments]")
            {
                LocalTextPrefix = "OlgaSpaModule.Appoinments";
            }
        }
    }
}