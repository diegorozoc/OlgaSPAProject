namespace OlgaSpaWebSite.OlgaSpaModule {
    export interface TreatmentsRow {
        IdTreatment?: number;
        DescriptionTreatment?: string;
    }

    export namespace TreatmentsRow {
        export const idProperty = 'IdTreatment';
        export const nameProperty = 'DescriptionTreatment';
        export const localTextPrefix = 'OlgaSpaModule.Treatments';

        export namespace Fields {
            export declare const IdTreatment: string;
            export declare const DescriptionTreatment: string;
        }

        ['IdTreatment', 'DescriptionTreatment'].forEach(x => (<any>Fields)[x] = x);
    }
}

