﻿
namespace OlgaSpaWebSite.OlgaSpaModule {
    
    @Serenity.Decorators.registerClass()
    export class CustomersGrid extends Serenity.EntityGrid<CustomersRow, any> {
        protected getColumnsKey() { return 'OlgaSpaModule.Customers'; }
        protected getDialogType() { return CustomersDialog; }
        protected getIdProperty() { return CustomersRow.idProperty; }
        protected getLocalTextPrefix() { return CustomersRow.localTextPrefix; }
        protected getService() { return CustomersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}