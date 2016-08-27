
namespace OlgaSpaWebSite.OlgaSpaModule {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AppoinmentsDialog extends Serenity.EntityDialog<AppoinmentsRow, any> {
        protected getFormKey() { return AppoinmentsForm.formKey; }
        protected getIdProperty() { return AppoinmentsRow.idProperty; }
        protected getLocalTextPrefix() { return AppoinmentsRow.localTextPrefix; }
        protected getNameProperty() { return AppoinmentsRow.nameProperty; }
        protected getService() { return AppoinmentsService.baseUrl; }

        protected form = new AppoinmentsForm(this.idPrefix);
    }
}