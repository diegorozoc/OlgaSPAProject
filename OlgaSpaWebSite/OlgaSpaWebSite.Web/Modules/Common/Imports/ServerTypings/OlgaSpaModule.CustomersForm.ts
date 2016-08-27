namespace OlgaSpaWebSite.OlgaSpaModule {
    export class CustomersForm extends Serenity.PrefixedContext {
        static formKey = 'OlgaSpaModule.Customers';

    }

    export interface CustomersForm {
        FirstNameCustomer: Serenity.StringEditor;
        LastNameCustomer: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        Address: Serenity.StringEditor;
        ContactNumber1: Serenity.StringEditor;
        ContactNumber2: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        City: Serenity.StringEditor;
        RegistrationDate: Serenity.DateEditor;
        ModificationDate: Serenity.DateEditor;
    }

    [['FirstNameCustomer', () => Serenity.StringEditor], ['LastNameCustomer', () => Serenity.StringEditor], ['Email', () => Serenity.EmailEditor], ['Address', () => Serenity.StringEditor], ['ContactNumber1', () => Serenity.StringEditor], ['ContactNumber2', () => Serenity.StringEditor], ['Country', () => Serenity.StringEditor], ['City', () => Serenity.StringEditor], ['RegistrationDate', () => Serenity.DateEditor], ['ModificationDate', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(CustomersForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

