
namespace OlgaSpaWebSite.OlgaSpaModule.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("OlgaSpaModule.Appoinments")]
    [BasedOnRow(typeof(Entities.AppoinmentsRow))]
    public class AppoinmentsForm
    {
        public Int64 IdCustomer { get; set; }
        public Int64 IdPackage { get; set; }
        public Int32 IdTreatment { get; set; }
        public DateTime StartDateDteAppointment { get; set; }
        public DateTime EndDateDteAppointment { get; set; }
        public String DescriptionAppoinment { get; set; }
    }
}