
namespace OlgaSpaWebSite.OlgaSpaModule.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("OlgaSpaModule.Treatments")]
    [BasedOnRow(typeof(Entities.TreatmentsRow))]
    public class TreatmentsForm
    {
        public String DescriptionTreatment { get; set; }
    }
}