using SearchNavigator.Data.Entities.Constants;

namespace SearchNavigator.Helpers
{
    public class DisplayHelper
    {
        public static string GetTransmissionTranslate(string? BaseTransmissionValue)
        {
            switch (BaseTransmissionValue)
            {
                case CarConst.MECHANIC_TRANSMISSION_NAME:
                    return "Механическая";
                case CarConst.AUTOMATIC_TRANSMISSION_NAME:
                    return "Автоматическая";
                default:
                    return "Автоматическая";
            }
        }
    }
}
