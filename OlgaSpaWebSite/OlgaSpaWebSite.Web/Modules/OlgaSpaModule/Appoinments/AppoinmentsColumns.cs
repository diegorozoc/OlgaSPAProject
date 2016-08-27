
namespace OlgaSpaWebSite.OlgaSpaModule.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("OlgaSpaModule.Appoinments")]
    [BasedOnRow(typeof(Entities.AppoinmentsRow))]
    public class AppoinmentsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 IdAppointment { get; set; }
        public Int64 IdCustomer { get; set; }
        public Int64 IdPackage { get; set; }
        public Int32 IdTreatment { get; set; }
        public DateTime StartDateDteAppointment { get; set; }
        public DateTime EndDateDteAppointment { get; set; }
        [EditLink]
        public String DescriptionAppoinment { get; set; }
    }
}