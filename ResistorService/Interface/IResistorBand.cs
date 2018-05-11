namespace ResistorService.Interface
{
    public interface IResistorBand
    {
        int GetBandValue(string bandColor);
        double GetToleranceValue(string bandColor);    
    }
}
