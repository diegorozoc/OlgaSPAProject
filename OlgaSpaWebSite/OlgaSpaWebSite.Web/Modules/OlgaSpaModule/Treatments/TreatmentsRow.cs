

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

    [ConnectionKey("Default"), DisplayName("Treatments"), InstanceName("Treatments"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class TreatmentsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Treatment"), Column("id_treatment"), Identity]
        public Int32? IdTreatment
        {
            get { return Fields.IdTreatment[this]; }
            set { Fields.IdTreatment[this] = value; }
        }

        [DisplayName("Description Treatment"), Column("description_treatment"), Size(50), NotNull, QuickSearch]
        public String DescriptionTreatment
        {
            get { return Fields.DescriptionTreatment[this]; }
            set { Fields.DescriptionTreatment[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdTreatment; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DescriptionTreatment; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TreatmentsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdTreatment;
            public StringField DescriptionTreatment;

            public RowFields()
                : base("[dbo].[Treatments]")
            {
                LocalTextPrefix = "OlgaSpaModule.Treatments";
            }
        }
    }
}