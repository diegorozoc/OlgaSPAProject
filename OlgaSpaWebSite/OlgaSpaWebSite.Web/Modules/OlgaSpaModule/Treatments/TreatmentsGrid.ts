
namespace OlgaSpaWebSite.OlgaSpaModule {
    
    @Serenity.Decorators.registerClass()
    export class TreatmentsGrid extends Serenity.EntityGrid<TreatmentsRow, any> {
        protected getColumnsKey() { return 'OlgaSpaModule.Treatments'; }
        protected getDialogType() { return TreatmentsDialog; }
        protected getIdProperty() { return TreatmentsRow.idProperty; }
        protected getLocalTextPrefix() { return TreatmentsRow.localTextPrefix; }
        protected getService() { return TreatmentsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}