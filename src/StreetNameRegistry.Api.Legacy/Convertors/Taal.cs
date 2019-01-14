namespace StreetNameRegistry.Api.Legacy.Convertors
{
    using Be.Vlaanderen.Basisregisters.GrAr.Legacy;

    public static class TaalExtensions
    {
        public static Language ConvertFromTaal(this Taal? taal)
            => ConvertFromTaal(taal ?? Taal.NL);

        public static Language ConvertFromTaal(this Taal taal)
        {
            switch (taal)
            {
                default:
                case Taal.NL:
                    return Language.Dutch;

                case Taal.FR:
                    return Language.French;

                case Taal.DE:
                    return Language.German;

                case Taal.EN:
                    return Language.English;
            }
        }
    }
}
