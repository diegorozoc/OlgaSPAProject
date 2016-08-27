namespace OlgaSpaWebSite.OlgaSpaModule {
    export interface PackagesRow {
        IdPackage?: number;
        DescriptionPackage?: string;
        SuggestedCost?: number;
        Sessions?: number;
    }

    export namespace PackagesRow {
        export const idProperty = 'IdPackage';
        export const nameProperty = 'DescriptionPackage';
        export const localTextPrefix = 'OlgaSpaModule.Packages';

        export namespace Fields {
            export declare const IdPackage: string;
            export declare const DescriptionPackage: string;
            export declare const SuggestedCost: string;
            export declare const Sessions: string;
        }

        ['IdPackage', 'DescriptionPackage', 'SuggestedCost', 'Sessions'].forEach(x => (<any>Fields)[x] = x);
    }
}

