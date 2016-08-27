
namespace OlgaSpaWebSite.OlgaSpaModule {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TreatmentsDialog extends Serenity.EntityDialog<TreatmentsRow, any> {
        protected getFormKey() { return TreatmentsForm.formKey; }
        protected getIdProperty() { return TreatmentsRow.idProperty; }
        protected getLocalTextPrefix() { return TreatmentsRow.localTextPrefix; }
        protected getNameProperty() { return TreatmentsRow.nameProperty; }
        protected getService() { return TreatmentsService.baseUrl; }

        protected form = new TreatmentsForm(this.idPrefix);
    }
}