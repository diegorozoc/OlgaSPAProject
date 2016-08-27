namespace OlgaSpaWebSite {
    export interface ExcelImportResponse extends Serenity.ServiceResponse {
        Inserted?: number
        Updated?: number
        ErrorList?: string[]
    }
}

