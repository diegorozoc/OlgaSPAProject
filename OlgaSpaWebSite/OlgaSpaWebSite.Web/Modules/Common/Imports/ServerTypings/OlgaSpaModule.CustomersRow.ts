namespace OlgaSpaWebSite.OlgaSpaModule {
    export interface CustomersRow {
        IdCustomer?: number;
        FirstNameCustomer?: string;
        LastNameCustomer?: string;
        Email?: string;
        Address?: string;
        ContactNumber1?: string;
        ContactNumber2?: string;
        Country?: string;
        City?: string;
        RegistrationDate?: string;
        ModificationDate?: string;
    }

    export namespace CustomersRow {
        export const idProperty = 'IdCustomer';
        export const nameProperty = 'FirstNameCustomer';
        export const localTextPrefix = 'OlgaSpaModule.Customers';
        export const lookupKey = 'OlgaSpaModule.Customers';

        export function getLookup(): Q.Lookup<CustomersRow> {
            return Q.getLookup<CustomersRow>('OlgaSpaModule.Customers');
        }

        export namespace Fields {
            export declare const IdCustomer: string;
            export declare const FirstNameCustomer: string;
            export declare const LastNameCustomer: string;
            export declare const Email: string;
            export declare const Address: string;
            export declare const ContactNumber1: string;
            export declare const ContactNumber2: string;
            export declare const Country: string;
            export declare const City: string;
            export declare const RegistrationDate: string;
            export declare const ModificationDate: string;
        }

        ['IdCustomer', 'FirstNameCustomer', 'LastNameCustomer', 'Email', 'Address', 'ContactNumber1', 'ContactNumber2', 'Country', 'City', 'RegistrationDate', 'ModificationDate'].forEach(x => (<any>Fields)[x] = x);
    }
}

