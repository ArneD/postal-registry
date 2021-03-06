namespace PostalRegistry.Projections.Syndication.Municipality
{
    public enum MunicipalityEvent
    {
        MunicipalityWasRegistered,
        MunicipalityWasNamed,
        MunicipalityNameWasCleared,
        MunicipalityNameWasCorrected,
        MunicipalityNameWasCorrectedToCleared,
        MunicipalityNisCodeWasDefined,
        MunicipalityNisCodeWasCorrected,
        MunicipalityOfficialLanguageWasAdded,
        MunicipalityOfficialLanguageWasRemoved,
        MunicipalityFacilitiesLanguageWasAdded,
        MunicipalityFacilitiesLanguageWasRemoved,

        MunicipalityWasDrawn,
        MunicipalityGeometryWasCleared,
        MunicipalityGeometryWasCorrected,
        MunicipalityGeometryWasCorrectedToCleared,
        MunicipalityBecameCurrent,
        MunicipalityWasRetired,
        MunicipalityWasCorrectedToCurrent,
        MunicipalityWasCorrectedToRetired,
    }
}
