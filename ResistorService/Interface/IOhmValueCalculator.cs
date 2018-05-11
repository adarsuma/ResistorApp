using System.Collections.Generic;

namespace ResistorService.Interface
{
    public interface IOhmValueCalculator
    {
        int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor);
        IList<double> CalculateTolerance(string bandColor, int ohmsValue);
    }
}
