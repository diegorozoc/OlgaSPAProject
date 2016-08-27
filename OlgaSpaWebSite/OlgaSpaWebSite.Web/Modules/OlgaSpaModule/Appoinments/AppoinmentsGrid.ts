
namespace OlgaSpaWebSite.OlgaSpaModule {
    
    @Serenity.Decorators.registerClass()
    export class AppoinmentsGrid extends Serenity.EntityGrid<AppoinmentsRow, any> {
        protected getColumnsKey() { return 'OlgaSpaModule.Appoinments'; }
        protected getDialogType() { return AppoinmentsDialog; }
        protected getIdProperty() { return AppoinmentsRow.idProperty; }
        protected getLocalTextPrefix() { return AppoinmentsRow.localTextPrefix; }
        protected getService() { return AppoinmentsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}