
namespace OlgaSpaWebSite.OlgaSpaModule.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("OlgaSpaModule.Treatments")]
    [BasedOnRow(typeof(Entities.TreatmentsRow))]
    public class TreatmentsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdTreatment { get; set; }
        [EditLink]
        public String DescriptionTreatment { get; set; }
    }
}