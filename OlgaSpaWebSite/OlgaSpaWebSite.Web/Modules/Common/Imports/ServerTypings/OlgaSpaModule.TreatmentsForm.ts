namespace OlgaSpaWebSite.OlgaSpaModule {
    export class TreatmentsForm extends Serenity.PrefixedContext {
        static formKey = 'OlgaSpaModule.Treatments';

    }

    export interface TreatmentsForm {
        DescriptionTreatment: Serenity.StringEditor;
    }

    [['DescriptionTreatment', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(TreatmentsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

