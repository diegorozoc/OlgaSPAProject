namespace OlgaSpaWebSite.OlgaSpaModule {
    export class AppoinmentsForm extends Serenity.PrefixedContext {
        static formKey = 'OlgaSpaModule.Appoinments';

    }

    export interface AppoinmentsForm {
        IdCustomer: Serenity.LookupEditor;
        IdPackage: Serenity.StringEditor;
        IdTreatment: Serenity.IntegerEditor;
        StartDateDteAppointment: Serenity.DateEditor;
        EndDateDteAppointment: Serenity.DateEditor;
        DescriptionAppoinment: Serenity.StringEditor;
    }

    [['IdCustomer', () => Serenity.LookupEditor], ['IdPackage', () => Serenity.StringEditor], ['IdTreatment', () => Serenity.IntegerEditor], ['StartDateDteAppointment', () => Serenity.DateEditor], ['EndDateDteAppointment', () => Serenity.DateEditor], ['DescriptionAppoinment', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(AppoinmentsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

