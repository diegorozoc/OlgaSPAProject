namespace OlgaSpaWebSite.OlgaSpaModule {
    export class PackagesForm extends Serenity.PrefixedContext {
        static formKey = 'OlgaSpaModule.Packages';

    }

    export interface PackagesForm {
        DescriptionPackage: Serenity.StringEditor;
        SuggestedCost: Serenity.DecimalEditor;
        Sessions: Serenity.IntegerEditor;
    }

    [['DescriptionPackage', () => Serenity.StringEditor], ['SuggestedCost', () => Serenity.DecimalEditor], ['Sessions', () => Serenity.IntegerEditor]].forEach(x => Object.defineProperty(PackagesForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

