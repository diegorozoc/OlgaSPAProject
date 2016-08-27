namespace OlgaSpaWebSite.OlgaSpaModule {
    export interface AppoinmentsRow {
        IdAppointment?: number;
        IdCustomer?: number;
        IdPackage?: number;
        IdTreatment?: number;
        StartDateDteAppointment?: string;
        EndDateDteAppointment?: string;
        DescriptionAppoinment?: string;
    }

    export namespace AppoinmentsRow {
        export const idProperty = 'IdAppointment';
        export const nameProperty = 'DescriptionAppoinment';
        export const localTextPrefix = 'OlgaSpaModule.Appoinments';

        export namespace Fields {
            export declare const IdAppointment: string;
            export declare const IdCustomer: string;
            export declare const IdPackage: string;
            export declare const IdTreatment: string;
            export declare const StartDateDteAppointment: string;
            export declare const EndDateDteAppointment: string;
            export declare const DescriptionAppoinment: string;
        }

        ['IdAppointment', 'IdCustomer', 'IdPackage', 'IdTreatment', 'StartDateDteAppointment', 'EndDateDteAppointment', 'DescriptionAppoinment'].forEach(x => (<any>Fields)[x] = x);
    }
}

